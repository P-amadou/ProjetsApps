#ifndef _TAQUIN_
#define _TAQUIN_

#include "Item.h"
#include "Tab2D.h"
#include "Etat.h"
#include "Liste.h"

struct Taquin {
	Tab2D initial;
	int nbL;
	int nbC;
	Liste LEE;
	Liste LEAE;
};

void initialiser(Taquin& t);
bool jouer(Taquin& t);
Mouvement *mouvements_possible(int lignex, int ligney, int maxX, int maxY);
void g�n�rerFils(Mouvement *tab_mouvement, Etat& e, int lignex, int ligney, Taquin& t);
void afficher(Taquin& t);

Etat min(Taquin &t);

bool existe(Etat &e, Taquin &t);


#endif // !_TAQUIN_

 