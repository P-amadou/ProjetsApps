package exercices;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

import tests.Test1JeuxBasiques;
import tests.Test2SupportJeuxElabores;
import tests.Test3CompositionsSimples;
import tests.Test4CompositionsElaborees;
import tests.Test5NouveauxModesDeCompositions;
import tests.TestIntegrite;

@RunWith(Suite.class)
@Suite.SuiteClasses({
	TestIntegrite.class,
	Test1JeuxBasiques.class,
	Test2SupportJeuxElabores.class,
	Test3CompositionsSimples.class,
	Test4CompositionsElaborees.class,
	Test5NouveauxModesDeCompositions.class,
})

public class TestSuite {
}
