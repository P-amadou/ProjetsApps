package jeux.basiques;

import commun.Resultat;

public class AppliPerdu {
	private static Resultat nePasModifierCetteM�thode() {
		return Resultat.PERDU;
	}
		
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
