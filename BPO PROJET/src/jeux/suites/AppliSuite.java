package jeux.suites;

import java.math.BigInteger;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

import assemblageJeux.IJeux;

public class AppliSuite implements IJeux{
	public boolean jouer(String[] args) {
		List<Suite> suites = Arrays.asList(
				  new SuiteMyst�re()
					, new SuiteArithm�tique(1, 10)
					, new SuiteArithm�tique(7, 25)
					, new SuiteG�om�trique(1, 10)
					, new SuiteG�om�trique(7, 25)
				);
		Random r = new Random();
		Suite suite = suites.get(r.nextInt(suites.size()));
		final int NB = args.length > 0 && args[0].equals("-hard") ? 3 : 4;
		List<BigInteger> termes = suite.premiersTermes(NB + 1);
		BigInteger aTrouver = termes.remove(NB);
		System.out.println("Trouvez l'entier qui suit logiquement la suite suivante : " + termes);
		@SuppressWarnings("resource")
		Scanner sc = new Scanner(System.in);
		BigInteger valeur = new BigInteger(sc.next()); // peut lever NumberFormatException
		if (valeur.equals(aTrouver)) {
			System.out.println("Bravo");
			return true;
		}
		else {
			System.out.println("Dommage");
			return false;
		}
	}
}
