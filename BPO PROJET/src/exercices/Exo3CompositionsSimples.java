package exercices; // A ne pas changer

//------------------------------------------------------
// Saurez vous lancer une partie d'un jeu obtenu par composition ? 
//------------------------------------------------------
// Avant de pouvoir faire ces exercices, vous devez avoir réussi l'exercice Exo1JeuxBasiques.exoJoueur
// et, plus particulièrement, avoir rendu compatible avec votre bibliothèque AppliGagne et AppliPerdu.
//
// Assurez vous aussi que composer des jeux avec votre bibliothèque n'implique aucun autre affichage 
// que ceux des jeux composés.
//
// Par la suite, les 4 compositions du projet sont notées (dans le même ordre que dans le sujet) :
// - j1 "puis sinon" j2 (avec j1 et j2 deux jeux)
// - j1 "et aussi" j2
// - j "en au plus" n (avec j un jeu et n > 0 le nombre d'essais)
// - j "jusqu'à la victoire"
//------------------------------------------------------

// Ne pas changer le nom de la classe ni le prototype des méthodes.
public class Exo3CompositionsSimples { 

	public static void main(String[] args) {
		// A adapter à vos besoins en (dé)commentant les lignes

//		System.out.println("--> exoPuisSinon(true, true)");  exoPuisSinon(true, true);

//		System.out.println("--> exoEtAussi(true, true)");  exoEtAussi(true, true);

//		System.out.println("--> exoEnAuPlus(true, 3)");  exoEnAuPlus(true, 3);

//		System.out.println("--> exoJusquaLaVictoire()");  exoJusquaLaVictoire();
	}

	public static Boolean exoPuisSinon(boolean b1, boolean b2) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu correspondant à l'assemblage j1 "puis sinon" j2
		// d - lancent une partie du jeu résultant de l'assemblage
		// e - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoEtAussi(boolean b1, boolean b2) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu correspondant à l'assemblage j1 "et aussi" j2
		// d - lancent une partie du jeu résultant de l'assemblage
		// e - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoEnAuPlus(boolean b, int n) {
		assert(n > 0);
		// Ecrivez les instructions qui :
		// a - construisent le jeu j tel que si b est vrai alors j = AppliGagne sinon j = AppliPerdu
		// b - construisent le jeu correspondant à l'assemblage j "en au plus" n (où n > 0 est le nombre d'essais)
		// c - lancent une partie du jeu résultant de l'assemblage
		// d - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
	
	//------------------------------------------------------
	public static Boolean exoJusquaLaVictoire() {
		// Ecrivez les instructions qui :
		// a - construisent le jeu correspondant à l'assemblage AppliGagne "jusqu'à la victoire"
		// b - lancent une partie du jeu résultant de l'assemblage
		// c - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
}
