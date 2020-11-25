/**
*@fde ConteneurEtat.cpp
*@author Vadim Goldaniga
*@version 26/12/2018
*@brief fonction de ConteneurEtat.h
*/

#include <iostream>
#include "ConteneurEtat.h"
#include <assert.h>
using namespace std;

void initialiser(ConteneurEtat& c) {
	c.capacite = 1;
	c.pasExtension = 1;
	// arrêt du programme en cas d'erreur d'allocation
	c.tab = new Etat[c.capacite];
}

void detruire(ConteneurEtat& c) {
	delete[] c.tab;
	c.tab = NULL;
}

Etat lire(const ConteneurEtat& c, unsigned int i) {
	return c.tab[i];
}

void ecrire(ConteneurEtat& c, unsigned int i, const Etat& it) {
	if (i >= c.capacite) {
		/* Stratégie de réallocation proportionnelle au pas d'extension :
		 * initialisez la nouvelle taille du conteneur (newTaille)
		 * à i * c.pasExtension */
		unsigned int newTaille = (i + 1) * c.pasExtension;
		/* Allouez en mémoire dynamique un nouveau tableau (newT)
		 * à cette nouvelle taille*/
		Etat* newT = new Etat[newTaille];
		/* Recopiez les items déjà stockés dans le conteneur */
		for (unsigned int i = 0; i < c.capacite; ++i)
			newT[i] = c.tab[i];
		/* Désallouez l'ancien tableau support du conteneur */
		delete[] c.tab;
		/* Actualiser la mise à jour du conteneur en mémoire dynamique
		 * Faites pointer le tableau support du conteneur
		 * sur le nouveau tableau en mémoire dynamique */
		c.tab = newT;
		/* Actualisez la taille du conteneur */
		c.capacite = newTaille;
	}
	/* Ecriture de l'item (it) à la position i dans le conteneur */
	c.tab[i] = it;
}
