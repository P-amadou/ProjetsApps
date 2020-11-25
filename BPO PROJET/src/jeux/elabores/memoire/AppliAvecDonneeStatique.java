package jeux.elabores.memoire;

import commun.Resultat;

public class AppliAvecDonneeStatique {
	private static Resultat nePasModifierCetteMéthode() {
		return Resultat.GAGNE;
	}

	// ne pas changer cet attribut de classe
	private static boolean fail = false;
	
	public static void main(String[] args) {
		// ne pas changer les instructions qui suivent
		if (fail)
			System.out.println("not good)");
		fail = true;
		Resultat r = nePasModifierCetteMéthode();
		System.out.println(r);
		// jusque là.
	}
}
