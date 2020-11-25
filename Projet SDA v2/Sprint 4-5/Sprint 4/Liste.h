/**
*@fde Liste.h
*@author Vadim Goldaniga
*@version 20/12/2018
*@brief structure de liste
*/

#ifndef _LISTE_
#define _LISTE_
#include "Etat.h"
#include "ConteneurEtat.h"

struct Liste {
	ConteneurEtat c;	// Stockage des éléments de liste dans une chaîne d'items
	unsigned int nb;    // nombre d'éléments dans la liste
	unsigned int eCourant;	// index de la position courante dans la chaîne    
};

/**
* @brief Initialiser une liste vide
* la liste est allouée en mémoire dynamique
* @see detruire, elle est à désallouer en fin d’utilisation
* @param[out] l : la liste à initialiser (vide)
*/
void initialiser_liste(Liste& l);

/**
* @brief Désallouer une liste
* @see initialiser, la liste a déjà été allouée en mémoire dynamique
* @param[out] l : la liste
*/
void detruire(Liste& l);

/**
 * @brief Longueur de liste
 * @param[in] l : la liste
 * @return la longueur
 */
unsigned int longueur(const Liste& l);

/**
 * @brief Lire un élément de liste
 * @param[in] l : la liste
 * @param[in] i : la position de l'élément
 * @return l'item lu
 * @pre 0<=i<=longueur(l)
 */
Etat lire(Liste& l, unsigned int i);

/**
 * @brief Ecrire un item dans la liste
 * @param[in,out] l : la liste
 * @param[in] i : position de l'élément à écrire
 * @param[in] it : l'item
 * @pre 0<=i<=longueur(l)
 */
void ecrire(Liste& l, unsigned int i, const Etat& it);

/**
 * @brief Insérer un élément dans une liste
 * @param[in,out] l : la liste
 * @param[in] pos : la position avant laquelle l'élément est inséré
 * @param[in] it : l'élément inséré
 * @pre 0<=i<=longueur(l)+1
 */
void inserer(Liste& l, unsigned int pos, const Etat& it);

/**
 * @brief Supprimer un élément dans une liste
 * @param[in,out] l : la liste
 * @param[in] i : la position de l'élément à supprimer
 * @pre 0<=i<=longueur(l)
 */
void supprimer(Liste& l, unsigned int pos);

/**
 *@brief renvoie vrai si il n'y a qu'un seul etat qui a le plus petit g dans la liste
 *@param[in] l : la liste
 *return vrai ou faux
 */
bool gminim(Liste& l);

/**/
unsigned int indexminim(Liste& l);

/**
 *@brief renvoie vrai si il y un etat unique de la liste, de valeur h minimal dans les etats de même g valeurs
 *@param[in] l : liste
 *@return vrai ou faux
 */
bool ettuni(Liste& l);

/**
 *@brief renvoie l'index de l'etat avec le h minimal de la liste
 *@param[in] l : la liste
 *@return vrai ou faux
 */
unsigned int indexhmin(Liste& l);

/**
 *@brief renvoie l'index de l'etat (e) le plus recent avec h minimal et g minimal de la liste
 *@param[in] l : la liste
 *@return l'index
 */
unsigned int plusrecentindex(Liste& l);

#endif