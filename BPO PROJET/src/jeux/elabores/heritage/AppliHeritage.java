package jeux.elabores.heritage;

import commun.Resultat;
import jeux.elabores.heritage.ClasseTemoin;

public class AppliHeritage extends ClasseTemoin {
	// Ne pas changer le prototype de ce constructeur
	// Compléter les instructions reste possible
	public AppliHeritage() {
		super();
	}
	
	private static Resultat nePasModifierCetteMéthode() {
		AppliHeritage j = new AppliHeritage();
		j.heritage();
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
