/*@author TRAN Léo, DIEYE Papa Amadou
 * @version 1.0
 */
package assemblageJeux;
/*@brief Classe abstraite des Assembler1_1 et Assembler1_2 
 */
public abstract class Assembler1 implements IJeux {
	IJeux jeu1;
	IJeux jeu2;

	public Assembler1 (IJeux jeu1,IJeux jeu2) {
		this.jeu1= jeu1;
		this.jeu2= jeu2;
	}
	
	

}
