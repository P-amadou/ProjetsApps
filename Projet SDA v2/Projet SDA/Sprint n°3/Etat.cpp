#include <iostream>
using namespace std;

#include "Etat.h"
#include "Tableau2D.h"

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

	afficher(e.damierF);
	
	printf("f=g+h=%d+%d=%d\n", e.g, e.h, (e.g + e.h));
}