package exercices; // A ne pas changer

//------------------------------------------------------
// Saurez vous adapter les nouveaux jeux élémentaires fournis pour la soutenance pour les rendre 
// compatibles avec votre bibliothèque et pourrez vous lancer une partie de chacun de ces jeux 
// après qu'ils aient été modifiés ?
//------------------------------------------------------
// Les nouveaux jeux sont dans le paquetage jeux.basiques. Ils sont tous sous la forme d'une classe nommée 
// AppliXXX contenant un main. Vous pouvez commencer par l'exécuter pour comprendre son fonctionnement.
//
// Vous noterez que les jeux reposent sur le type énuméré jeu.util.Resultat qui ne doit pas être modifié.  
// Les instructions composant la méthode main ne doivent pas être modifiées mais elles peuvent être 
// complétées. Les autres méthodes, les attributs et tous les autres éléments définis au sein de la classe 
// ne doivent pas être modifiés ainsi que toutes les autres classes ou interfaces dont le jeu dépend. 
// Vous ne devez changer ni le nom de la classe ni la changer de paquetage.
//
// En cas de doute, demandez à votre chargé de tp. 
//
// A chaque méthode exoX correspond un test du paquetage soutenance.tests. Le test consiste à vérifier 
// que les affichages sont conformes. 
// Après avoir fini un exercice, vous pouvez exécuter les tests pour vérifier que votre travail est correct.
// 
// Vous pouvez aussi exécuter la méthode main ci-dessous. Elle invoque en séquence chaque méthode exoX.
// Vous verrez ainsi les affichages et saisies qui sont réalisés.
//------------------------------------------------------

// Ne pas changer le nom de la classe ni le prototype des méthodes.
public class Exo1JeuxBasiques { 

	public static void main(String[] args) {
		// A adapter à vos besoins en (dé)commentant les lignes
		
//		System.out.println("--> exoPileOuFace");  exoPileOuFace();
		
//		System.out.println("--> exoJoueur(true)");  exoJoueur(true);
//		System.out.println("--> exoJoueur(false)");  exoJoueur(false);

//		System.out.println("--> exoMatchNul");  exoMatchNul();
	}

	public static Boolean exoPileOuFace() {
		// Pour pouvoir faire cet exercice, vous devez avoir modifié la classe AppliPileOuFace 
		// pour la rendre compatible avec votre bibliothèque.
		//
		// Ecrivez les instructions qui :
		// a - construisent le jeu j correspondant à AppliPileOuFace
		// b - lancent une partie de ce jeu
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)
		// 
		// Le test associé à chaque exercice vérifie que les affichages sont exactement ceux attendus 
		// et/ou que la valeur retournée est correcte.
		//
		// Votre méthode doit retourner le résultat de la partie. 3 valeurs sont possibles :
		// - true : la partie est gagnée
		// - false : la partie est perdue
		// - null : les tests n'iront pas plus loin (retournée par défaut)
		//
		// Les affichages réalisés par vos instructions doivent être exactement les mêmes que ceux 
		// réalisés par l'appel AppliPileOuFace.main(null) de la méthode main originale

		return null;
	}
	
	public static Boolean exoJoueur(boolean b) {
		// Pour pouvoir faire cet exercice, vous devez avoir modifié les classes AppliGagne et 
		// AppliPerdu pour les rendre compatibles avec votre bibliothèque.
		//
		// Ecrivez les instructions qui :
		// a - construisent le jeu j tel que si b est vrai alors j = AppliGagne sinon j = AppliPerdu
		// b - lancent une partie de ce jeu
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
}
