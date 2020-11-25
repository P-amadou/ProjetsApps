package projet;
import java.util.*;

public class Sac {
	private int POIDS_MAX=30; //Initialisation poids max du sac
	
	public int getPOIDS_MAX() {
		return POIDS_MAX;
	}

	List<Objets> objs;
	
	public Sac() {
		this.objs= new ArrayList<Objets>();
	}

	public void setObjets(List<Objets> objs) {
		this.objs=objs;
	}


	public List<Objets> getObjets() {
		return this.objs;
	}

	 
	  public int getPoids() {
	    int poids = 0;
	    for (Objets o : this.objs) {
	      poids += o.getPoids();
	    }
	    return poids;
	  }
	  
	  public float getValeur() {
	    int valeur = 0;
	    for (Objets o : this.objs) {
	      valeur += o.getValeur();
	    }
	    return valeur;
	  }
	
	  public String toString() {
		    StringBuilder s = new StringBuilder();
		    s.append("Poids : ");
		    s.append(getPoids());
		    //s.append(" / ");
		    s.append(this.POIDS_MAX);
		    s.append("Kg");
		    s.append(System.lineSeparator());
		    s.append("Valeur : ");
		    s.append(getValeur());
		    s.append("€");
		    s.append(System.lineSeparator());
		    s.append("Contenu : ");
		    s.append(System.lineSeparator());
		    for (Objets o : this.objs) {
		      s.append(o.getNom());
		      s.append(" ; ");
		      s.append(o.getPoids());
		      s.append("kg ; ");
		      s.append(o.getValeur());
		      s.append("€");
		      s.append(System.lineSeparator());
		    } 
		    return s.toString();
		  }
}
