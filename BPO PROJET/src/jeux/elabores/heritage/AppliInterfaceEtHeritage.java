package jeux.elabores.heritage;

import commun.Resultat;
import jeuxT.elabores.heritage.InterfaceTemoin;

public class AppliInterfaceEtHeritage extends ClasseTemoin implements InterfaceTemoin {
	// Ne pas changer le prototype de ce constructeur
	// Compléter les instructions reste possible
	public AppliInterfaceEtHeritage() {
		super();
	}
	
	private static Resultat nePasModifierCetteMéthode() {
		AppliInterfaceEtHeritage j = new AppliInterfaceEtHeritage();
		j.heritage();
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
