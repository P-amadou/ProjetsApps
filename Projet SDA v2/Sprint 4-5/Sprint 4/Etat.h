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
	Tableau2D d; // damier r�sultant
	Move movement; // mouvement du #
	unsigned int index; // index du damier pr�d�dent (dans LEE)
	unsigned int g; // nombre de coup de l'�tat initial � e
	unsigned int h; // heuristique h de e a l'etat but
	unsigned int pos[DIM]; // position de la case vide dans le damier r�sultant
};

/**
*@brief initialise un �tat du taquin
*@param[in] e : l'�tat du taquin
*/
void initialiser(Etat& e);


/**
*@brief affiche un �tat du taquin
*@param[in] e : l'�tat du taquin
*/
void afficher(const Etat& e);

/**
*@brief d�truit un �tat du taquin
*@param[in] e : l'�tat du taquin
*/
void detruire(Etat& e);

/**
*@brief renvoie vrai s�il s�agit de l��tat final, faux sinon
*@param[in] e : l'�tat
*/
bool but(const Etat& e);

/**
 *@brief calcul de l'heuristique de l'etat donn�
 *@param[in] e : l'etat
 *return l'heuristique
 */
unsigned int heuristique(Etat& e);
unsigned int heuristique2(Etat& e);

/**
 *@brief copie un etat dans un autre
 *@param[in/out] e : l'etat ou l'on copie
 *@param[in] eout : l'etat copi�
 */
void copiEtat(Etat& e,const Etat& eout);

#endif