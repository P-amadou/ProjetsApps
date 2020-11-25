#pragma once
#ifndef _TABLEAU2D_
#define _TABELAU2D_

#include "Item.h"

struct Tab2D {
	Item** tab;
	int nbL;
	int nbC;
};

// Allouer en mémoire dynamique un Tableau2D
void initialiser(Tab2D& m, unsigned int nbL, unsigned int nbC);
// Desallouer un Tableau2D
void detruire(Tab2D& m);
// Lire un Tableau2D
void lire(Tab2D& m);
// Afficher un Tableau2D
void afficher(const Tab2D& m);

bool comparer(Tab2D &e1, Tab2D &e2);

#endif // !_TABLEAU2D_
