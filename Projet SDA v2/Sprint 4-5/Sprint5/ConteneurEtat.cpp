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
	// arr�t du programme en cas d'erreur d'allocation
	c.tab = new Etat[c.capacite];
	/* Affichage pour une trace de l'allocation en TP
	 * Affichage � supprimer apr�s le test du conteneur */
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
		/* Strat�gie de r�allocation proportionnelle au pas d'extension :
		 * initialisez la nouvelle taille du conteneur (newTaille)
		 * � i * c.pasExtension */
		unsigned int newTaille = (i + 1) * c.pasExtension;
		/* Allouez en m�moire dynamique un nouveau tableau (newT)
		 * � cette nouvelle taille*/
		Etat* newT = new Etat[newTaille];
		/* Recopiez les items d�j� stock�s dans le conteneur */
		for (unsigned int i = 0; i < c.capacite; ++i)
			newT[i] = c.tab[i];
		/* D�sallouez l'ancien tableau support du conteneur */
		delete[] c.tab;
		/* Actualiser la mise � jour du conteneur en m�moire dynamique
		 * Faites pointer le tableau support du conteneur
		 * sur le nouveau tableau en m�moire dynamique */
		c.tab = newT;
		/* Actualisez la taille du conteneur */
		c.capacite = newTaille;
		/* Affichage pour une trace de l'allocation en TP
	* En TP, pour tracer l'extension de l'allocation en m�moire,
	* affichez les informations qui suivent.
	* Cet affichage sera supprim� apr�s le test du conteneur */
	//cout << "Extension - Allocaton/R�allocation de " << newTaille * sizeof(Etat)
		//<< " octets (" << newTaille << " items)." << endl;
	}
	/* Ecriture de l'item (it) � la position i dans le conteneur */
	c.tab[i] = it;
	//copiEtat(c.tab[i], it);
}
