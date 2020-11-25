package projet;
import projet.Sac;
import projet.Objets;

import java.util.*;

public class Glouton {
	public void glouton(Sac s) {
		List<Objets> objs=s.getObjets();
		HashMap<Objets, Integer> objsRapport= new HashMap<Objets, Integer>();
		for(Objets o : objs) {
			objsRapport.put(o, Integer.valueOf(o.getValeur()/o.getPoids()));
		}
		
		
		 for (int i = 0; i < objs.size() - 1; i++) {
		      for (int j = i + 1; j < objs.size(); j++) {
		        if ((objsRapport.get(objs.get(i))).intValue() < (objsRapport.get(objs.get(j))).intValue()) {
		          Objets tmp = (Objets)objs.get(i);
		          objs.set(i, (Objets)objs.get(j));
		          objs.set(j, tmp);
		        } 
		      } 
		    } 
	
		 int cpt = 0;
		    for (int i = 0; i < objs.size(); i++) {
		      if (cpt + ((Objets)objs.get(i)).getPoids() > s.getPOIDS_MAX()) {
		        objs.remove(objs.get(i));
		        i--;
		      } else {
		        cpt += ((Objets)objs.get(i)).getPoids();
		      } 
		    } 
		    
		    s.setObjets(objs);
	}
}
