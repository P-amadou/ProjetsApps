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
	/* Affichage pour une trace de l'allocation en TP
	 * Affichage à supprimer après le test du conteneur */
	 //cout << "Allocation initiale de " << capa * sizeof(Item) << " octets ("
		 //<< capa << " item(s))" << endl;
}

void detruire(ConteneurEtat& c) {
	delete[] c.tab;
	c.tab = NULL;
}

Etat lire(const ConteneurEtat& c, unsigned int i) {
	//assert(i < c.capacite);
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
		/* Affichage pour une trace de l'allocation en TP
	* En TP, pour tracer l'extension de l'allocation en mémoire,
	* affichez les informations qui suivent.
	* Cet affichage sera supprimé après le test du conteneur */
	//cout << "Extension - Allocaton/Réallocation de " << newTaille * sizeof(Etat)
		//<< " octets (" << newTaille << " items)." << endl;
	}
	/* Ecriture de l'item (it) à la position i dans le conteneur */
	c.tab[i] = it;
	//copiEtat(c.tab[i], it);
}
