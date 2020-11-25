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
void jouer(Taquin& t);
Mouvement *mouvements_possible(int lignex, int ligney, int maxX, int maxY);
void générerFils(Mouvement *tab_mouvement, Etat& e, int lignex, int ligney, Taquin& t);
void afficher(Taquin& t);

#endif // !_TAQUIN_

 