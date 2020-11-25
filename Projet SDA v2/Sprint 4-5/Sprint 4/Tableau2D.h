#ifndef _TABLEAU2D_
#define _TABLEAU2D_

/**
*@fde Tableau.h
*@author Vadim Goldaniga
*@version 13/12/2018
*@brief composant de matrice
*/
#include <iostream>
#include "Item1.h"

/**
*@brief type tableau 2D
*/
struct Tableau2D {
	Item1** tab; // Le tableau en mémoire dynamique
	unsigned int nbLig; // Le nombre de lignes
	unsigned int nbCol; // Le nombre de colonnes
};

/**
*@brief initialise un tableau a 2 dimension
*@param[in/out] m : le tableau 2D
*@param[in] nbL : nombre de lignes
*@param[in] nbC : mombre de colonnes
*/
void initialiser(Tableau2D& m, unsigned int nbL, unsigned int nbC);

/**
*@brief désalloue le tableau 2D en mémoire dynamique
*@param[in/out] m : le tableau
*/
void detruire(Tableau2D& m);

/**
*@brief lit le tableau 2D
*@param[in/out] m : le tableau
*/
void lire(Tableau2D& m);

/**
*@brief affiche le tableau 2D
*@param[in] m : le tableau
*/
void afficher(const Tableau2D& m);

/**
 *@brief donne l'emplacement du hashtag dans le tableau 2d
 *@param[in] t : le tableau 2d
 *@param[in/out] emplacement du hashtag (ligne,colonne)
 */
void emplacement_zero(const Tableau2D& t, unsigned int* pos);

/**
 *@brief copie un tableau en deux dimension dans un autre tableau en deux dimension
 *@param[in/out] tab : le tableau ou on copie
 *@param[in] tableau : le tableau copié
 */
void copieTab2D(Tableau2D& tab, const Tableau2D& tableau);

/**
 *@brief renvoie vrai si le premier tableau et le second tableau sont les mêmes
 *@param[in] t : premier tableau
 *@param[in] tab : second tableau
 */
bool compareTab(const Tableau2D& t, const Tableau2D tab);

/**
 *@brief renvoie vrai si le premier tableau2D et le second tableau (qui est un état finale) sont les mêmes (compare)
 *@param[in] t : premier tableau
 *@param[in] tab : second tableau (état finale)
 */
bool compareEtatFinaux(const Tableau2D& t, const Tableau2D Etattab);

#endif