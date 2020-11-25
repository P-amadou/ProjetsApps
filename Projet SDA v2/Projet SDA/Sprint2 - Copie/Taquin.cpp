#include <iostream>
using namespace std;

#include "Etat.h"
#include "Tab2D.h"
#include "Taquin.h"
#include "Item.h"
#include "Liste.h"

void initialiser(Taquin& t) {

	Tab2D tableau;
	Etat etat;

	unsigned int nbC = 0;
	unsigned int nbL = 0;

	cin >> nbL >> nbC;


	initialiser(tableau, nbL, nbC);
	lire(tableau);

	t.initial = tableau;
	t.nbC = nbC;
	t.nbL = nbL;
	
	initialiser(t.LEAE);
	initialiser(t.LEE);

	etat.damier = t.initial;
	etat.parent = NULL;

	inserer(t.LEAE, 0, etat);
}

void jouer(Taquin& t) {
	afficher(t);

	if (longueur(t.LEAE) > 0) {
		Etat e = lire(t.LEAE, longueur(t.LEAE) - 1);
		supprimer(t.LEAE, longueur(t.LEAE) - 1);

		inserer(t.LEE, longueur(t.LEE), e);

		unsigned int ligneX = 0;
		unsigned int ligneY = 0;

		chercherCaseNul(e.damier, ligneX, ligneY);
		
		Mouvement *mvs = mouvements_possible(ligneX, ligneY, t.nbL - 1, t.nbC - 1);
		générerFils(mvs, e, ligneX, ligneY, t);
	}
	else
	{

	}
}

Mouvement *mouvements_possible(int ligneX, int ligneY, int maxX, int maxY) {
	Mouvement *mouvPossible = new Mouvement[4];

	//NORD OUEST SUD EST

	if (ligneX == 0) {
		mouvPossible[0] = EST;
		mouvPossible[1] = SUD;
		mouvPossible[2] = OUEST;
		mouvPossible[3] = FIXE;
	}
	else if (ligneX == maxX) {
		mouvPossible[0] = EST;
		mouvPossible[1] = OUEST;
		mouvPossible[2] = NORD;
		mouvPossible[3] = FIXE;
	}
	else {
		mouvPossible[0] = EST;
		mouvPossible[1] = SUD;
		mouvPossible[2] = OUEST;
		mouvPossible[3] = NORD;
	}

	return mouvPossible;
}

void générerFils(Mouvement *tab_mouvement, Etat& e, int lignex, int ligney, Taquin& t){
	for (int i = 0; i < 4; i++) {
		if (tab_mouvement[i] != FIXE) {
			Etat nouvelEtat;
			Tab2D nDamier;
			int nX = lignex, nY = ligney;

			nouvelEtat.parent = &e;
			nouvelEtat.mouvements = tab_mouvement[i];

			initialiser(nDamier, e.damier.nbL, e.damier.nbC);

			for (int x = 0; x < nDamier.nbL; x++) {
				for (int y = 0; y < nDamier.nbC; y++) {
					nDamier.tab[x][y] = e.damier.tab[x][y];
				}
			}

			switch (tab_mouvement[i]) {
				case NORD:
					nX--;
					break;
				case EST:
					nY++;
					break;
				case SUD: 
					nX++;
					break;
				case OUEST:
					nY--;
					break;
				default:
					break;
			}


			Item tmp = nDamier.tab[lignex][ligney];
			nDamier.tab[lignex][ligney] = nDamier.tab[nX][nY];
			nDamier.tab[nX][nY] = tmp;

			nouvelEtat.damier = nDamier;

			inserer(t.LEAE, longueur(t.LEAE), nouvelEtat);
		}
	}
}

void afficher(Taquin& t) {
	cout << "*** LEE - long : " << longueur(t.LEE) << endl;
	for (int i = 0; i < longueur(t.LEE); i++) {
		afficher(lire(t.LEE, i));
	}

	cout << endl;

	cout << "*** LEAE - long : " << longueur(t.LEAE) << endl;
	for (int i = 0; i < longueur(t.LEAE); i++) {
		afficher(lire(t.LEAE, i));
	}
}