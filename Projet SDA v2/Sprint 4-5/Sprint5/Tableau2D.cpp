/**
*@fde Tableau2D.cpp
*@author Vadim Goldaniga
*@version 13/12/2018
*@brief fonction du tableau 2D
*/

#include <iostream>
#include <cassert>
#include "Tableau2D.h"
using namespace std;

/**
*@brief initialise un tableau a 2 dimension
*@param[in/out] m : le tableau 2D
*@param[in] nbL : nombre de lignes
*@param[in] nbC : mombre de colonnes
*/
void initialiser(Tableau2D& m, unsigned int nbL, unsigned int nbC) {
	assert((nbL > 0) && (nbC > 0));
	m.nbLig = nbL;
	m.nbCol = nbC;
	m.tab = new Item1*[nbL];

	for (unsigned int i = 0; i < nbL; ++i) {
		m.tab[i] = new Item1[nbC];
	}
}

void detruire(Tableau2D& m) {
	for (unsigned int i = 0; i < m.nbLig; ++i) {
		delete[] m.tab[i];
	}
	delete[] m.tab;
	m.tab = NULL;
}

void lire(Tableau2D& m) {
	for (unsigned int i = 0; i < m.nbLig; ++i) {
		for (unsigned int j = 0; j < m.nbCol; ++j) {
			cin >> m.tab[i][j];
			if (cin.fail()) {
				cin.clear();
				char c;
				cin >> c;
				if (c != '#') {
					cerr << " valeur incorrect ";
					system("pause");
					exit(1);

				}
				m.tab[i][j] = 0;
			}
		}
	}
}

void afficher(const Tableau2D& m) {
	for (unsigned int i = 0; i < m.nbLig; ++i) {
		for (unsigned int j = 0; j < m.nbCol; ++j) {
			cout << "  ";
			if (m.tab[i][j] == 0) {
				cout << "#";// << "  ";
			}
			else {
				cout << m.tab[i][j];// << "  ";
			}

		}
		cout << endl;// << "  ";
	}
}

void emplacement_zero(const Tableau2D& t, unsigned int* pos) {
	for (unsigned int i = 0; i < t.nbLig; ++i) {
		for (unsigned int j = 0; j < t.nbCol; ++j) {
			if (t.tab[i][j] == 0) {
				pos[0] = i;
				pos[1] = j;
				break;
			}
		}
	}
}

void copieTab2D(Tableau2D& tab, const Tableau2D& tableau) {
	assert((tab.nbCol == tableau.nbCol) && (tab.nbLig == tableau.nbLig));
	for (unsigned int i = 0; i < tab.nbLig; ++i) {
		for (unsigned int j = 0; j < tab.nbCol; ++j) {
			tab.tab[i][j] = tableau.tab[i][j];
		}
	}
}

bool compareTab(const Tableau2D& t, const Tableau2D tab) {
	assert((t.nbCol == tab.nbCol) && (t.nbLig == tab.nbLig));
	for (unsigned int i = 0; i < t.nbLig; ++i) {
		for (unsigned int j = 0; j < t.nbCol; ++j) {
			if (t.tab[i][j] != tab.tab[i][j]) {
				return false;
			}
		}
	}
	return true;
}

bool compareEtatFinaux(const Tableau2D& t, const Tableau2D Etattab) {
	assert((t.nbCol == Etattab.nbLig) && (t.nbLig == Etattab.nbCol));
	for (unsigned int i = 0; i < t.nbLig; ++i) {
		for (unsigned int j = 0; j < t.nbCol; ++j) {
			if (t.tab[i][j] != Etattab.tab[j][i]) {
				return false;
			}
		}
	}
	return true;
}