package jeux.elabores.errones;

import commun.Resultat;

public class AppliBugge {
	private static Resultat nePasModifierCetteM�thode() {
		System.out.println("Faute de programmation");
		throw new NumberFormatException();
	}
	
	public static void main(String[] args) {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
