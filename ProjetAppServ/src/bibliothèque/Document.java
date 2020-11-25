package bibliothèque;

import abonnés.Abonés;

public interface Document {
	public int numero();
	public void reserver(Abonés ab) throws EmpruntException ;
	public void emprunter(Abonés ab) throws EmpruntException;
	// retour document ou annulation réservation
	public void retour() throws RetourException; 
}
