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
	unsigned int capacite; 	   // capacit� du conteneur (>0)
	unsigned int pasExtension; // pas d'extension du conteneur (>0)
	Etat* tab;				   // conteneur allou� en m�moire dynamique
};

/**
 *@brief initialise le conteneur d'etat
 *@param [in/out] a : le conteneur d'etat
 */
void initialiser(ConteneurEtat& a);

/**
 * @brief D�salloue un conteneur d'items en m�moire dynamique
 * @see initialiser, le conteneur d'items a d�j� �t� allou�
 * @param[in,out] c : le conteneur d'items
 */
void detruire(ConteneurEtat& c);

/**
 * @brief Lecture d'un etat d'un conteneur d'etat
 * @param[in] c : le conteneur d'etat
 * @param[in] i : la position de l'etat dans le conteneur
 * @return l'etat � la position i
 * @pre i < c.capacite
 */
Etat lire(const ConteneurEtat& c, unsigned int i);

/**
 * @brief Ecrire un item dans un conteneur d'items
 * @param[out] c : le conteneur d'items
 * @param[in] i : la position o� ajouter/modifier l'item
 * @param[in] item : l'item � �crire
 * @pre i < c.capacite
 */
void ecrire(ConteneurEtat& c, unsigned int i, const Etat& it);



#endif