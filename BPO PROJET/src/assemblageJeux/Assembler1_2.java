/*@author TRAN Léo, DIEYE Papa Amadou
 * @version 1.0
 */
package assemblageJeux;


/*@brief Assemble les deux jeux en paramètre pour créer un nouveau jeu où il faut gagner un des deux jeux pour gagner le nouveau jeu
 */
public class Assembler1_2 extends Assembler1 implements IJeux{

	public Assembler1_2 (IJeux jeu1,IJeux jeu2) {
		super(jeu1, jeu2);
	}
	
	@Override
	public boolean jouer(String[] args) {
		try {
		if(jeu1.jouer(args))	
		return true;
		else if(jeu2.jouer(args)) {
			System.out.println("Bravo");
			return true;
		}
		else {
			System.out.println("Dommage");		
			return false;
		}
		}
		catch (Exception e) {
			return true;
		}
	}
}