package assemblageJeux;

public class Assembler4 implements IJeux{
	IJeux jeu1;


	public Assembler4 (IJeux jeu1) {
	this.jeu1= jeu1;
		
	}

	@Override
	public boolean jouer(String[] args) {
		boolean b=false;
		while (b!=true) {
			b=jeu1.jouer(args);
		}
			return true;
	}
}
