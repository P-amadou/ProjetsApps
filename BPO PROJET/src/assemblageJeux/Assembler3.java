/*@author TRAN L�o, DIEYE Papa Amadou
 * @version 1.0
 */
package assemblageJeux;


/*@brief Cr�er un nouveau jeu avec le jeu en param�tre o� l'on joue tant qu'on a pas gagn� pour gagner le nouveau jeu
 */
public class Assembler3 implements IJeux{
	IJeux jeu1;


	public Assembler3 (IJeux jeu1) {
		this.jeu1= jeu1;

	}

	@Override
	public boolean jouer(String[] args) {
		try {
			boolean b=false;
			while (b!=true) {
				b=jeu1.jouer(args);
			}
			System.out.println("Bravo");
			return true;
		}
		catch (Exception e) {
			return true;
		}
	}
}
