package tests;

import java.util.Arrays;
import java.util.List;

import org.junit.Test;

import exercices.Exo5NouveauxModesDeComposition;
import tests.utils.TestWithOutputCapture;

public class Test5NouveauxModesDeCompositions extends TestWithOutputCapture {
	@Test
	public void testDeuxDeSuiteEnMoinsDe() {
		checkDefeat(Exo5NouveauxModesDeComposition.exoDeuxDeSuiteEnMoinsDe(false, 4));
		checkOutput("dommage", "dommage", "dommage");
		for (int i = 2; i < 5; ++i) {
			checkVictory(Exo5NouveauxModesDeComposition.exoDeuxDeSuiteEnMoinsDe(true, i));
			checkOutput("gagné", "gagné");
		}
	}

	@Test
	public void testUnParmi() {
		checkVictory(Exo5NouveauxModesDeComposition.exoUnParmi());
		checkOutput("dommage", "dommage", "gagné");
	}

	@Test
	public void testEnAlternance() {
		checkVictory(Exo5NouveauxModesDeComposition.exoEnAlternance());
		checkOutput("dommage", "gagné", "dommage", "gagné");
	}

	@Test
	public void testSiAlorsSinon() {
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b : bool) {
			checkDefeat(Exo5NouveauxModesDeComposition.exoSiAlorsSinon(false, b, false));
			checkOutput("dommage", "dommage");
			checkDefeat(Exo5NouveauxModesDeComposition.exoSiAlorsSinon(true, false, b));
			checkOutput("gagné", "dommage");
			checkVictory(Exo5NouveauxModesDeComposition.exoSiAlorsSinon(true, true, b));
			checkOutput("gagné", "gagné");
			checkVictory(Exo5NouveauxModesDeComposition.exoSiAlorsSinon(false, b, true));
			checkOutput("dommage", "gagné");
		}
	}

	@Test
	public void testQuiPerdGagne() {
		checkVictory(Exo5NouveauxModesDeComposition.exoQuiPerdGagne(false));
		checkOutput("dommage");
		checkDefeat(Exo5NouveauxModesDeComposition.exoQuiPerdGagne(true));
		checkOutput("gagné");
	}

	@Test
	public void testJusquAPerfection() {
		checkVictory(Exo5NouveauxModesDeComposition.exoJusquAPerfection());
		checkOutput("gagné", "gagné", "gagné");
	}

	@Test
	public void testMoitie() {
		checkVictory(Exo5NouveauxModesDeComposition.exoMoitie());
		checkOutput("gagné", "dommage", "gagné");
	}
}
