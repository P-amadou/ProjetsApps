/**
 * @file ConteneurTD.cpp
 * Projet sem03-tp-Cpp1
 * @author l'équipe pédagogique 
 * @version 2 18/11/11
 * @brief corrige du TD n°3 sur machine - Exercice 1
 * Structures de données et algorithmes - DUT1 Paris 5
 */

#include <iostream>
#include <cassert>
using namespace std;

/**
 * @brief Type date
 * invariant : la date doit être valide
*/
struct Date {
	unsigned short jour, mois, annee;
};

/**
 * @brief Saisie d'une date valide
 * @return la date saisie
 */
Date saisir() {
	Date d;
	cout << "Date (jour? mois? annee?) ? "; 
	cin >> d.jour >> d.mois >> d.annee;
	return d;
}

/**
 * @brief Affiche une date */
void afficher(const Date& d) {
	cout << d.jour << '/' << d.mois << '/' << d.annee << "  ";
}

// Spécialisation du type Item (l'item est spécialisé ici en date)
typedef Date Item;

/** @brief Type du conteneur d'items 
 *  alloué en mémoire dynamique et de capacité fixée
 */ 
struct ConteneurTD {
	unsigned int capacite; 	// capacité du conteneur (>0)
	Item* tab;	// support du conteneur, un tableau alloué en mémoire dynamique de taille fixée (capacite) 
};

void initialiser(ConteneurTD& c, unsigned int capa);
void detruire(ConteneurTD& c);
Item lire(const ConteneurTD& c, unsigned int i); 
void ecrire(ConteneurTD& c, unsigned int i, const Item& it);

/**
 * @brief Initialise un conteneur d'items vide
 * Allocation en mémoire dynamique du conteneur d'items de capacité capa
 * @see detruire, pour sa désallocation en fin d'utilisation 
 * @param[out] c : le conteneur d'items
 * @param [in] capa : la capacité du conteneur
 * @pre capa>0
 */
void initialiser(ConteneurTD& c, unsigned int capa) {
	/* Vérifiez la précondition*/
	assert(capa > 0);
	c.capacite = capa;
	c.tab = new Item[capa];
	cout << "Allocation de" << c.capacite * sizeof(Item) << "octets" << endl;
	/* L'objectif est d'initialiser tous les attributs du conteneur c
	 * de telle sorte que le conteneur soit vide
	 * Dans notre cas, le support est un tableau de taille (c.capacite), qui est à initialiser */
	...
	/* De plus, le tableau (c.tab) est alloué en mémoire dynamique.
	 * Préparez le conteneur à stocker des items : allouez le tableau en mémoire dynamique */	
	...
	/* Pour tracer l'allocation en mémoire, 
	 * affichez l'allocation faite en nombre d'octets.
	 * Attention : Ne jamais faire d'affichage dans une fonction 
	 * dont ce n'est pas le rôle explicite.
	 * Cet affichage sera supprimé lorsque le conteneur sera testé*/
	 ...	
}

/**
 * @brief Désalloue un conteneur d'items en mémoire dynamique
 * @see initialiser, le conteneur d'items a déjà été alloué 
 * @param[out] c : le conteneur d'items
 */
void detruire(ConteneurTD& c) {
	delete[] c.tab;
	c.tab = NULL;
}

/**
 * @brief Lecture d'un item d'un conteneur d'items
 * @param[in] c : le conteneur d'items
 * @param[in] i : la position de l'item dans le conteneur
 * @return l'item à la position i
 * @pre i < c.capacite   
 */
 Item lire(const ConteneurTD& c, unsigned int i) {
 	/* Vérifiez la précondition 
	 * et retournez l'item à la position i dans le conteneur c */
	 assert(i < c.capacite);
	 c.tab[i] = it;
}

/**
 * @brief Ecrire un item dans un conteneur d'items
 * @param[out] c : le conteneur d'items
 * @param[in] i : la position où ajouter/modifier l'item
 * @param[in] item : l'item à écrire
 * @pre i < c.capacite
 */
void ecrire(ConteneurTD& c, unsigned int i, const Item& it) {
	assert(i < c.capacite);
	c.tab[i] = it;
}

/* Test d'un conteneur de dates */ 
int main(int argc, char *argv[]) {
	
	ConteneurTD cDates; // Déclaration du conteneur de dates testé
	unsigned int nbDates; // Nombre de dates à enregistrer dans le conteneur
	Date d;
	
	/* Lire le nombre de dates (nbDates) à enregistrer dans le conteneur */
	...
	
	/* Initialiser un conteneur (vide) de dates de capacité nbDates */
		do {

			/* Remplir le conteneur de nbDates dates */
			cout << "Nombre de dates à enregistrer dans le conteneur" << cin >> nbDates;
		} while (nbDates == 0);
		initialiser(cDates, nbDates);
		for (unsigned int i = 0; i < nbDates; ++i) {
			d = saisir();
			ecrire(cDates, i, d);
		}
	/* Afficher le conteneur de dates */
	cout << "Conteneur des dates, de capacité "<< cDates.capacite 
		 << ", alloué en mémoire dynamique :" << endl; 
	for (unsigned int i = 0; i < nbDates; ++i) {
		d = lire(cDates, i);
		afficher(d);

	}
	
	/* Désallouer le conteneur de dates */
	detruire(cDates);

	
	return 0;
}
 
