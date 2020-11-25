package abonn�s;
import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.PrintWriter;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.text.DateFormat;
import java.util.ArrayList;
import java.util.Date;

import biblioth�que.Biblioth�que;
import biblioth�que.Livre;

public class Abon�s implements Runnable{
	private String pr�nom, nom;
	private int num�ro;
	private ArrayList <Livre> emprunts_actuels,r�serv�s;
	private String nom_bilioth�que;
	private Biblioth�que b=new Biblioth�que(nom_bilioth�que);
	private Socket sock;
	private PrintWriter writer = null;
	private BufferedInputStream reader = null;
	   
	public Abon�s(String pr�nom,String nom,int num�ro,Socket pSock) {
		this.pr�nom=pr�nom;
		this.nom=nom;
		this.num�ro=num�ro;
		this.emprunts_actuels=new ArrayList<Livre>();
		this.r�serv�s=new ArrayList<Livre>();
		this.sock=pSock;
	}
	
	public int attribuer_num�ro_ab() {//Cette m�thode attribue automatiquement un num�ro � chaque abon�s. Dans le code du main faudrait peut-�tre la lancer en premier !
		int i=0;
		for (Abon�s abo : b.getListe_ab()) {
			if (b.getListe_ab().contains(abo)) { //Si l'abon� en question existe dans la liste d'abon�s
				abo.num�ro=i++;
				
			}
		}
		return getNum�ro();
	}
	
	public String getPr�nom() {
		return pr�nom;
	}

	public void setPr�nom(String pr�nom) {
		this.pr�nom = pr�nom;
	}
	
	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public int getNum�ro() {
		return num�ro;
	}

	public void setNum�ro(int num�ro) {
		this.num�ro = num�ro;
	}

	public ArrayList<Livre> get_emprunts_actuels() {
		return emprunts_actuels;
	}

	public void set_emprunts_actuels(ArrayList<Livre> emprunts_actuels) {
		this.emprunts_actuels = emprunts_actuels;
	}

	public ArrayList <Livre> getR�serv�s() {
		return r�serv�s;
	}

	public void setR�serv�s(ArrayList <Livre> r�serv�s) {
		this.r�serv�s = r�serv�s;
	}
	
	private String read() throws IOException{//La m�thode que nous utilisons pour lire les r�ponses      
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
		while (!this.sock.isClosed()) { //Tant que la socket sock n'est pas ferm�e.
			try {
				 //Ici, nous n'utilisons pas les m�mes objets que pr�c�demment
	            //Je vous expliquerai pourquoi ensuite
	            writer = new PrintWriter(sock.getOutputStream());
	            reader = new BufferedInputStream(sock.getInputStream());
	            
	            //On attend la demande du client            
	            String response = read();
	            InetSocketAddress remote = (InetSocketAddress)sock.getRemoteSocketAddress();
	            
	            //On affiche quelques infos, pour le d�buggage
	            
	            String debug = "";
	            debug = "Thread : " + Thread.currentThread().getName() + ". ";
	            debug += "Demande de l'adresse : " + remote.getAddress().getHostAddress() +".";
	            debug += " Sur le port : " + remote.getPort() + ".\n";
	            debug += "\t -> Commande re�ue : " + response + "\n";
	            System.err.println("\n" + debug);
	            
	            //On traite la demande du client en fonction de la commande envoy�e
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
	                  toSend = "Communication termin�e"; 
	                  closeConnexion = true;
	                  break;
	               default : 
	                  toSend = "Commande inconnu !";                     
	                  break;
	            }
	            
	            //On envoie la r�ponse au client
	            writer.write(toSend);
	            //Il FAUT IMPERATIVEMENT UTILISER flush()
	            //Sinon les donn�es ne seront pas transmises au client
	            //et il attendra ind�finiment
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
		  
	}//Fin de la m�thode run()
	
	
	   
		
}

