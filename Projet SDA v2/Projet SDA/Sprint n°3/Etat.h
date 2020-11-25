#ifndef _ETAT_
#define _ETAT_

#include "Tableau2D.h"

enum Mouvement { AUCUN, NORD, OUEST, EST, SUD };

struct Etat {
	Tab2D damierF;
	Etat *parent;
	Mouvement mouvements;
	unsigned int h = 0;
	unsigned int g;
};

void afficher(const Etat& e);

#endif // !_ETAT_

