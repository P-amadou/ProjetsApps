#pragma once
#ifndef _Tab2D_
#define _Tab2D_

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

void chercherCaseNul(Tab2D &t, unsigned int &ligneX, unsigned int &ligneY);

bool comparer(const Tab2D &t1, const Tab2D &t2);

#endif // !_Tab2D_
