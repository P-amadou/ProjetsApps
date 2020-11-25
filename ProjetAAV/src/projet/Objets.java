package projet;

public class Objets {
	private int poids,valeur;
	private String nom;
	
	public Objets(int poids,int valeur,String nom) {
		this.poids=poids;
		this.valeur=valeur;
		this.nom=nom;
	}
	
	public int getPoids() {
		return this.poids;
	}
	
	public int getValeur() {
		return this.valeur;
	}
	
	public String getNom() {
		return this.nom;
	}
}
