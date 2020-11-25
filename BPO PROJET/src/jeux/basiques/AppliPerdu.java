package jeux.basiques;

import commun.Resultat;

public class AppliPerdu {
	private static Resultat nePasModifierCetteMéthode() {
		return Resultat.PERDU;
	}
		
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
