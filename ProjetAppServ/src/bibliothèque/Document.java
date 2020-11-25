package biblioth�que;

import abonn�s.Abon�s;

public interface Document {
	public int numero();
	public void reserver(Abon�s ab) throws EmpruntException ;
	public void emprunter(Abon�s ab) throws EmpruntException;
	// retour document ou annulation r�servation
	public void retour() throws RetourException; 
}
