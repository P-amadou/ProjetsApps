/**
*@fde Etat.cpp
*@author Vadim Goldaniga
*@version 14/12/2018
*@brief fonction de la structure Etat
*/

#include <iostream>
#include "Etat.h"
#include "Tableau2D.h"
using namespace std;

void afficher(const Etat& e) {
	if (e.movement == NORD) {
		cout << "NORD" << endl;
	}
	else if (e.movement == EST) {
		cout << "EST" << endl;
	}
	else if (e.movement == SUD) {
		cout << "SUD" << endl;
	}
	else if (e.movement == OUEST) {
		cout << "OUEST" << endl;
	}
	afficher(e.d);
}

void initialiser(Etat& e) {
	unsigned int nbL, nbC;
	cin >> nbL;
	cin >> nbC;
	e.g = 0;
	initialiser(e.d, nbL, nbC);
	lire(e.d);
	e.movement = FIXE;
	e.index = NULL;
	emplacement_zero(e.d, e.pos);
	e.h = heuristique2(e);
}

void detruire(Etat& e) {
	detruire(e.d);
}

bool but(const Etat& e) {

	Tableau2D tab2D;
	initialiser(tab2D, e.d.nbCol, e.d.nbLig); //(ligne / colonne)

	for (unsigned int i = 0; i < e.d.nbCol; ++i) {
		for (unsigned int j = 0; j < e.d.nbLig; ++j) {
			if (i == e.d.nbCol - 1 && j == e.d.nbLig - 1) {
				tab2D.tab[i][j] = 0;
			}
			else {
				tab2D.tab[i][j] = 1 + i + j * e.d.nbCol;
			}
		}
	}

	if (compareEtatFinaux(e.d, tab2D) == true) {
		detruire(tab2D);
		return true;
	}

	Tableau2D tabD;
	initialiser(tabD, e.d.nbCol, e.d.nbLig);
	for (unsigned int i = 0; i < e.d.nbCol - 1; ++i) { // boucle de décalage a gauche

		for (unsigned int j = 0; j < tabD.nbLig; ++j) { // boucle des colonnes

			for (unsigned int h = 0; h < tabD.nbCol; ++h) { // boucle des lignes
				tabD.tab[j][h] = tab2D.tab[(j + 1 + i) % e.d.nbCol][h];
			}
		}
		if (compareEtatFinaux(e.d, tabD) == true) {
			detruire(tab2D);
			detruire(tabD);
			return true;
		}
	}
	detruire(tab2D);
	detruire(tabD);
	return false;

}

unsigned int heuristique(Etat& e) {

	unsigned int h = 0; // l'heuristique

	Tableau2D TabH; // tableau heuristique (tableau non etat finale)
	initialiser(TabH, e.d.nbLig, e.d.nbCol);

	for (unsigned int i = 0; i < e.d.nbLig; ++i) { // met toutes les valeurs du tableau heuristique à 0
		for (unsigned int j = 0; j < e.d.nbCol; ++j) {
			TabH.tab[i][j] = 0;
		}
	}

	Tableau2D tab2D; // tableau etat finale (les lignes et les colonnes sont inversé)
	initialiser(tab2D, e.d.nbCol, e.d.nbLig); //(ligne / colonne)

	for (unsigned int i = 0; i < e.d.nbCol; ++i) { // crée d'aprés le nombres de ligne et le nombre de colonnes le premier tableau finale (avec les valeur qui se suivent)
		for (unsigned int j = 0; j < e.d.nbLig; ++j) {
			if (i == e.d.nbCol - 1 && j == e.d.nbLig - 1) {
				tab2D.tab[i][j] = 0;
			}
			else {
				tab2D.tab[i][j] = 1 + i + j * e.d.nbCol;
			}
		}
	}

	for (unsigned int i = 0; i < e.d.nbLig; ++i) { 
		for (unsigned int j = 0; j < e.d.nbCol; ++j) {
			if (e.d.tab[i][j] != tab2D.tab[j][i]) {
				TabH.tab[i][j] += 1;
			}
		}
	}

	Tableau2D tabD; // tableau etat finale (les lignes et les colonnes sont inversé)
	initialiser(tabD, e.d.nbCol, e.d.nbLig);

	for (unsigned int i = 0; i < e.d.nbCol - 1; ++i) { // boucle de décalage a gauche

		//-------------------------------------------------------------création d'un tableau décaler
		//
		for (unsigned int j = 0; j < tabD.nbLig; ++j) { // boucle des colonnes

			for (unsigned int h = 0; h < tabD.nbCol; ++h) { // boucle des lignes
				tabD.tab[j][h] = tab2D.tab[(j + 1 + i) % e.d.nbCol][h];
			}
		}
		//
		//-------------------------------------------------------------création d'un tableau décaler

		for (unsigned int i = 0; i < e.d.nbLig; ++i) { // compte le nombre de differences et les ajoute au tableau TabH
			for (unsigned int j = 0; j < e.d.nbCol; ++j) {
				if (e.d.tab[i][j] != tabD.tab[j][i]) {
					TabH.tab[i][j] += 1;
				}
			}
		}
	}
	
	for (unsigned int i = 0; i < e.d.nbLig; ++i) { // pour chaque valeurs du tableau TabH plus grande ou égale aux nombre de colonnes on augmente de 1 l'heuristique
		for (unsigned int j = 0; j < e.d.nbCol; ++j) {
			if (TabH.tab[i][j] >= e.d.nbCol) {
				h++;
			}
		}
	}

	detruire(tab2D);
	detruire(tabD);
	return h;
}

void copiEtat(Etat& e, const Etat& eout) {
	e.d.nbLig = eout.d.nbLig;
	e.d.nbCol = eout.d.nbCol;
	copieTab2D(e.d, eout.d);
	e.g = eout.g;
	e.h = eout.h;
	e.index = eout.index;
	e.movement = eout.movement;
	e.pos[0] = eout.pos[0];
	e.pos[1] = eout.pos[1];
}

unsigned int heuristique2(Etat& e) {

	unsigned int h = 0; // l'heuristique

	unsigned int* tabH; // tablkeau qui répértorie le nombre de différence par tableau final.
	tabH = new unsigned int[e.d.nbCol];
	for (unsigned int i = 0; i < e.d.nbCol; ++i) {
		tabH[i] = 0;
	}

	Tableau2D tab2D; // tableau etat finale (les lignes et les colonnes sont inversé)
	initialiser(tab2D, e.d.nbCol, e.d.nbLig); //(ligne / colonne)

	for (unsigned int i = 0; i < e.d.nbCol; ++i) { // crée d'aprés le nombres de ligne et le nombre de colonnes le premier tableau finale (avec les valeur qui se suivent)
		for (unsigned int j = 0; j < e.d.nbLig; ++j) {
			if (i == e.d.nbCol - 1 && j == e.d.nbLig - 1) {
				tab2D.tab[i][j] = 0;
			}
			else {
				tab2D.tab[i][j] = 1 + i + j * e.d.nbCol;
			}
		}
	}

	for (unsigned int i = 0; i < e.d.nbLig; ++i) {
		for (unsigned int j = 0; j < e.d.nbCol; ++j) {
			if (e.d.tab[i][j] != tab2D.tab[j][i] && e.d.tab[i][j] != 0) {
				tabH[0] += 1;
			}
		}
	}

	Tableau2D tabD; // tableau etat finale (les lignes et les colonnes sont inversé)
	initialiser(tabD, e.d.nbCol, e.d.nbLig);

	for (unsigned int i = 0; i < e.d.nbCol - 1; ++i) { // boucle de décalage a gauche

		//-------------------------------------------------------------création d'un tableau décaler
		//
		for (unsigned int j = 0; j < tabD.nbLig; ++j) { // boucle des colonnes

			for (unsigned int h = 0; h < tabD.nbCol; ++h) { // boucle des lignes
				tabD.tab[j][h] = tab2D.tab[(j + 1 + i) % e.d.nbCol][h];
			}
		}
		//
		//-------------------------------------------------------------création d'un tableau décaler

		for (unsigned int t = 0; t < e.d.nbLig; ++t) { // compte le nombre de differences et les ajoute au tableau TabH
			for (unsigned int j = 0; j < e.d.nbCol; ++j) {
				if (e.d.tab[t][j] != tabD.tab[j][t] && e.d.tab[t][j] !=0){
					tabH[i + 1] += 1;
				}
			}
		}

	}

	h = tabH[0];
	for (unsigned int i = 0; i < e.d.nbCol; ++i) {
		if (tabH[i] < h) {
			h = tabH[i];
		}
	}
	

	delete[] tabH;
	tabH = NULL;

	detruire(tab2D);
	detruire(tabD);
	return h;
}