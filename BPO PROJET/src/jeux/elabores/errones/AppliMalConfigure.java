package jeux.elabores.errones;

import java.io.FileNotFoundException;

import commun.Resultat;

public class AppliMalConfigure {
	private static Resultat nePasModifierCetteM�thode() throws Exception {
		System.out.println("Faute contextuelle");
		throw new FileNotFoundException();
	}
	
	public static void main(String[] args) throws Exception {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
