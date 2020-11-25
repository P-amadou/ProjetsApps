#ifndef _Tab2D_
#define _Tab2D_
#include "Item.h"

struct Tab2D {
	Item **tab; // adresse du tableau bidimensionnel
				// en mémoire dynamique
	int nbL; // nombre de lignes de la matrice
	int nbC; // nombre de colonnes de la matrice
};


// Allouer en mémoire dynamique un Tableau2D
void initialiser(Tab2D& m, unsigned int nbL,unsigned int nbC);
// Desallouer un Tableau2D
void detruire(Tab2D& m);
// Lire un Tableau2D
void lire(Tab2D& m);
// Afficher un Tableau2D
void afficher(const Tab2D& m);

#endif // !1
