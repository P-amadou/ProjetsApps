/**
*@fde ConteneurEtat.h
*@author Vadim Goldaniga
*@version 26 / 12 / 2018
* @brief composant de ConteneurEtat
*/

#ifndef _CONTENEURETAT_
#define _CONTENEURETAT_

#include "Etat.h"

/**
 *@brief Structure d'un conteneur
 */
struct ConteneurEtat {
	unsigned int capacite; 	   // capacité du conteneur (>0)
	unsigned int pasExtension; // pas d'extension du conteneur (>0)
	Etat* tab;				   // conteneur alloué en mémoire dynamique
};

/**
 *@brief initialise le conteneur d'etat
 *@param [in/out] a : le conteneur d'etat
 */
void initialiser(ConteneurEtat& a);

/**
 * @brief Désalloue un conteneur d'items en mémoire dynamique
 * @see initialiser, le conteneur d'items a déjà été alloué
 * @param[in,out] c : le conteneur d'items
 */
void detruire(ConteneurEtat& c);

/**
 * @brief Lecture d'un etat d'un conteneur d'etat
 * @param[in] c : le conteneur d'etat
 * @param[in] i : la position de l'etat dans le conteneur
 * @return l'etat à la position i
 * @pre i < c.capacite
 */
Etat lire(const ConteneurEtat& c, unsigned int i);

/**
 * @brief Ecrire un item dans un conteneur d'items
 * @param[out] c : le conteneur d'items
 * @param[in] i : la position où ajouter/modifier l'item
 * @param[in] item : l'item à écrire
 * @pre i < c.capacite
 */
void ecrire(ConteneurEtat& c, unsigned int i, const Etat& it);



#endif