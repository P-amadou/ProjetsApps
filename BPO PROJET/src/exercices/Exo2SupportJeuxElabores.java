package exercices; // A ne pas changer

//------------------------------------------------------
// Saurez vous adapter un nouveau jeu plus évolué et lancer une partie de chacun de ce jeu ?
//------------------------------------------------------
// Le paquetage jeux.elabores contient une collection de jeux (sous la forme d'une méthode statique main au sein 
// d'une classe AppliXXX). Aucun de ces jeux n'est vraiment élaboré mais chacun correspond à un des pièges possibles du sujet :
//
// - Prise en compte des matchs nuls (ss-paquetage egalite)
// - Prise en compte des exceptions levées par les jeux (ss-paquetage errones)
// - Support des applications qui héritent d'une classe et/ou implantent une interface (ss-paquetage heritage)
// - Support des applications qui emploient des variables globales... (paquetage memoire)
// - Support des applications exploitant le paramètre (String[] args) de la méthode main (ss-paquetage  parametre)
//
// A chaque AppliXXX correspond un exercice exoXXX ci dessous. Il est inutile de tous les faire car beaucoup
// sont similaires.
//
// Pour chaque exercice, après avoir rendu compatible la classe AppliXXX, écrivez les instructions qui :
// a - construisent le jeu j correspondant à AppliXXX
// b - lancent une partie de ce jeu
// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)
//------------------------------------------------------

// Ne pas changer le nom de la classe ni le prototype des méthodes.
public class Exo2SupportJeuxElabores { 

	public static void main(String[] args) {
		// A adapter à vos besoins en (dé)commentant les lignes
		
//		System.out.println("--> exoBugge");  exoBugge();
//		System.out.println("--> exoMalConfigure");  exoMalConfigure();
		
//		System.out.println("--> exoHeritage");  exoHeritage();
//		System.out.println("--> exoInterface");  exoInterface();
//		System.out.println("--> AppliInterfaceEtHeritage");  AppliInterfaceEtHeritage();
		
//		System.out.println("--> exoAvecDonneeStatique");  exoAvecDonneeStatique();
		
//		System.out.println("--> exoGagneOuPerd(gagne)");  exoGagneOuPerd(new String[]{"gagne"});
//		System.out.println("--> exoGagneOuPerd(perd)");  exoGagneOuPerd(new String[]{"perd"});
	}

	
	public static Boolean exoMatchNul() {
		// AppliMatchNull

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoBugge() {
		// AppliBugge

		return null;
	}
	
	public static Boolean exoMalConfigure() {
		// AppliMalConfigure

		return null;
	}
	
	//------------------------------------------------------
	public static Boolean exoHeritage() {
		// AppliHeritage

		return null;
	}
	
	public static Boolean exoInterface() {
		// AppliInterface

		return null;
	}
	
	public static Boolean exoInterfaceEtHeritage() {
		// AppliInterfaceEtHeritage

		return null;
	}
	
	//------------------------------------------------------
	public static Boolean exoAvecDonneeStatique() {
		// AppliAvecDonneeStatique
		// Attention, cette application emploie un attribut statique. Si on lance deux fois de suite ce programme,
		// il affiche deux fois la même chose. Faites en sorte que ceci soit préservé lors de l'adaptation du jeu à
		// votre bibilothèque
		//
		// Ecrivez les instructions qui :
		// a - construisent le jeu j correspondant à AppliAvecDonneeStatique
		// b - lancent deux parties successives de ce jeu
		// c - retournent le résultat de la seconde partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoGagneOuPerd(String[] args) {
		// AppliGagneOuPerd
		// Attention, cette application utilise le paramètre (String[] args). Vous devez lui transmettre.

		return null;
	}
}
