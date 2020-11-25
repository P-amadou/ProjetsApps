package projet;
import java.util.*;
import projet.Sac;

public class DynamiqueMeth {
	public void Dynamique(Sac s) {
		List<Objets> lst = s.getObjets();
	    int[][] m = new int[lst.size()][s.getPOIDS_MAX() + 1];
	    int p = 0;
	    Objets obj = (Objets)lst.get(0);
	    while (p < s.getPOIDS_MAX() + 1) {
	      if (obj.getPoids() > p) {
	        m[0][p] = 0;
	      } else {
	        m[0][p] = obj.getValeur();
	      } 
	      p++;
	    } 
	    
	    for (int j = 0; j < s.getPOIDS_MAX() + 1; j++) {
	      for (int i = 1; i < lst.size(); i++) {
	        obj = (Objets)lst.get(i);
	        if (obj.getPoids() > j) {
	          m[i][j] = m[i - 1][j];
	        } else {
	          m[i][j] = Math.max(m[i - 1][j], m[i - 1][j -obj.getPoids()] + obj.getValeur());
	        } 
	      } 
	    } 
	    
	    int j = s.getPOIDS_MAX();
	    while (m[lst.size() - 1][j] == m[lst.size() - 1][j - 1]) {
	      j--;
	    }
	    List<Objets> tmp = new ArrayList<Objets>();
	    int i = lst.size() - 1;
	    while (j > 0) {
	      while (i > 0 && m[i][j] == m[i - 1][j])
	        i--; 
	      j -= (int)((Objets)lst.get(i)).getPoids();
	      if (j >= 0)
	        tmp.add((Objets)lst.get(i)); 
	      i--;
	    } 
	    
	    s.setObjets(tmp);
	  
	}
}
