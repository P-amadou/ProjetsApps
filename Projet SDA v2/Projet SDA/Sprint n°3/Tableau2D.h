#pragma once
#ifndef _TABLEAU2D_
#define _TABELAU2D_

#include "Item.h"

struct Tab2D {
	Item** tab;
	int nbL;
	int nbC;
};


void initialiser(Tab2D& m, unsigned int nbL, unsigned int nbC);
void detruire(Tab2D& m);
void lire(Tab2D& m);
void afficher(const Tab2D& m);

bool comparer(Tab2D &e1, Tab2D &e2);
#endif // !_TABLEAU2D_
