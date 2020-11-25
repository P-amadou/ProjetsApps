#include <iostream>
#include <iomanip>
using namespace std;
#include "Tab2D.h"


// Allouer en mémoire dynamique un Tableau2D
void initialiser(Tab2D& m, unsigned int nbL, unsigned int nbC) {
	m.nbL = nbL;
	m.nbC = nbC;
	m.tab = new Item*[nbL];
	for (int i = 0; i < nbL; i++) {
		m.tab[i] = new Item[nbC];
	}
}

// Desallouer un Tableau2D
void detruire(Tab2D& m){
	delete[] m.tab;
}
// Lire un Tableau2D
void lire(Tab2D& m){
	
	for (int i = 0; i < m.nbL; i++) {
		for (int j = 0; j < m.nbC; j++) {
			char tmp[2];
			cin >> tmp;
			if(strcmp(tmp,"#")==0)
				m.tab[i][j] = 0;
			else 
			m.tab[i][j] = atoi(tmp);
		}
	}
}
// Afficher un Tableau2D
void afficher(const Tab2D& m){
	for (int i = 0; i < m.nbL; i++) {
		for (int j = 0; j < m.nbC; j++) {
			if (m.tab[i][j] == 0)
				cout << "# ";
			else
				cout << m.tab[i][j] <<" ";
		}
		cout << endl;
	}
}


void chercherCaseNul(Tab2D &t, unsigned int &ligneX, unsigned int &ligneY) {

	for (int x = 0; x < t.nbL; x++) {
		for (int y = 0; y < t.nbC; y++) {
			//on cherche la case contenant un # (c'est une case nulle)
			if (t.tab[x][y] == 0) {
				//on l'a trouvé, on peut arreter les deux boucles et retourner sa position
				ligneX = x;
				ligneY = y;
				break;
			}
		}
	}

}

bool comparer(const Tab2D &t1, const Tab2D &t2) {
	for (int x = 0; x < t1.nbL; x++) {
		for (int y = 0; y < t1.nbC; y++) {
			if (t1.tab[x][y] != t2.tab[x][y]) {
				return false;
			}
		}
	}

	return true;
}