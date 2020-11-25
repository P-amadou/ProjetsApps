package jeux.elabores.errones;

import commun.Resultat;

public class AppliBugge {
	private static Resultat nePasModifierCetteMéthode() {
		System.out.println("Faute de programmation");
		throw new NumberFormatException();
	}
	
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
