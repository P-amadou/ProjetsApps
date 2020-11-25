package bibliothèque;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.FormatStyle;
import java.util.Date;
import java.util.Locale;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;
import abonnés.Abonés;

public class Livre implements Document {
	private String titre,auteur,éditeur;
	private LocalDate date_sortie,date_retour,date_emprunt,date_réservation;
	private Date currentTime;
	private int numéro,effectif;
	private boolean disponible;
	private Scanner sc= new Scanner(System.in);
	private boolean récupérer;
	private boolean réservé;
	private String nom_biliothèque;//BIBLIOTHEQUE
	private String abo_prénom, abo_nom;//ABONE
	private int abo_numéro;//ABONE
	private Socket socket;//ABONE
	private Bibliothèque b=new Bibliothèque(nom_biliothèque);
	private Abonés abo = new Abonés(abo_prénom, abo_nom,abo_numéro,socket);
	
	public Livre(String titre,String auteur,String éditeur,LocalDate date_sortie,int numéro,boolean disponible,int effectif)throws EffectifException {
		if (effectif<=0) {
			throw new EffectifException(effectif +" n'est pas une valeur acceptée ! \n"+
		"Vous ne pouvez pas insérer un effectif négatif ou nul de documents dans le stock !");
		} else {
			this.titre=titre;
			this.auteur=auteur;
			this.éditeur=éditeur;
			this.date_sortie=date_sortie;
			this.numéro=numéro;
			this.date_emprunt=null;
			this.date_retour=null;
			this.date_réservation=null;
			this.disponible=disponible;
			this.setEffectif(effectif);
			this.réservé=false;
			this.récupérer=false;
			this.nom_biliothèque=b.getNom();
		}
	}
	
	@Override
	public void reserver(Abonés ab) throws EmpruntException {
		
		System.out.println("Entrez le numéro du document ! \n");	
		int numéro_entré=sc.nextInt();			
		SimpleDateFormat formatter2 = new SimpleDateFormat ("HH:mm");
		this.currentTime = new Date();
		String heureString = formatter2.format(currentTime);
		for (int j = 0; j < b.getStock().size(); j++) {
			if (b.getStock().get(j).numero()==numéro_entré  && b.getStock().get(j).isDisponible()==true && getEffectif()>0) {
					System.out.println("Confirmez-vous la réservation de "+b.getStock().get(j).getTitre()+" de "+ b.getStock().get(j).getAuteur()+" ? (O/N) (o/n)");
					String réponse=sc.next();
					Livre l = this;
					switch (réponse) {
						case "O":	
							l.setTitre(b.getStock().get(j).getTitre());
							l.setAuteur(b.getStock().get(j).getAuteur());
							l.setÉditeur(b.getStock().get(j).getÉditeur());
							l.setDate_réservation(getDate_réservation());
							l.setEffectif(getEffectif()-1);
							if (getEffectif()==0) {
								l.setDisponible(false);
							}
							ab.getRéservés().add(l);
							réservé=true;
							System.out.println("Votre livre a été réservé le "+getDate_réservation()+" à "+heureString+". \n");
							System.out.println("Vous avez 2 heures pour le récupérer à la bibliothèque !\n");	
							System.out.println("Fin de la réservation !");
							break;
						case "o":
							l.setTitre(b.getStock().get(j).getTitre());
							l.setAuteur(b.getStock().get(j).getAuteur());
							l.setÉditeur(b.getStock().get(j).getÉditeur());
							l.setDate_réservation(getDate_réservation());
							l.setEffectif(getEffectif()-1);
							if (getEffectif()==0) {
								l.setDisponible(false);
							}
							
							ab.getRéservés().add(l);
							réservé=true;
							System.out.println("Votre livre a été réservé le "+getDate_réservation()+" à "+heureString+"\n");
							System.out.println("Vous avez 2 heures pour le récupérer à la bibliothèque !\n");
							System.out.println("Fin de la réservation !");
							break;
						case "n":
							réservé=false;
							System.out.println("La réservation est annulée !\n");
							System.out.println("Fin de la réservation !");
							break;
						case "N":
							réservé=false;
							System.out.println("La réservation est annulée !\n");
							System.out.println("Fin de la réservation !");
							break;
						default:
							System.err.println("Entrez oui (o/O) ou non (n/N)");
							break;
					}//switch
			}//if
			
			else {
				throw new EmpruntException("Nous ne connaissons pas ce numéro, veuillez réessayer !");
			}//else
			
				
		}//for
		
	}//Méthode réservé (Aboné ab)

	

	@Override
	public void emprunter(Abonés ab) throws EmpruntException{
		System.out.println("Avez vous réserver ? (O/N) (o/n) \n");
		String réponse_réservé=sc.next();
		if ((réponse_réservé=="O" || réponse_réservé=="o")) {
			System.out.println("Entrez le numéro du livre réservé ! \n");
			int num_réserve=sc.nextInt();
			for (int i = 0; i < ab.getRéservés().size(); i++) {
				if (num_réserve==ab.getRéservés().get(i).getNuméro() && récupérer==false && ab.getRéservés().get(i).getCurrentTime().getTime()
						<ab.getRéservés().get(i).getCurrentTime().getTime()+ TimeUnit.HOURS.toMillis(2) &&réservé==true) { //TimeUnit.HOURS.toMillis(2) ajoute 2 heures.
					récupérer=true;
					this.b.getStock().remove(i);
					ab.get_emprunts_actuels().add(ab.getRéservés().get(i));
					ab.getRéservés().get(i).setEffectif(getEffectif()-1);
					if (getEffectif()==0) {
						ab.getRéservés().remove(i);
					}
					
				}//if
				else if(récupérer==true && num_réserve==ab.getRéservés().get(i).getNuméro() ){
					throw new EmpruntException("Vous avez déjà emprunter ce livre !\n");
				}//else if
			}//for
		}//if
		else if(réponse_réservé!="N" || réponse_réservé!="n" ||réponse_réservé!="O" || réponse_réservé!="o") {
			System.out.println("Veuillez entrez Oui (O/o) ou Non (N/n) ! \n");
		}//else if
		else if(réponse_réservé=="N" || réponse_réservé=="n") {
			System.out.println("Combien(s) de livres souhaitez-vous emprunter (10 maximum) ?");
			int nb_livre=sc.nextInt();
			if (nb_livre>10) {
				throw new EmpruntException("Vous ne pouvez pas emprunter au dela de 10 documents !!\n ");
			}else if(nb_livre<=0){
				throw new EmpruntException("Vous ne pouvez pas mettre un nombre nul ou négatif d'emprunts !!\n ");
			}else if(nb_livre<10 && nb_livre>0) {
				System.out.println("Quel(s) livre(s) voulez-vous emprunter ? (indiquer le numéro)\n");
				int num_emprunt_livre[]=new int[nb_livre];
				for (int i = 0; i < nb_livre; i++) {
					System.out.println("Livre numéro "+(i+1)+"\n");
					num_emprunt_livre[i]=sc.nextInt();
					for (int j = 0; j < ab.getRéservés().size(); j++) {
						for (int x = 0; x< this.b.getStock().size(); x++) {
							if ((num_emprunt_livre[i]==ab.getRéservés().get(j).getNuméro() && (réservé==true ||réservé==false) )
									|| (num_emprunt_livre[i]==b.getStock().get(x).getNuméro() && réservé==true)) {
								throw new EmpruntException("Vous ne pouvez pas emprunter un livre déjà résevé !!\n ");
							}//if
							else if(réservé==false && num_emprunt_livre[i]==this.b.getStock().get(x).getNuméro()){
								System.out.println("Vous vous apprêter à emprunter "+this.b.getStock().get(x).titre+" de "+this.b.getStock().get(x).auteur);
								ab.get_emprunts_actuels().add(this.b.getStock().get(x));
								this.b.getStock().get(x).setEffectif(effectif-1);
								if (this.b.getStock().get(x).getEffectif()==0) {
									this.b.getStock().remove(x);
								}
								
							}//else if
						}//for x
					}//for j
				}//for i	
			}//else if
		}//else if
	}//méthode emprunter.

	@Override
	public void retour() throws RetourException {
		System.out.println("Souhaitez-vous rendre un(des) document(s) (Tapez 1)  ou bien annuler une réservation ? (Tapez 2)");
		int réponse1_2=sc.nextInt();
		if (réponse1_2==1) {
			System.out.println("Combiens de livres devez vous rendre (10 maximum) ?");
			int livre_rendre=sc.nextInt();	
			if (livre_rendre>10) {
				throw new RetourException("Vous ne pouvez pas rendre plus de 10 documents !");
			}//if
			else if (livre_rendre<=0) {
				throw new RetourException("Vous ne pouvez pas ne rien rendre ou bien mettre un effectif négatif de documents !");
			}//else if
			else if (livre_rendre>0 && livre_rendre<=10) {
				System.out.println("Veuillez indiquer le numéro du (des) livre(s) à remettre !");
				int num_retour_livre[]=new int[livre_rendre];
				//La boucle for est bonne ! Elle permet de déclarer les livres à rendre par leur numéro !
				for (int i = 0; i < livre_rendre; i++) {
					i++;
					if (i==1) {
						System.out.println(i+"er livre :");
						i--;
						num_retour_livre[i]=sc.nextInt();
					}//if
					else {
						System.out.println(i+"ème livre :");
						i--;
						num_retour_livre[i]=sc.nextInt();
					}//else
					
				}//for
				System.out.println("Êtes-vous sûr de vouloir rendre tous ces documents ?(O/N) (o/n) \n");
				
				for (int i = 0; i < num_retour_livre.length; i++) {
					for (Livre l:b.getInventaire_doc()) {
						if (num_retour_livre[i]==l.numéro) {
							System.out.println(l.titre+" de "+l.auteur+"\n");
						}//if
					}//for
				}//for
				String réponse=sc.next();
				if (réponse=="O" || réponse=="o") {
					for (int i = 0; i < num_retour_livre.length; i++) {
						for (Livre l:b.getInventaire_doc()) {
							for (int j = 0; j < abo.get_emprunts_actuels().size(); j++) {
								if (num_retour_livre[i]==l.numéro && num_retour_livre[i]==abo.get_emprunts_actuels().get(j).numéro) {
									b.getStock().add(l);//ajoute le livre qui a été retourné par l'aboné dans le stock
									abo.get_emprunts_actuels().remove(j); //supprime le livre à la position concerné dans les emprunts de l'abonée
								}//if 
							}//for
						}//for
					}//for
				}//if
				for (int j = 0; j < num_retour_livre.length; j++) {
					System.out.println(" \n");
				}
			}//else if
		}//Condition if
		else if(réponse1_2==2) {
			System.out.println("Commencer par rentré le numéro de votre document svp ! ");
			int num_doc=sc.nextInt();
			for (int i = 0; i < abo.getRéservés().size(); i++) {
				if (num_doc==abo.getRéservés().get(i).getNuméro() && réservé==true) {
					réservé=false;
					abo.getRéservés().remove(i);
					System.out.println("Votre réservation a bien été annulée !");
				}else if(!abo.getRéservés().contains(abo.getRéservés().get(i)) && abo.getRéservés().get(i).getNuméro()==num_doc ) {
					throw new RetourException("Votre numéro est invalide car nous ne pouvons trouver votre document dans nos stocks");
				}
			}
		}else if(réponse1_2!=1 && réponse1_2!=2){
			throw new RetourException("Réponse incorrecte veuillez rentrer soit 1 (pour rendre un document) ou 2 (pour annuler une réservation) !");
		}
		
	}//Methode retour 

	@Override
	public int numero() {//Cette méthode attribue automatiquement un numéro à chaque documents. Dans le code du main faudrait peut-être la lancer en premier !
		int i=0;
		for (Livre livre : b.getStock()) {
			if (b.getStock().contains(livre)) { //Si le livre en question existe dans le stock de livre
				livre.numéro=i++;
			}
		}
		return getNuméro();
	}
	
	public String toString() {
		int taille=0;
		DateTimeFormatter frenchFormatter = DateTimeFormatter.ofLocalizedDate(FormatStyle.MEDIUM).withLocale(Locale.GERMAN);
		LocalDate  currentTime_1 = LocalDate.parse("24.12.2014", frenchFormatter);
		//EffectifException effexc;
		System.out.println("Entrez une taille pour le stock de documents !\n Puis ensuite entrez les informations des documents que vous voulez stocker !");
		taille=sc.nextInt();
		String titre[]=new String[taille];
		String auteur[]=new String[taille];
		String éditeur[]=new String[taille];
		int effectif[]=new int[taille];
		Livre l=null;
		String phrase=null;
		for (int i = 0; i < taille; i++) {
			try {
				//On vide la ligne avant d'en lire une autre
				sc.nextLine();
				System.out.println("Titre : \n");titre[i]=sc.nextLine();
				System.out.println("Auteur : \n");auteur[i]=sc.nextLine();
				System.out.println("Editeur : \n");éditeur[i]=sc.nextLine();
				System.out.println("Effectif  :  \n");effectif[i]=sc.nextInt();
				l=new Livre(titre[i], auteur[i], éditeur[i], currentTime_1 ,0,true,effectif[i]);
				b.getStock().add(l);
				phrase= "Titre : "+b.getInventaire_doc().get(i).getTitre()+"\n"+
						"Auteur : "+b.getInventaire_doc().get(i).getAuteur()+"\n"+
						"Editeur : "+b.getInventaire_doc().get(i).getÉditeur()+"\n"+
						"Effectif : "+b.getInventaire_doc().get(i).getEffectif()+"\n";
				System.out.println(phrase+"\n");
				System.out.println("Quel livre voulez-vous voir ?");
			} catch (EffectifException e) {
				System.out.println(e.getMessage());
			}
			
		}//for
		l.numero();
		return phrase;
	}
	
	public String getTitre() {
		return titre;
	}

	public void setTitre(String titre) {
		this.titre = titre;
	}

	public String getAuteur() {
		return auteur;
	}

	public void setAuteur(String auteur) {
		this.auteur = auteur;
	}

	public String getÉditeur() {
		return éditeur;
	}

	public void setÉditeur(String éditeur) {
		this.éditeur = éditeur;
	}

	public LocalDate getDate_sortie() {
		return date_sortie;
	}

	public void setDate_sortie(LocalDate date_sortie) {
		this.date_sortie = date_sortie;
	}
	
	public LocalDate getDate_retour() {
		return date_retour;
	}

	public void setDate_retour(LocalDate date_retour) {
		this.date_retour = date_retour;
	}

	public LocalDate getDate_emprunt() {
		return date_emprunt;
	}

	public void setDate_emprunt(LocalDate date_emprunt) {
		this.date_emprunt = date_emprunt;
	}

	public int getNuméro() {
		return numéro;
	}

	public void setNuméro(int numéro) {
		this.numéro = numéro;
	}

	public boolean isDisponible() {
		return disponible;
	}

	public void setDisponible(boolean disponible) {
		this.disponible = disponible;
	}

	public LocalDate getDate_réservation() {
		return date_réservation;
	}

	public void setDate_réservation(LocalDate date_réservation) {
		this.date_réservation = date_réservation;
	}

	public int getEffectif() {
		return effectif;
	}

	public void setEffectif(int effectif) {
		this.effectif = effectif;
	}

	public boolean isRécupérer() {
		return récupérer;
	}

	public void setRécupérer(boolean récupérer) {
		this.récupérer = récupérer;
	}
	
	public boolean isRéservé() {
		return réservé;
	}

	public void setRéservé(boolean réservé) {
		this.réservé = réservé;
	}
	
	public Date getCurrentTime() {
		return currentTime;
	}

	public void setCurrentTime(Date currentTime) {
		this.currentTime = currentTime;
	}
	
	public String getNom_biliothèque() {
		return nom_biliothèque;
	}
	public void setNom_biliothèque(String nom_biliothèque) {
		this.nom_biliothèque = nom_biliothèque;
	}

}