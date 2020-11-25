package jeux.elabores.parametres;


import commun.Resultat;

public class AppliGagneOuPerd {
	private static Resultat nePasModifierCetteMéthode(String[] args) {
		if (args == null || !args[0].contains("gagne"))
			return Resultat.PERDU;
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode(args);
		System.out.println(r);
	}
}
