package abonn�s;
import java.util.Scanner;

import biblioth�que.Biblioth�que;
import serveur.TimeServer;
	
public class Appli {
	private static Scanner sc=new Scanner(System.in);
	
	public static void main(String[] args)   {
		
		
		// ServerSocket sSocket = new ServerSocket(port, fileAttente, InetAddress.getByName(IP));
		//Le 3�me param�tre de cette m�thode qui vient de nous pr�c�der (InetAddress.getByName(IP)) est l'adresse IP qui va �couter notre socket
		 String host = "127.0.0.1";
	      int port = 2345;
	      int port_r�servation=2500,port_emprunt=2600, port_retours=2700;
	     
	     
	      //On lance nos 3 serveurs avec les 3 services diff�rents
	      TimeServer ts_r�servation = new TimeServer(host, port_r�servation);
	      TimeServer ts_emprunt = new TimeServer(host, port_emprunt);
	      TimeServer ts_retours = new TimeServer(host, port_retours);
	      //On allume les 3 serveurs
	      ts_r�servation.open();
	      ts_emprunt.open();
	      ts_retours.open();
	      
	      System.out.println("Entrez le nom de la biblioth�que !");
	      String nom_bibli=sc.nextLine();
	      Biblioth�que b=new Biblioth�que(nom_bibli); 
	      System.out.println("Serveur initialis�.");
	      
	      for(int i = 0; i < b.getListe_ab().size(); i++){// boucle for initialise le nombre de clients � travers ces threads qui les repr�sentent.
	         Thread t = new Thread(new Abon�sConnexion(host, port));//Initialisation d'un nouveau thread en ayant comme param�tre un abon� connect�.
	         //DOnc un nouvel abonn� sous forme de thread.
	         t.start();
	      }
		
		
	}



}
