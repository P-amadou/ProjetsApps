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
	etat.g = 0;
	etat.h = 0;

	inserer(t.LEAE, 0, etat);
}

bool jouer(Taquin& t) {
	afficher(t);

	if (longueur(t.LEAE) > 0) {
		Etat e = min(t);

		if (but(e) == true) {
			return true;
		}

		unsigned int ligneX = 0;
		unsigned int ligneY = 0;

		chercherCaseNul(e.damier, ligneX, ligneY);
		
		Mouvement *mvs = mouvements_possible(ligneX, ligneY, t.nbL - 1, t.nbC - 1);
		générerFils(mvs, e, ligneX, ligneY, t);
	}

	return false;
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
					nX = nX - 1;
					break;
				case EST:
					if (nDamier.nbC - 1 == ligney) {
						nY = 0;
					}
					//nY++;
					break;
				case SUD: 
					nX = nX + 1;
					break;
				case OUEST:
					if (ligney == 0){
						nY = nDamier.nbC - 1;
					}
					//nY--;
					break;
				default:
					break;
			}


			Item tmp = nDamier.tab[lignex][ligney];
			nDamier.tab[lignex][ligney] = nDamier.tab[nX][nY];
			nDamier.tab[nX][nY] = tmp;

			nouvelEtat.damier = nDamier;
			nouvelEtat.g = e.g + 1;
			nouvelEtat.h = 0;

			if (existe(nouvelEtat, t) == false) {
				inserer(t.LEAE, longueur(t.LEAE), nouvelEtat);
			}
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

Etat min(Taquin &t) {
	Etat e = lire(t.LEAE, 0);
	int index = 0;

	for (int i = 0; i < longueur(t.LEAE); i++) {
		Etat tmp = lire(t.LEAE, i);
		if (index = 0) {
			index = i;
			e = tmp;
		}else if (tmp.g < e.g) {
			index = i;
			e = tmp;
		}
	}

	supprimer(t.LEAE, index);
	inserer(t.LEE, longueur(t.LEE), e);

	return e;
}

bool existe(Etat &e, Taquin &t) {
	for (int i = 0; i < longueur(t.LEE); i++) {
		if (comparer(lire(t.LEE, i).damier, e.damier) == true) {
			return true;
		}
	}

	for (int i = 0; i < longueur(t.LEAE); i++) {
		if (comparer(lire(t.LEAE, i).damier, e.damier) == true) {
			return true;
		}
	}

	return false;
}