#include <iostream>
#include <string>
using namespace std;

#include "Tableau2D.h"

void initialiser(Tab2D& m, unsigned int nbL, unsigned int nbC) {

	Item** tableau = new Item*[nbL];
	for (unsigned int i = 0; i < nbL; i++)
	{
		tableau[i] = new Item[nbC];
	}

	m.nbL = nbL;
	m.nbC = nbC;

	m.tab = tableau;

}

void detruire(Tab2D& m) {
	delete[] m.tab;
	m.tab = NULL;
}

void lire(Tab2D& m) {

	char a[30];
	for (int i = 0; i < m.nbL; i++) {

		for (int j = 0; j < m.nbC; j++) {
			cin >> a;
			if (a != "#") {
				m.tab[i][j] = atoi(a);
			}
			else {
				m.tab[i][j] = 0;
			}
		}
	}

}

void afficher(const Tab2D& m) {

	for (int i = 0; i < m.nbL; i++) {

		for (int j = 0; j < m.nbC; j++) {
			if (m.tab[i][j] == 0) {
				cout << "  #";
			}
			else {
				if (m.tab[i][j] < 10)
				{
					cout << "  " << m.tab[i][j];
				}
				else
				{
					cout << " " << m.tab[i][j];
				}
			}
		}
		cout << endl;
	}

}

bool comparer(Tab2D &e1, Tab2D &e2) {
	for (int i = 0; i < e1.nbL; i++)
	{
		for (int j = 0; j < e1.nbC; j++)
		{
			if (e1.tab[i][j] != e2.tab[i][j]) {
				return false;
			}
		}
	}

	return true;
}