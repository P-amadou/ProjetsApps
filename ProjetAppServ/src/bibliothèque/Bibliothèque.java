package biblioth�que;

import java.util.ArrayList;

import abonn�s.Abon�s;

public class Biblioth�que {
	private String nom;
	private ArrayList <Livre> stock,inventaire_doc;
	private ArrayList <Abon�s> liste_ab;
	
	public Biblioth�que(String nom) {
		this.stock=inventaire_doc;
		this.inventaire_doc=new ArrayList<Livre>();
		this.liste_ab=new ArrayList<Abon�s>();
		this.setNom(nom);
	}
	public ArrayList<Livre> getStock() {
		return stock;
	}

	public void setStock(ArrayList<Livre> stock) {
		this.stock = stock;
	}
	public ArrayList<Livre> getInventaire_doc() {
		return inventaire_doc;
	}

	public void setInventaire_doc(ArrayList<Livre> inventaire_doc) {
		this.inventaire_doc = inventaire_doc;
	}
	
	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public ArrayList <Abon�s> getListe_ab() {
		return liste_ab;
	}
	public void setListe_ab(ArrayList <Abon�s> liste_ab) {
		this.liste_ab = liste_ab;
	}
	
	
}
