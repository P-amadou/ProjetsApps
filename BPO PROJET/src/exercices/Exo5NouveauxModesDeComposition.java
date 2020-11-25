package exercices; // A ne pas changer

//------------------------------------------------------
// Saurez vous programmer hors de votre bibliothèque un nouveau mode de composition et vous en servir  ?
//------------------------------------------------------
// Pour chaque exercice qui suit, vous devez metre en oeuvre un nouveau mode d'assemblage de jeux.
// Si elle est bien conçue, votre bibliothèque doit permettre de développer une nouvelle classe/méthode/etc 
// permettant de construire un nouveau jeu employant ce nouveau mode d'assemblage.
//
// Si ce n'est pas le cas, il est toujours possible de faire les exercices qui suivent en modifiant le coeur 
// de votre bibliothèque pour y intégrer ces nouveaux modes d'assemblage. Notez bien que ce n'est pas du tout 
// le but de l'exercice.
//
// Chaque exercice consiste à construire un jeu assemblé selon un nouveau mode (défini dans un encadré avant
// l'exercice) puis à lancer une partie de ce jeu et retourner le résultat de celle-ci. La construction du jeu peut
// être conditionnée par des paramètres propres à chaque exercice. 
//
// Certains sont plus difficiles que d'autres. Certains peuvent être obtenus simplement en combinant des modes déjà existants.
//------------------------------------------------------

// avec correction
// Ne pas changer le nom de la classe ni le prototype des méthodes.
public class Exo5NouveauxModesDeComposition { 

	public static void main(String[] args) {
		// A adapter à vos besoins en (dé)commentant les lignes
		
//		System.out.println("--> exo1");  exo1();
	}

	//------------------------------------------------------
	// Soit j un jeu et n > 1 un entier. Le joueur dispose de n essais pour jouer au jeu j et remporter 2 victoires 
	// successives. Avec ce mode, la partie s'arrète au plus tôt, c'est à dire :
	// - dès que 2 victoires successives ont eu lieu
	// - dès que le joueur ne peut plus gagner (la nième partie ne doit pas être jouée si la n-1 ième n'a pas été une victoire)
	//
	// Notation : j "2 en au plus" n 
	//------------------------------------------------------
	public static Boolean exoDeuxDeSuiteEnMoinsDe(boolean b, int nbEssais) {
		assert(nbEssais > 1);
		// Ecrivez les instructions qui :
		// a - construisent le jeu j tel que si b est vrai alors j = AppliGagne sinon j = AppliPerdu
		// b - construisent le jeu correspondant à l'assemblage j "2 en au plus" n (où n > 1 est le nombre d'essais)
		// c - lancent une partie du jeu résultant de l'assemblage
		// d - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	//------------------------------------------------------
	// Soient j1, j2, ..., jn, une liste non vide de jeux. Le joueur joue à une partie de chaque jeu pris dans l'ordre 
	// j1, ..., jn. La partie est gagnée (et s'arrète immédiatement) dès que le joueur remporte l'un des jeux. Elle
	// est perdue s'il ne remporte aucune vicoire.
	//
	// Notation : "un parmi" (j1, ..., jn)
	//------------------------------------------------------
	public static Boolean exoUnParmi() {
		// Ecrivez les instructions qui :
		// a - construisent le jeu correspondant à l'assemblage "un parmi" (AppliPerdu, AppliPerdu, AppliGagne, AppliPerdu).
		// b - lancent une partie du jeu résultant de l'assemblage
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	//------------------------------------------------------
	// Soient j1, j2, ..., jn, une liste non vide de jeux. Le joueur joue à une partie de chaque jeu pris dans l'ordre 
	// j1, ..., jn. La partie est gagnée si le joueur fait une alternance de succès et d'échec à la série de jeux.
	// La partie se termine en échec dès que le joueur obtient 2 victoires ou échecs consécutifs. Attention,
	// le joueur doit pouvoir choisir de commencer par perdre ou par gagner le premier jeu, ce n'est que 
	// pour les jeux suivants que l'alternance devient stricte.
	//
	// Notation : "alterne" (j1, ..., jn)
	//------------------------------------------------------
	public static Boolean exoEnAlternance() {
		// Ecrivez les instructions qui :
		// a - construisent le jeu correspondant à l'assemblage "alterne" (AppliPerdu, AppliGagne, AppliPerdu, AppliGagne).
		// b - lancent une partie du jeu résultant de l'assemblage
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	// Soient j1, j2, j3, 3 jeux. Le joueur joue un jeu de j1. S'il gagne j1 alors il doit gagner au jeu j2 pour remporter 
	// la partie. S'il perd j1 alors il doit gagner un jeu de j3 pour obtenir une victoire. Dans tous les autres cas, il perd.
	//
	// Notation : "si alors sinon" (j1, j2, j3)
	//------------------------------------------------------
	public static Boolean exoSiAlorsSinon(boolean b1, boolean b2, boolean b3) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu j3 tel que si b3 est vrai alors j3 = AppliGagne sinon j3 = AppliPerdu
		// d - construisent le jeu correspondant à l'assemblage "si alors sinon" (j1, j2, j3)
		// e - lancent une partie du jeu résultant de l'assemblage
		// f - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	//------------------------------------------------------
	// Soit j, un jeu. Le joueur joue au jeu j. La partie est remportée s'il perd au jeu j et elle est perdue s'il gagne j. 
	//
	// Notation : "qui perd gagne" (j) 
	//------------------------------------------------------
	public static Boolean exoQuiPerdGagne(boolean b) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j tel que si b est vrai alors j = AppliGagne sinon j = AppliPerdu
		// b - construisent le jeu correspondant à l'assemblage "qui perd gagne" (j)
		// c - lancent une partie du jeu résultant de l'assemblage
		// d - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	// une série de jeux à gagner un à un qui est recommencée au début dès le 1er échec
	
	//------------------------------------------------------
	// Soient j1, j2, ..., jn, une liste non vide de jeux. Le joueur doit gagner tous les jeux un à un sans jamais perdre. 
	// Dès qu'il perd l'un des jeux, il recommence à partir du premier. La partie se termine nécessairement par un succès 
	// quand le joueur réalise la séquence parfaite.
	// 
	// Notation : "jusqu'à perfection" (j1, ..., jn)
	//------------------------------------------------------
	public static Boolean exoJusquAPerfection() {
		// Ecrivez les instructions qui :
		// a - construisent le jeu correspondant à l'assemblage "jusqu'à perfection" (AppliGagne, AppliGagne, AppliGagne)
		// b - lancent une partie du jeu résultant de l'assemblage
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	//------------------------------------------------------
	// Soient j1, j2, ..., jn, une liste non vide de jeux. Le joueur joue à chaque jeu un à un. Pour gagner la partie, 
	// le joueur doit remporter au moins la moitié des jeux. Il joue à tous les jeux et cela même s'il a déjà suffisamment 
	// de victoires ou trop d'échecs. 
	//
	// Notation : "moitié" (j1, ..., jn)
	//------------------------------------------------------

	public static Boolean exoMoitie() {
		// Ecrivez les instructions qui :
		// a - construisent le jeu correspondant à l'assemblage "moitie" (AppliGagne, AppliPerdu, AppliGagne)
		// b - lancent une partie du jeu résultant de l'assemblage
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
}
