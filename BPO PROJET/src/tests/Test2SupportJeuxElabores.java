package tests;

import org.junit.Test;

import exercices.Exo2SupportJeuxElabores;
import tests.utils.TestWithOutputCapture;

public class Test2SupportJeuxElabores extends TestWithOutputCapture {
	@Test
	public void testMatchNul() {
		checkDefeat(Exo2SupportJeuxElabores.exoMatchNul());
		checkOutput("Match nul");
	}

	//------------------------------------------------------
	@Test
	public void testBugge() {
		checkVictory(Exo2SupportJeuxElabores.exoBugge());
		checkOutput("Faute de programmation");
	}

	@Test
	public void testMalConfigure() {
		checkVictory(Exo2SupportJeuxElabores.exoMalConfigure());
		checkOutput("Faute contextuelle");
	}

	//------------------------------------------------------
	@Test
	public void testHeritage() {
		checkVictory(Exo2SupportJeuxElabores.exoHeritage());
		checkOutput("pur héritier", "gagné");
	}

	@Test
	public void testInterface() {
		checkVictory(Exo2SupportJeuxElabores.exoInterface());
		checkOutput("implémentation par défaut", "gagné");
	}

	@Test
	public void testInterfaceEtHeritage() {
		checkVictory(Exo2SupportJeuxElabores.exoInterfaceEtHeritage());
		checkOutput("héritier", "gagné");
	}

	//------------------------------------------------------
	@Test
	public void testAvecDonneeStatique() {
		checkVictory(Exo2SupportJeuxElabores.exoAvecDonneeStatique());
		checkOutput("gagné", "gagné");
	}

	//------------------------------------------------------
	@Test
	public void testGagneOuPerd() {
		checkVictory(Exo2SupportJeuxElabores.exoGagneOuPerd(new String[]{"gagne"}));
		checkOutput("gagné");
		checkDefeat(Exo2SupportJeuxElabores.exoGagneOuPerd(new String[]{"perd"}));
		checkOutput("dommage");
	}
}
