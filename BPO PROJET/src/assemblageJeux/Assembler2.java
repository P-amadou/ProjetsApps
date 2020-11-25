/*@author TRAN Léo, DIEYE Papa Amadou
 * @version 1.0
 */
package assemblageJeux;

/*@brief Créer un nouveau jeu avec le jeu en paramètre où il faut gagner le jeu en moins de n tentatives pour gagner le nouveau jeu
 */
public class Assembler2 implements IJeux{
	private IJeux jeu1;
	private int n;

	public Assembler2 (IJeux jeu1, int n) {
		this.jeu1= jeu1;
		this.n = n;

	}

	@Override
	public boolean jouer(String[] args) {		
		try {
		for(int i=0;i<this.n;++i) {
			if(jeu1.jouer(args)) {
				System.out.println("Bravo");
				return true;
			}
		}
		System.out.println("Dommage");
		return false;
		}
		catch (Exception e) {
			return true;
		}
	}
}
