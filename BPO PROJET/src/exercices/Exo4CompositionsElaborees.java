package exercices; // A ne pas changer

//------------------------------------------------------
// Saurez vous réaliser des assemblages plus complexes puis en lancer une partie ? 
//------------------------------------------------------
// Avant de pouvoir faire ces exercices, vous devez avoir réussi l'exercice Exo1JeuxBasiques.exoJoueur
// et, plus particulièrement, avoir rendu compatible avec votre bibliothèque AppliGagne et AppliPerdu.
//
// Le dernier exercice nécessite que vous ayez aussi rendu compatible l'application paramétrée AppliGagneOuPerd.
//------------------------------------------------------

// avec correction
// Ne pas changer le nom de la classe ni le prototype des méthodes.
public class Exo4CompositionsElaborees { 

	public static void main(String[] args) {
		// A adapter à vos besoins en (dé)commentant les lignes
		
//		System.out.println("--> exoPuisSinon(true, true, true)");  exoPuisSinon(true, true, true);
//		System.out.println("--> exoPuisSinonVariante(true, true, true)");  exoPuisSinonVariante(true, true, true);
//		System.out.println("--> exoEtAussi(true, true, true)");  exoEtAussi(true, true, true);
//		System.out.println("--> exoEtAussiVariante(true, true, true)");  exoEtAussiVariante(true, true, true);
//		System.out.println("--> exoEnAuPlusPuisSinon(false, 2, true)");  exoEnAuPlusPuisSinon(false, 2, true);
//		System.out.println("--> exoGagneOuPerdPuisSinon(false, true)");  exoGagneOuPerdPuisSinon(false, true);
	}

	public static Boolean exoPuisSinon(boolean b1, boolean b2, boolean b3) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu j3 tel que si b3 est vrai alors j3 = AppliGagne sinon j3 = AppliPerdu
		// d - construisent le jeu correspondant à l'assemblage j1 "puis sinon" (j2 "puis sinon" j3)
		// e - lancent une partie du jeu résultant de l'assemblage
		// f - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	public static Boolean exoPuisSinonVariante(boolean b1, boolean b2, boolean b3) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu j3 tel que si b3 est vrai alors j3 = AppliGagne sinon j3 = AppliPerdu
		// d - construisent le jeu correspondant à l'assemblage (j1 "puis sinon" j2) "puis sinon" j3
		// e - lancent une partie du jeu résultant de l'assemblage
		// f - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoEtAussi(boolean b1, boolean b2, boolean b3) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu j3 tel que si b3 est vrai alors j3 = AppliGagne sinon j3 = AppliPerdu
		// d - construisent le jeu correspondant à l'assemblage j1 "et aussi" (j2 "puis sinon" j3)
		// e - lancent une partie du jeu résultant de l'assemblage
		// f - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	public static Boolean exoEtAussiVariante(boolean b1, boolean b2, boolean b3) {
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu j3 tel que si b3 est vrai alors j3 = AppliGagne sinon j3 = AppliPerdu
		// d - construisent le jeu correspondant à l'assemblage (j1 "et aussi" j2) "puis sinon" j3
		// e - lancent une partie du jeu résultant de l'assemblage
		// f - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static Boolean exoEnAuPlusPuisSinon(boolean b1, int n, boolean b2) {
		assert(n > 0);
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 tel que si b1 est vrai alors j1 = AppliGagne sinon j1 = AppliPerdu
		// b - construisent le jeu j2 tel que si b2 est vrai alors j2 = AppliGagne sinon j2 = AppliPerdu
		// c - construisent le jeu correspondant à l'assemblage (j1 "en au plus" n) "puis sinon" j2
		// d - lancent une partie du jeu résultant de l'assemblage
		// e - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}

	//------------------------------------------------------
	public static String[] getArgs(boolean b) {
		return b ? new String[] {"gagne"} : new String[] {"perd"};
	}
	
	public static Boolean exoPuisSinonAvecGagneOuPerd(boolean b1, boolean b2) {
		// Le jeu AppliGagneOuPerd utilise le paramètre (String[] args) du main.
		// On note AppliGagneOuPerd(args), le jeu AppliGagneOuPerd lancé avec le tableau args.
		// On dispose de la méthode getArgs ci-dessus.
		// Ecrivez les instructions qui :
		// a - construisent le jeu j1 = AppliGagneOuPerd(getArgs(b1))
		// b - construisent le jeu j2 = AppliGagneOuPerd(getArgs(b2))
		// c - construisent le jeu correspondant à l'assemblage j1 "puis sinon" j2
		// d - lancent une partie du jeu résultant de l'assemblage
		// e - retournent le résultat de cette partie (true si elle est gagnée et false sinon)

		return null;
	}
}
