package jeux.elabores.egalite;

import commun.Resultat;

public class AppliMatchNul {
	private static Resultat nePasModifierCetteMéthode() {
		return Resultat.MATCH_NULL;
	}
	
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
