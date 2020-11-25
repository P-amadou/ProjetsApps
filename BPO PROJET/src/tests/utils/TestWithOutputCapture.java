package tests.utils;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertNotNull;
import static org.junit.Assert.assertTrue;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import org.junit.After;
import org.junit.Before;

public class TestWithOutputCapture {
	private PrintStream old;
	private ByteArrayOutputStream out;
	
	@Before 
	public void atBefore() {
		old = System.out;
		out = new ByteArrayOutputStream();
		System.setOut(new PrintStream(out));
	}
	
	public String getOut() {
		System.out.flush();
		String s = out.toString();
		out.reset();
		return s;
	}
	
	public void checkOutput(String ... expected) {
		assertEquals("L'affichage produit n'est pas celui attendu", TestWithOutputCapture.concatLignes(expected), getOut());
	}
	
	@After
	public void atAfter() {
		System.setOut(old);
		out = null;
	}

	public void checkDefeat(Boolean res) {
		assertNotNull("La méthode doit retourner une valeur", res);
		assertFalse("La partie n'a pas été gagnée mais perdue", res);
	}

	public void checkVictory(Boolean res) {
		assertNotNull("La méthode doit retourner une valeur", res);
		assertTrue("La partie n'a pas été perdue mais gagnée", res);
	}

	public static String concatLignes(String ... lignes) {
		String s = "";
		for (String ligne : lignes)
			s += ligne + System.lineSeparator();
		return s;
	}

	public static void setSystemIn(String s) {
	    ByteArrayInputStream b = new ByteArrayInputStream(s.getBytes());
	    System.setIn(b);
	}	
}