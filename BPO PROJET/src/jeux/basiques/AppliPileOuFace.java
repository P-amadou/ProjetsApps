package jeux.basiques;

import commun.Resultat;

public class AppliPileOuFace {
	private static Resultat nePasModifierCetteM�thode() {
		if (Math.random() > 0.5)
			return Resultat.GAGNE;
		else
			return Resultat.PERDU;
	}

	public static void main(String[] args) {
		// Ne pas modifier ni l'appel, ni l'affichage
		Resultat r = nePasModifierCetteM�thode();
		System.out.println(r);
	}
}
