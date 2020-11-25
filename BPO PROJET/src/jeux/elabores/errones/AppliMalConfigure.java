package jeux.elabores.errones;

import java.io.FileNotFoundException;

import commun.Resultat;

public class AppliMalConfigure {
	private static Resultat nePasModifierCetteMéthode() throws Exception {
		System.out.println("Faute contextuelle");
		throw new FileNotFoundException();
	}
	
	public static void main(String[] args) throws Exception {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
