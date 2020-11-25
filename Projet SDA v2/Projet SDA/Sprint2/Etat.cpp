#include <iostream>
using namespace std;

#include "Etat.h"
#include "Tab2D.h"

void afficher(const Etat& e) {
	if (e.parent != NULL) {
		switch (e.mouvements) {
		case NORD:
			cout << "NORD" << endl;
			break;
		case SUD:
			cout << "SUD" << endl;
			break;
		case EST:
			cout << "EST" << endl;
			break;
		case OUEST:
			cout << "OUEST" << endl;
			break;
		default:
			break;
		}
	}

	afficher(e.damier);
	cout << "f=g+h=" << e.g << "+" << e.h << "=" << (e.g + e.h) << endl;
}

bool but(Etat &e) {
	Tab2D solu1;
	initialiser(solu1, e.damier.nbL, e.damier.nbC);

	for (int x = 0; x < e.damier.nbL; x++) {
		for (int y = 0; y < e.damier.nbC; y++) {
			solu1.tab[x][y] = (x + y);
		}
	}

	solu1.tab[e.damier.nbL - 1][e.damier.nbC - 1] = 0;

	if (comparer(e.damier, solu1) == true) {
		return true;
	}

	Tab2D nouvelEtat = solu1;

	for (int i = 0; i < e.damier.nbC - 1; i++) {
		for (int x = 0; x < e.damier.nbL; x++) {
			for (int y = 0; y < e.damier.nbC - 1; y++) {
				nouvelEtat.tab[x][y + 1] = nouvelEtat.tab[x][y];
			}

			nouvelEtat.tab[x][0] = nouvelEtat.tab[x][e.damier.nbC - 1];
		}

		if (comparer(e.damier, nouvelEtat) == true) {
			return true;
		}
	}

	return false;

}