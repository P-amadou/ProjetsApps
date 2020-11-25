package tests;

import static org.junit.Assert.*;

import java.io.FileNotFoundException;
import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.Arrays;

import org.junit.Test;

import commun.Resultat;
import jeux.basiques.*;
import jeux.elabores.egalite.AppliMatchNul;
import jeux.elabores.errones.*;
import jeux.elabores.heritage.*;
import jeux.elabores.parametres.*;
import jeuxT.elabores.heritage.InterfaceTemoin;
import tests.utils.TestWithOutputCapture;

public class TestIntegrite extends TestWithOutputCapture {
	public <T> Resultat invokePrivateMethod(Class<T> game)
			throws NoSuchMethodException, IllegalAccessException, InvocationTargetException {
		Method m = game.getDeclaredMethod("nePasModifierCetteMéthode");
		// check prototype
		String proto = "private static commun.Resultat " + game.getName() + ".nePasModifierCetteMéthode()";
		assertTrue(m.toGenericString().startsWith(proto));
		// invoke
		m.setAccessible(true);
		Resultat r = (Resultat) m.invoke(null);
		return r;
	}

	@Test
	public void testPileOuFace() throws Exception {
		Resultat r = invokePrivateMethod(AppliPileOuFace.class);
		assertTrue(Resultat.GAGNE == r || Resultat.PERDU == r);
		assertEquals("", getOut());
	}

	@Test
	public void testGagne() throws Exception {
		assertEquals(Resultat.GAGNE, invokePrivateMethod(AppliGagne.class));
		assertEquals("", getOut());
	}

	@Test
	public void testPerdu() throws Exception {
		assertEquals(Resultat.PERDU, invokePrivateMethod(AppliPerdu.class));
		assertEquals("", getOut());
	}

	@Test
	public void testMatchNul() throws Exception {
		assertEquals(Resultat.MATCH_NULL, invokePrivateMethod(AppliMatchNul.class));
		assertEquals("", getOut());
	}
	
	//------------------------------------------------------
	@Test
	public void testBugge() throws Exception {
		try {
			invokePrivateMethod(AppliBugge.class);
		} catch (InvocationTargetException e) {
			// check that thrown exception is the expected one
			assertEquals(NumberFormatException.class, e.getTargetException().getClass());
		}
		checkOutput("Faute de programmation");
	}

	@Test
	public void testMalConfigure() throws Exception {
		try {
			invokePrivateMethod(AppliMalConfigure.class);
		} catch (InvocationTargetException e) {
			// check expected exception
			assertEquals(FileNotFoundException.class, e.getTargetException().getClass());
		}
		checkOutput("Faute contextuelle");
	}

	//------------------------------------------------------
	@Test
	public void testHeritage() throws Exception {
		// check inheritance
		assertEquals(ClasseTemoin.class, AppliHeritage.class.getSuperclass());
		assertEquals(Resultat.GAGNE, invokePrivateMethod(AppliHeritage.class));
		checkOutput("pur héritier");
	}

	@Test
	public void testInterface() throws Exception {
		// check implementation
		assertTrue(Arrays.asList(AppliInterface.class.getInterfaces()).contains(InterfaceTemoin.class));
		assertEquals(Resultat.GAGNE, invokePrivateMethod(AppliInterface.class));
		checkOutput("implémentation par défaut");
	}

	@Test
	public void testInterfaceEtHeritage() throws Exception {
		// check implementation and inheritance
		assertTrue(Arrays.asList(AppliInterfaceEtHeritage.class.getInterfaces()).contains(InterfaceTemoin.class));
		assertEquals(ClasseTemoin.class, AppliInterfaceEtHeritage.class.getSuperclass());
		assertEquals(Resultat.GAGNE, invokePrivateMethod(AppliInterfaceEtHeritage.class));
		checkOutput("héritier");
	}

	//------------------------------------------------------
	@Test
	public void testGagneOuPerd() throws Exception {
		// check method exists
		Method m = AppliGagneOuPerd.class.getDeclaredMethod("nePasModifierCetteMéthode", new String[0].getClass());
		// check prototype
		assertEquals("private static commun.Resultat jeux.elabores.parametres.AppliGagneOuPerd.nePasModifierCetteMéthode(java.lang.String[])", m.toGenericString());
		// check call, returned value and output
		m.setAccessible(true);
		assertEquals(Resultat.GAGNE, (Resultat)m.invoke(null, new Object[]{new String[]{"gagne"}}));
		assertEquals("", getOut());
		assertEquals(Resultat.PERDU, (Resultat)m.invoke(null, new Object[]{new String[]{"perd"}}));
		assertEquals("", getOut());
	}
}
