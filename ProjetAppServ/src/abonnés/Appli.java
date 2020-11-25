package abonnés;
import java.util.Scanner;

import bibliothèque.Bibliothèque;
import serveur.TimeServer;
	
public class Appli {
	private static Scanner sc=new Scanner(System.in);
	
	public static void main(String[] args)   {
		
		
		// ServerSocket sSocket = new ServerSocket(port, fileAttente, InetAddress.getByName(IP));
		//Le 3ème paramètre de cette méthode qui vient de nous précéder (InetAddress.getByName(IP)) est l'adresse IP qui va écouter notre socket
		 String host = "127.0.0.1";
	      int port = 2345;
	      int port_réservation=2500,port_emprunt=2600, port_retours=2700;
	     
	     
	      //On lance nos 3 serveurs avec les 3 services différents
	      TimeServer ts_réservation = new TimeServer(host, port_réservation);
	      TimeServer ts_emprunt = new TimeServer(host, port_emprunt);
	      TimeServer ts_retours = new TimeServer(host, port_retours);
	      //On allume les 3 serveurs
	      ts_réservation.open();
	      ts_emprunt.open();
	      ts_retours.open();
	      
	      System.out.println("Entrez le nom de la bibliothèque !");
	      String nom_bibli=sc.nextLine();
	      Bibliothèque b=new Bibliothèque(nom_bibli); 
	      System.out.println("Serveur initialisé.");
	      
	      for(int i = 0; i < b.getListe_ab().size(); i++){// boucle for initialise le nombre de clients à travers ces threads qui les représentent.
	         Thread t = new Thread(new AbonésConnexion(host, port));//Initialisation d'un nouveau thread en ayant comme paramètre un aboné connecté.
	         //DOnc un nouvel abonné sous forme de thread.
	         t.start();
	      }
		
		
	}



}
