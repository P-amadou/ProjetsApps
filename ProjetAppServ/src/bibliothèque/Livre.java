package biblioth�que;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.format.FormatStyle;
import java.util.Date;
import java.util.Locale;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;
import abonn�s.Abon�s;

public class Livre implements Document {
	private String titre,auteur,�diteur;
	private LocalDate date_sortie,date_retour,date_emprunt,date_r�servation;
	private Date currentTime;
	private int num�ro,effectif;
	private boolean disponible;
	private Scanner sc= new Scanner(System.in);
	private boolean r�cup�rer;
	private boolean r�serv�;
	private String nom_bilioth�que;//BIBLIOTHEQUE
	private String abo_pr�nom, abo_nom;//ABONE
	private int abo_num�ro;//ABONE
	private Socket socket;//ABONE
	private Biblioth�que b=new Biblioth�que(nom_bilioth�que);
	private Abon�s abo = new Abon�s(abo_pr�nom, abo_nom,abo_num�ro,socket);
	
	public Livre(String titre,String auteur,String �diteur,LocalDate date_sortie,int num�ro,boolean disponible,int effectif)throws EffectifException {
		if (effectif<=0) {
			throw new EffectifException(effectif +" n'est pas une valeur accept�e ! \n"+
		"Vous ne pouvez pas ins�rer un effectif n�gatif ou nul de documents dans le stock !");
		} else {
			this.titre=titre;
			this.auteur=auteur;
			this.�diteur=�diteur;
			this.date_sortie=date_sortie;
			this.num�ro=num�ro;
			this.date_emprunt=null;
			this.date_retour=null;
			this.date_r�servation=null;
			this.disponible=disponible;
			this.setEffectif(effectif);
			this.r�serv�=false;
			this.r�cup�rer=false;
			this.nom_bilioth�que=b.getNom();
		}
	}
	
	@Override
	public void reserver(Abon�s ab) throws EmpruntException {
		
		System.out.println("Entrez le num�ro du document ! \n");	
		int num�ro_entr�=sc.nextInt();			
		SimpleDateFormat formatter2 = new SimpleDateFormat ("HH:mm");
		this.currentTime = new Date();
		String heureString = formatter2.format(currentTime);
		for (int j = 0; j < b.getStock().size(); j++) {
			if (b.getStock().get(j).numero()==num�ro_entr�  && b.getStock().get(j).isDisponible()==true && getEffectif()>0) {
					System.out.println("Confirmez-vous la r�servation de "+b.getStock().get(j).getTitre()+" de "+ b.getStock().get(j).getAuteur()+" ? (O/N) (o/n)");
					String r�ponse=sc.next();
					Livre l = this;
					switch (r�ponse) {
						case "O":	
							l.setTitre(b.getStock().get(j).getTitre());
							l.setAuteur(b.getStock().get(j).getAuteur());
							l.set�diteur(b.getStock().get(j).get�diteur());
							l.setDate_r�servation(getDate_r�servation());
							l.setEffectif(getEffectif()-1);
							if (getEffectif()==0) {
								l.setDisponible(false);
							}
							ab.getR�serv�s().add(l);
							r�serv�=true;
							System.out.println("Votre livre a �t� r�serv� le "+getDate_r�servation()+" � "+heureString+". \n");
							System.out.println("Vous avez 2 heures pour le r�cup�rer � la biblioth�que !\n");	
							System.out.println("Fin de la r�servation !");
							break;
						case "o":
							l.setTitre(b.getStock().get(j).getTitre());
							l.setAuteur(b.getStock().get(j).getAuteur());
							l.set�diteur(b.getStock().get(j).get�diteur());
							l.setDate_r�servation(getDate_r�servation());
							l.setEffectif(getEffectif()-1);
							if (getEffectif()==0) {
								l.setDisponible(false);
							}
							
							ab.getR�serv�s().add(l);
							r�serv�=true;
							System.out.println("Votre livre a �t� r�serv� le "+getDate_r�servation()+" � "+heureString+"\n");
							System.out.println("Vous avez 2 heures pour le r�cup�rer � la biblioth�que !\n");
							System.out.println("Fin de la r�servation !");
							break;
						case "n":
							r�serv�=false;
							System.out.println("La r�servation est annul�e !\n");
							System.out.println("Fin de la r�servation !");
							break;
						case "N":
							r�serv�=false;
							System.out.println("La r�servation est annul�e !\n");
							System.out.println("Fin de la r�servation !");
							break;
						default:
							System.err.println("Entrez oui (o/O) ou non (n/N)");
							break;
					}//switch
			}//if
			
			else {
				throw new EmpruntException("Nous ne connaissons pas ce num�ro, veuillez r�essayer !");
			}//else
			
				
		}//for
		
	}//M�thode r�serv� (Abon� ab)

	

	@Override
	public void emprunter(Abon�s ab) throws EmpruntException{
		System.out.println("Avez vous r�server ? (O/N) (o/n) \n");
		String r�ponse_r�serv�=sc.next();
		if ((r�ponse_r�serv�=="O" || r�ponse_r�serv�=="o")) {
			System.out.println("Entrez le num�ro du livre r�serv� ! \n");
			int num_r�serve=sc.nextInt();
			for (int i = 0; i < ab.getR�serv�s().size(); i++) {
				if (num_r�serve==ab.getR�serv�s().get(i).getNum�ro() && r�cup�rer==false && ab.getR�serv�s().get(i).getCurrentTime().getTime()
						<ab.getR�serv�s().get(i).getCurrentTime().getTime()+ TimeUnit.HOURS.toMillis(2) &&r�serv�==true) { //TimeUnit.HOURS.toMillis(2) ajoute 2 heures.
					r�cup�rer=true;
					this.b.getStock().remove(i);
					ab.get_emprunts_actuels().add(ab.getR�serv�s().get(i));
					ab.getR�serv�s().get(i).setEffectif(getEffectif()-1);
					if (getEffectif()==0) {
						ab.getR�serv�s().remove(i);
					}
					
				}//if
				else if(r�cup�rer==true && num_r�serve==ab.getR�serv�s().get(i).getNum�ro() ){
					throw new EmpruntException("Vous avez d�j� emprunter ce livre !\n");
				}//else if
			}//for
		}//if
		else if(r�ponse_r�serv�!="N" || r�ponse_r�serv�!="n" ||r�ponse_r�serv�!="O" || r�ponse_r�serv�!="o") {
			System.out.println("Veuillez entrez Oui (O/o) ou Non (N/n) ! \n");
		}//else if
		else if(r�ponse_r�serv�=="N" || r�ponse_r�serv�=="n") {
			System.out.println("Combien(s) de livres souhaitez-vous emprunter (10 maximum) ?");
			int nb_livre=sc.nextInt();
			if (nb_livre>10) {
				throw new EmpruntException("Vous ne pouvez pas emprunter au dela de 10 documents !!\n ");
			}else if(nb_livre<=0){
				throw new EmpruntException("Vous ne pouvez pas mettre un nombre nul ou n�gatif d'emprunts !!\n ");
			}else if(nb_livre<10 && nb_livre>0) {
				System.out.println("Quel(s) livre(s) voulez-vous emprunter ? (indiquer le num�ro)\n");
				int num_emprunt_livre[]=new int[nb_livre];
				for (int i = 0; i < nb_livre; i++) {
					System.out.println("Livre num�ro "+(i+1)+"\n");
					num_emprunt_livre[i]=sc.nextInt();
					for (int j = 0; j < ab.getR�serv�s().size(); j++) {
						for (int x = 0; x< this.b.getStock().size(); x++) {
							if ((num_emprunt_livre[i]==ab.getR�serv�s().get(j).getNum�ro() && (r�serv�==true ||r�serv�==false) )
									|| (num_emprunt_livre[i]==b.getStock().get(x).getNum�ro() && r�serv�==true)) {
								throw new EmpruntException("Vous ne pouvez pas emprunter un livre d�j� r�sev� !!\n ");
							}//if
							else if(r�serv�==false && num_emprunt_livre[i]==this.b.getStock().get(x).getNum�ro()){
								System.out.println("Vous vous appr�ter � emprunter "+this.b.getStock().get(x).titre+" de "+this.b.getStock().get(x).auteur);
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
	}//m�thode emprunter.

	@Override
	public void retour() throws RetourException {
		System.out.println("Souhaitez-vous rendre un(des) document(s) (Tapez 1)  ou bien annuler une r�servation ? (Tapez 2)");
		int r�ponse1_2=sc.nextInt();
		if (r�ponse1_2==1) {
			System.out.println("Combiens de livres devez vous rendre (10 maximum) ?");
			int livre_rendre=sc.nextInt();	
			if (livre_rendre>10) {
				throw new RetourException("Vous ne pouvez pas rendre plus de 10 documents !");
			}//if
			else if (livre_rendre<=0) {
				throw new RetourException("Vous ne pouvez pas ne rien rendre ou bien mettre un effectif n�gatif de documents !");
			}//else if
			else if (livre_rendre>0 && livre_rendre<=10) {
				System.out.println("Veuillez indiquer le num�ro du (des) livre(s) � remettre !");
				int num_retour_livre[]=new int[livre_rendre];
				//La boucle for est bonne ! Elle permet de d�clarer les livres � rendre par leur num�ro !
				for (int i = 0; i < livre_rendre; i++) {
					i++;
					if (i==1) {
						System.out.println(i+"er livre :");
						i--;
						num_retour_livre[i]=sc.nextInt();
					}//if
					else {
						System.out.println(i+"�me livre :");
						i--;
						num_retour_livre[i]=sc.nextInt();
					}//else
					
				}//for
				System.out.println("�tes-vous s�r de vouloir rendre tous ces documents ?(O/N) (o/n) \n");
				
				for (int i = 0; i < num_retour_livre.length; i++) {
					for (Livre l:b.getInventaire_doc()) {
						if (num_retour_livre[i]==l.num�ro) {
							System.out.println(l.titre+" de "+l.auteur+"\n");
						}//if
					}//for
				}//for
				String r�ponse=sc.next();
				if (r�ponse=="O" || r�ponse=="o") {
					for (int i = 0; i < num_retour_livre.length; i++) {
						for (Livre l:b.getInventaire_doc()) {
							for (int j = 0; j < abo.get_emprunts_actuels().size(); j++) {
								if (num_retour_livre[i]==l.num�ro && num_retour_livre[i]==abo.get_emprunts_actuels().get(j).num�ro) {
									b.getStock().add(l);//ajoute le livre qui a �t� retourn� par l'abon� dans le stock
									abo.get_emprunts_actuels().remove(j); //supprime le livre � la position concern� dans les emprunts de l'abon�e
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
		else if(r�ponse1_2==2) {
			System.out.println("Commencer par rentr� le num�ro de votre document svp ! ");
			int num_doc=sc.nextInt();
			for (int i = 0; i < abo.getR�serv�s().size(); i++) {
				if (num_doc==abo.getR�serv�s().get(i).getNum�ro() && r�serv�==true) {
					r�serv�=false;
					abo.getR�serv�s().remove(i);
					System.out.println("Votre r�servation a bien �t� annul�e !");
				}else if(!abo.getR�serv�s().contains(abo.getR�serv�s().get(i)) && abo.getR�serv�s().get(i).getNum�ro()==num_doc ) {
					throw new RetourException("Votre num�ro est invalide car nous ne pouvons trouver votre document dans nos stocks");
				}
			}
		}else if(r�ponse1_2!=1 && r�ponse1_2!=2){
			throw new RetourException("R�ponse incorrecte veuillez rentrer soit 1 (pour rendre un document) ou 2 (pour annuler une r�servation) !");
		}
		
	}//Methode retour 

	@Override
	public int numero() {//Cette m�thode attribue automatiquement un num�ro � chaque documents. Dans le code du main faudrait peut-�tre la lancer en premier !
		int i=0;
		for (Livre livre : b.getStock()) {
			if (b.getStock().contains(livre)) { //Si le livre en question existe dans le stock de livre
				livre.num�ro=i++;
			}
		}
		return getNum�ro();
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
		String �diteur[]=new String[taille];
		int effectif[]=new int[taille];
		Livre l=null;
		String phrase=null;
		for (int i = 0; i < taille; i++) {
			try {
				//On vide la ligne avant d'en lire une autre
				sc.nextLine();
				System.out.println("Titre : \n");titre[i]=sc.nextLine();
				System.out.println("Auteur : \n");auteur[i]=sc.nextLine();
				System.out.println("Editeur : \n");�diteur[i]=sc.nextLine();
				System.out.println("Effectif  :  \n");effectif[i]=sc.nextInt();
				l=new Livre(titre[i], auteur[i], �diteur[i], currentTime_1 ,0,true,effectif[i]);
				b.getStock().add(l);
				phrase= "Titre : "+b.getInventaire_doc().get(i).getTitre()+"\n"+
						"Auteur : "+b.getInventaire_doc().get(i).getAuteur()+"\n"+
						"Editeur : "+b.getInventaire_doc().get(i).get�diteur()+"\n"+
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

	public String get�diteur() {
		return �diteur;
	}

	public void set�diteur(String �diteur) {
		this.�diteur = �diteur;
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

	public int getNum�ro() {
		return num�ro;
	}

	public void setNum�ro(int num�ro) {
		this.num�ro = num�ro;
	}

	public boolean isDisponible() {
		return disponible;
	}

	public void setDisponible(boolean disponible) {
		this.disponible = disponible;
	}

	public LocalDate getDate_r�servation() {
		return date_r�servation;
	}

	public void setDate_r�servation(LocalDate date_r�servation) {
		this.date_r�servation = date_r�servation;
	}

	public int getEffectif() {
		return effectif;
	}

	public void setEffectif(int effectif) {
		this.effectif = effectif;
	}

	public boolean isR�cup�rer() {
		return r�cup�rer;
	}

	public void setR�cup�rer(boolean r�cup�rer) {
		this.r�cup�rer = r�cup�rer;
	}
	
	public boolean isR�serv�() {
		return r�serv�;
	}

	public void setR�serv�(boolean r�serv�) {
		this.r�serv� = r�serv�;
	}
	
	public Date getCurrentTime() {
		return currentTime;
	}

	public void setCurrentTime(Date currentTime) {
		this.currentTime = currentTime;
	}
	
	public String getNom_bilioth�que() {
		return nom_bilioth�que;
	}
	public void setNom_bilioth�que(String nom_bilioth�que) {
		this.nom_bilioth�que = nom_bilioth�que;
	}

}