/*@author TRAN L�o, DIEYE Papa Amadou
 * @version 1.0
 */
package assemblageJeux;

import java.util.ArrayList;
import java.util.List;

import jeux.crazy.AppliCrazy;
import jeux.devinettes.AppliDevinettes;
import jeux.intrus.AppliIntrus;
import jeux.pendu.AppliPendu;
import jeux.pfc.AppliPierreFeuilleCiseaux;
import jeux.pppg.AppliPlusPetitPlusGrand;
import jeux.suites.AppliSuite;
import jeux.tictactoe.AppliTicTacToe;
/*@brief Liste o� les jeux seront stock�s pour cr�er de nouveau jeux
 */
public class LJeux {
	protected List<IJeux> listeJeux =new ArrayList <IJeux>();
	
	public LJeux () {		
//		listeJeux.add(new IJeux());

	}
}
