package jeux.basiques;

import commun.Resultat;

public class AppliGagne {
	private static Resultat nePasModifierCetteM�thode() {
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
