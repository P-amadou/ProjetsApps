package jeux.elabores.egalite;

import commun.Resultat;

public class AppliMatchNul {
	private static Resultat nePasModifierCetteM�thode() {
		return Resultat.MATCH_NULL;
	}
	
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
