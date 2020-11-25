package abonnés;
import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.text.DateFormat;
import java.util.ArrayList;
import java.util.Date;

import bibliothèque.Bibliothèque;
import bibliothèque.Livre;

public class Abonés implements Runnable{
	private String prénom, nom;
	private int numéro;
	private ArrayList <Livre> emprunts_actuels,réservés;
	private String nom_biliothèque;
	private Bibliothèque b=new Bibliothèque(nom_biliothèque);
	private Socket sock;
	private PrintWriter writer = null;
	private BufferedInputStream reader = null;
	   
	public Abonés(String prénom,String nom,int numéro,Socket pSock) {
		this.prénom=prénom;
		this.nom=nom;
		this.numéro=numéro;
		this.emprunts_actuels=new ArrayList<Livre>();
		this.réservés=new ArrayList<Livre>();
		this.sock=pSock;
	}
	
	public int attribuer_numéro_ab() {//Cette méthode attribue automatiquement un numéro à chaque abonés. Dans le code du main faudrait peut-être la lancer en premier !
		int i=0;
		for (Abonés abo : b.getListe_ab()) {
			if (b.getListe_ab().contains(abo)) { //Si l'aboné en question existe dans la liste d'abonés
				abo.numéro=i++;
				
			}
		}
		return getNuméro();
	}
	
	public String getPrénom() {
		return prénom;
	}

	public void setPrénom(String prénom) {
		this.prénom = prénom;
	}
	
	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public int getNuméro() {
		return numéro;
	}

	public void setNuméro(int numéro) {
		this.numéro = numéro;
	}

	public ArrayList<Livre> get_emprunts_actuels() {
		return emprunts_actuels;
	}

	public void set_emprunts_actuels(ArrayList<Livre> emprunts_actuels) {
		this.emprunts_actuels = emprunts_actuels;
	}

	public ArrayList <Livre> getRéservés() {
		return réservés;
	}

	public void setRéservés(ArrayList <Livre> réservés) {
		this.réservés = réservés;
	}
	
	private String read() throws IOException{//La méthode que nous utilisons pour lire les réponses      
	      String response = "";
	      int stream;
	      byte[] b = new byte[4096];
	      stream = reader.read(b);
	      response = new String(b, 0, stream);
	      return response;
	}
	@Override
	public void run() {
		System.err.println("Lancement du traitement de la connexion cliente !");
		boolean closeConnexion = false;
	    //tant que la connexion est active, on traite les demandes
		while (!this.sock.isClosed()) { //Tant que la socket sock n'est pas fermée.
			try {
				 //Ici, nous n'utilisons pas les mêmes objets que précédemment
	            //Je vous expliquerai pourquoi ensuite
	            writer = new PrintWriter(sock.getOutputStream());
	            reader = new BufferedInputStream(sock.getInputStream());
	            
	            //On attend la demande du client            
	            String response = read();
	            InetSocketAddress remote = (InetSocketAddress)sock.getRemoteSocketAddress();
	            
	            //On affiche quelques infos, pour le débuggage
	            
	            String debug = "";
	            debug = "Thread : " + Thread.currentThread().getName() + ". ";
	            debug += "Demande de l'adresse : " + remote.getAddress().getHostAddress() +".";
	            debug += " Sur le port : " + remote.getPort() + ".\n";
	            debug += "\t -> Commande reçue : " + response + "\n";
	            System.err.println("\n" + debug);
	            
	            //On traite la demande du client en fonction de la commande envoyée
	            String toSend = "";   
	            
	            switch(response.toUpperCase()){
	               case "FULL":
	                  toSend = DateFormat.getDateTimeInstance(DateFormat.FULL, DateFormat.MEDIUM).format(new Date());
	                  break;
	               case "DATE":
	                  toSend = DateFormat.getDateInstance(DateFormat.FULL).format(new Date());
	                  break;
	               case "HOUR":
	                  toSend = DateFormat.getTimeInstance(DateFormat.MEDIUM).format(new Date());
	                  break;
	               case "CLOSE":
	                  toSend = "Communication terminée"; 
	                  closeConnexion = true;
	                  break;
	               default : 
	                  toSend = "Commande inconnu !";                     
	                  break;
	            }
	            
	            //On envoie la réponse au client
	            writer.write(toSend);
	            //Il FAUT IMPERATIVEMENT UTILISER flush()
	            //Sinon les données ne seront pas transmises au client
	            //et il attendra indéfiniment
	            writer.flush();
	            
	            if(closeConnexion){
	               System.err.println("COMMANDE CLOSE DETECTEE ! ");
	               writer = null;
	               reader = null;
	               sock.close();
	               break;
	            }
	            
		      } catch (SocketException  e) {
		    	  	e.printStackTrace();
		      } catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}  
		  
	}//Fin de la méthode run()
	
	
	   
		
}

