/**
*@fde Taquin.h
*@author Vadim Goldaniga
*@version 14/12/2018
*@brief composant de Taquin
*/

#ifndef _TAQUIN_
#define _TAQUIN_

#include "Etat.h"
#include "Liste.h"

/**
*@brief structure du taquin
*/
struct Taquin {
	Liste LEAE; // liste des états a explorer
	Liste LEE; // liste des états exploré
	unsigned int nbL; // nombre de lignes du damier
	unsigned int nbC; // nombre de colonne du damier
	unsigned int iteration; // le numéro d'itération
};

/**
*@brief initialise le taquin
*@param[in/out] t : le taquin
*/
void initialiser_taquin(Taquin& t);

/**
*@brief fait une itérationc de l'algorithme de recherche
*@param[in/out] t : le taquin
*/
void jouer(Taquin& t);

/**
*@brief Affiche le contenu des listes LEAE et LEE selon le numéro d'itération
*@param[in/out] t : le taquin
*/
void afficher(const Taquin& t);

/**
 *@brief renvoie vrai si l‘état existe déjà dans le taquin
 *@param[ef] ef : l'état a rechercher
 *@param[t] t : le taquin
 */
bool appartient(const Etat& ef, Taquin& t);

bool jouet(Taquin& t);

void end(Taquin& t);
#endif