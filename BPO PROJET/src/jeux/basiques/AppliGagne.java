package jeux.basiques;

import commun.Resultat;

public class AppliGagne {
	private static Resultat nePasModifierCetteMéthode() {
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
