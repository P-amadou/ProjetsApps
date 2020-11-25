#ifndef _TAQUIN_
#define _TAQUIN_

#include "Item.h"
#include "Tableau2D.h"
#include "Etat.h"
#include "Liste.h"

struct Taquin {
	Tab2D initial;
	Tab2D* final;
	int nbL;
	int nbC;
	Liste LEE;
	Liste LEAE;
};

void initialiser(Taquin& t);
void jouer(Taquin& t);
Mouvement *mvts_possible(int lignex, int ligney, int maxX, int maxY);
void creer(Mouvement *tab_mouvement, Etat& e, int lignex, int ligney, Taquin& t);
void afficher(Taquin& t);

bool appartient(Etat& ef, Taquin& t);
bool but(Etat& e, Taquin &t);
void initialiserFinal(Taquin& t, unsigned int nbL, unsigned int nbC);

Etat chercher(Taquin &t);

#endif // !_TAQUIN_

