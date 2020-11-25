package tests;

import java.util.Arrays;
import java.util.List;

import org.junit.Test;

import exercices.Exo4CompositionsElaborees;
import tests.utils.TestWithOutputCapture;

public class Test4CompositionsElaborees extends TestWithOutputCapture {
	@Test
	public void testPuisSinon() {
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b2 : bool)
			for (Boolean b3 : bool) {
				checkVictory(Exo4CompositionsElaborees.exoPuisSinon(true, b2, b3));
				checkOutput("gagné");
			}
		checkVictory(Exo4CompositionsElaborees.exoPuisSinon(false, true, true));
		checkOutput("dommage", "gagné");
		checkVictory(Exo4CompositionsElaborees.exoPuisSinon(false, true, false));
		checkOutput("dommage", "gagné");
		checkVictory(Exo4CompositionsElaborees.exoPuisSinon(false, false, true));
		checkOutput("dommage", "dommage", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoPuisSinon(false, false, false));
		checkOutput("dommage", "dommage", "dommage");
	}

	@Test
	public void testPuisSinonVariante() {
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b2 : bool)
			for (Boolean b3 : bool) {
				checkVictory(Exo4CompositionsElaborees.exoPuisSinonVariante(true, b2, b3));
				checkOutput("gagné");
			}
		checkVictory(Exo4CompositionsElaborees.exoPuisSinonVariante(false, true, true));
		checkOutput("dommage", "gagné");
		checkVictory(Exo4CompositionsElaborees.exoPuisSinonVariante(false, true, false));
		checkOutput("dommage", "gagné");
		checkVictory(Exo4CompositionsElaborees.exoPuisSinonVariante(false, false, true));
		checkOutput("dommage", "dommage", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoPuisSinonVariante(false, false, false));
		checkOutput("dommage", "dommage", "dommage");
	}

	@Test
	public void testEtAussi() {
		checkVictory(Exo4CompositionsElaborees.exoEtAussi(true, true, true));
		checkOutput("gagné", "gagné", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoEtAussi(true, false, true));
		checkOutput("gagné", "dommage");
		checkDefeat(Exo4CompositionsElaborees.exoEtAussi(true, true, false));
		checkOutput("gagné", "gagné", "dommage");
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b2 : bool)
			for (Boolean b3 : bool) {
				checkDefeat(Exo4CompositionsElaborees.exoEtAussi(false, b2, b3));
				checkOutput("dommage");
			}
	}

	@Test
	public void testEtAussiVariante() {
		checkVictory(Exo4CompositionsElaborees.exoEtAussiVariante(true, true, true));
		checkOutput("gagné", "gagné", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoEtAussiVariante(true, false, true));
		checkOutput("gagné", "dommage");
		checkDefeat(Exo4CompositionsElaborees.exoEtAussiVariante(true, true, false));
		checkOutput("gagné", "gagné", "dommage");
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b2 : bool)
			for (Boolean b3 : bool) {
				checkDefeat(Exo4CompositionsElaborees.exoEtAussiVariante(false, b2, b3));
				checkOutput("dommage");
			}
			
	}

	@Test
	public void testEnAuPlusPuisSinon() {
		for (int i = 1; i < 3; ++i) {
			checkVictory(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(true, i, true));
			checkOutput("gagné");
			checkVictory(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(true, i, false));
			checkOutput("gagné");
			checkVictory(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(false, i, true));
			checkDefeat(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(false, i, false));
			getOut();
		}
		checkVictory(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(false, 3, true));
		checkOutput("dommage", "dommage", "dommage", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoEnAuPlusPuisSinon(false, 3, false));
		checkOutput("dommage", "dommage", "dommage", "dommage");
	}

	@Test
	public void testPuisSinonAvecGagneOuPerd() {
		List<Boolean> bool = Arrays.asList(Boolean.TRUE, Boolean.FALSE);
		for (Boolean b : bool) {
			checkVictory(Exo4CompositionsElaborees.exoPuisSinonAvecGagneOuPerd(true, b));
			checkOutput("gagné");
		}
		checkVictory(Exo4CompositionsElaborees.exoPuisSinonAvecGagneOuPerd(false, true));
		checkOutput("dommage", "gagné");
		checkDefeat(Exo4CompositionsElaborees.exoPuisSinonAvecGagneOuPerd(false, false));
		checkOutput("dommage", "dommage");
	}
}
