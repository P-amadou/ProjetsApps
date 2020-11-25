/**
*@fde Etat.h
*@author Vadim Goldaniga
*@version 14/12/2018
*@brief composant Etat
*/

#ifndef _ETAT_
#define _ETAT_
#define DIM 2 // nombre de dimension du tableau
#include "Tableau2D.h"


enum Move { NORD, EST, SUD, OUEST, FIXE };

/**
 *@brief composant de Etat
 */
struct Etat {
	Tableau2D d; // damier résultant
	Move movement; // mouvement du #
	unsigned int index; // index du damier prédédent (dans LEE)
	unsigned int g; // nombre de coup de l'état initial à e
	unsigned int h; // heuristique h de e a l'etat but
	unsigned int pos[DIM]; // position de la case vide dans le damier résultant
};

/**
*@brief initialise un état du taquin
*@param[in] e : l'état du taquin
*/
void initialiser(Etat& e);


/**
*@brief affiche un état du taquin
*@param[in] e : l'état du taquin
*/
void afficher(const Etat& e);

/**
*@brief détruit un état du taquin
*@param[in] e : l'état du taquin
*/
void detruire(Etat& e);

/**
*@brief renvoie vrai s’il s’agit de l’état final, faux sinon
*@param[in] e : l'état
*/
bool but(const Etat& e);

/**
 *@brief calcul de l'heuristique de l'etat donné
 *@param[in] e : l'etat
 *return l'heuristique
 */
unsigned int heuristique(Etat& e);
unsigned int heuristique2(Etat& e);

/**
 *@brief copie un etat dans un autre
 *@param[in/out] e : l'etat ou l'on copie
 *@param[in] eout : l'etat copié
 */
void copiEtat(Etat& e,const Etat& eout);

#endif