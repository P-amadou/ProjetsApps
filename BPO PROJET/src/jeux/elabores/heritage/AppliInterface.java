package jeux.elabores.heritage;

import commun.Resultat;
import jeuxT.elabores.heritage.InterfaceTemoin;

public class AppliInterface implements InterfaceTemoin {
	// Ne pas changer le prototype de ce constructeur
	// Compl�ter les instructions reste possible
	public AppliInterface() {
		super();
	}
	
	private static Resultat nePasModifierCetteM�thode() {
		AppliInterface j = new AppliInterface();
		j.heritage();
		return Resultat.GAGNE;
	}

	public static void main(String[] args) {
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
