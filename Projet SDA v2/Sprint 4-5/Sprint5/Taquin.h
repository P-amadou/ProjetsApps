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
	Liste LEAE; // liste des �tats a explorer
	Liste LEE; // liste des �tats explor�
	unsigned int nbL; // nombre de lignes du damier
	unsigned int nbC; // nombre de colonne du damier
	unsigned int iteration; // le num�ro d'it�ration
};

/**
*@brief initialise le taquin
*@param[in/out] t : le taquin
*/
void initialiser_taquin(Taquin& t);

/**
*@brief fait une it�rationc de l'algorithme de recherche
*@param[in/out] t : le taquin
*/
void jouer(Taquin& t);

/**
*@brief Affiche le contenu des listes LEAE et LEE selon le num�ro d'it�ration
*@param[in/out] t : le taquin
*/
void afficher(const Taquin& t);

/**
 *@brief renvoie vrai si l��tat existe d�j� dans le taquin
 *@param[ef] ef : l'�tat a rechercher
 *@param[t] t : le taquin
 */
bool appartient(const Etat& ef, Taquin& t);

bool jouet(Taquin& t);

void end(Taquin& t);
#endif