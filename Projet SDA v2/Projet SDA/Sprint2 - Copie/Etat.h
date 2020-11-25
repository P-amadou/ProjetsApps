#ifndef _ETAT_
#define _ETAT_

#include "Tab2D.h"

enum Mouvement { FIXE, NORD, OUEST, EST, SUD };

struct Etat {
	Tab2D damier;
	Etat *parent;
	Mouvement mouvements;
	unsigned int g;
	unsigned h;
};

void afficher(const Etat& e);

#endif // !_ETAT_

