package jeux.basiques;

import commun.Resultat;

public class AppliPileOuFace {
	private static Resultat nePasModifierCetteMéthode() {
		if (Math.random() > 0.5)
			return Resultat.GAGNE;
		else
			return Resultat.PERDU;
	}

	public static void main(String[] args) {
		// Ne pas modifier ni l'appel, ni l'affichage
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
	}
}
