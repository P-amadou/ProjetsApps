#include <iostream>
using namespace std;

#include "Etat.h"
#include "Tableau2D.h"
#include "Taquin.h"
#include "Item.h"
#include "Liste.h"

void initialiser(Taquin& t) {

	Tab2D tableau;
	Etat etat;

	int nbC = 0, nbL = 0;
	cin >> nbL >> nbC;
	cout << "Damier : " << nbL << " lignes, " << nbC << " colonnes" << endl;

	initialiser(tableau, nbL, nbC);
	lire(tableau);

	t.initial = tableau;
	t.nbC = nbC;
	t.nbL = nbL;

	initialiser(t.LEAE);
	initialiser(t.LEE);

	etat.damierF = t.initial;
	etat.parent = NULL;
	etat.g = 0;
	initialiserFinal(t, nbL, nbC);

	inserer(t.LEAE, 0, etat);
}

void jouer(Taquin& t) {
	bool fini = false;
	int compteur = 0;
	while(fini == false && compteur <= 100) {
		cout << "Iteration " << compteur << endl;

		afficher(t);

		if (longueur(t.LEAE) > 0) {
				
				Etat actuel = chercher(t);

				if (but(actuel, t)) {
					fini = true;
				}

				int ligneX = 0;
				int ligneY = 0;

				for (int x = 0; x < t.nbL; x++) {
					for (int y = 0; y < t.nbC; y++) {
						if (actuel.damierF.tab[x][y] == 0) {
							ligneX = x;
							ligneY = y;
							break;
						}
					}
				}

				Mouvement *mvs = mvts_possible(ligneX, ligneY, t.nbL - 1, t.nbC - 1);
				creer(mvs, actuel, ligneX, ligneY, t);
					
		}

		cout << "Fin iteration " << compteur << endl;
		cout << endl;
		cout << endl;
		compteur++;
	}

}

Mouvement *mvts_possible(int ligneX, int ligneY, int maxX, int maxY) {
	Mouvement *mvmts = new Mouvement[4];

	if (ligneX == 0) {
		mvmts[2] = EST;
		mvmts[1] = SUD;
		mvmts[0] = OUEST;
		mvmts[3] = AUCUN;
	}
	else if (ligneX == maxX) {
		mvmts[2] = EST;
		mvmts[1] = OUEST;
		mvmts[0] = NORD;
		mvmts[3] = AUCUN;
	}
	else {
		mvmts[3] = EST;
		mvmts[2] = SUD;
		mvmts[1] = OUEST;
		mvmts[0] = NORD;
	}

	return mvmts;
}

void creer(Mouvement *tab_mouvement, Etat& e, int lignex, int ligney, Taquin& t) {

	for (int i = 0; i < 4; i++) {
		if (tab_mouvement[i] != AUCUN) {
			Etat nouvelEtat;
			Tab2D nDamier;
			int nX = lignex, nY = ligney;

			nouvelEtat.parent = &e;
			nouvelEtat.mouvements = tab_mouvement[i];

			initialiser(nDamier, e.damierF.nbL, e.damierF.nbC);

			for (int x = 0; x < nDamier.nbL; x++) {
				for (int y = 0; y < nDamier.nbC; y++) {
					nDamier.tab[x][y] = e.damierF.tab[x][y];
				}
			}

			switch (tab_mouvement[i]) {
			case NORD:
				nX--;
				break;
			case EST:
				if (e.damierF.nbC - 1 == ligney) {
					nY = 0;
				}
				else {
					nY++;
				}
				break;
			case SUD:
				nX++;
				break;
			case OUEST:
				if (0 == ligney) {
					nY = e.damierF.nbC - 1;
				}
				else {
					nY--;
				}
				break;
			default:
				break;
			}


			Item tmp = nDamier.tab[lignex][ligney];
			nDamier.tab[lignex][ligney] = nDamier.tab[nX][nY];
			nDamier.tab[nX][nY] = tmp;
			nouvelEtat.damierF = nDamier;
			nouvelEtat.g = e.g + 1;
			if (appartient(nouvelEtat, t) == false) {
				inserer(t.LEAE, 0, nouvelEtat);;
			}
		}
	}
}

bool appartient(Etat& ef, Taquin& t) {

	for (unsigned int i = 0; i < longueur(t.LEE); i++)
	{
		Etat e = lire(t.LEE, i);
		if (comparer(ef.damierF, e.damierF) == true) {
			return true;
		}
	}

	for (unsigned int i = 0; i < longueur(t.LEAE); i++)
	{
		Etat e = lire(t.LEAE, i);
		if (comparer(ef.damierF, e.damierF) == true) {
			return true;
		}
	}

	return false;
} 

void initialiserFinal(Taquin& t, unsigned int nbL, unsigned int nbC) {

	t.final = new Tab2D[nbC];
	unsigned int compteur = 0;
	Tab2D tableau;

	initialiser(tableau, nbL, nbC);

	int nb = 1;

	for (unsigned int i = 0; i < nbL; i++)
	{
		for (unsigned int j = 0; j < nbC; j++)
		{
			tableau.tab[i][j] = nb++;
		}
	}

	tableau.tab[nbL - 1][nbC - 1] = 0;

	t.final[compteur] = tableau;
	compteur++;

	while (compteur < nbC)
	{
		Tab2D temporaire;
		initialiser(temporaire, nbL, nbC);
		for (unsigned int i = 0; i < nbL; i++)
		{
			for (unsigned int j = 0; j < nbC; j++)
			{
				temporaire.tab[i][j] = t.final[compteur - 1].tab[i][j];
			}
		}
		for (unsigned int i = 0; i < nbL; i++)
		{
			for (unsigned int j = 0; j < nbC - 1; j++)
			{
				temporaire.tab[i][j + 1] = t.final[compteur - 1].tab[i][j];
			}
			temporaire.tab[i][0] = t.final[compteur - 1].tab[i][nbC - 1];
		}
		t.final[compteur] = temporaire;
		compteur++;
	}

}

bool but(Etat& e, Taquin &t) {


	for (int i = 0; i < t.nbC; i++) {
		if (comparer(e.damierF, t.final[i])) {
			return true;
		}
	}

	return false;
}

void afficher(Taquin& t) {
	cout << "*** LEE - long : " << longueur(t.LEE) << endl;
	for (unsigned int i = 0; i < longueur(t.LEE); i++) {
		afficher(lire(t.LEE, i));
	}

	cout << endl;

	cout << "*** LEAE - long : " << longueur(t.LEAE) << endl;
	for (unsigned int i = 0; i < longueur(t.LEAE); i++) {
		afficher(lire(t.LEAE, i));
	}
}

Etat chercher(Taquin &t) {
	Etat minimum = lire(t.LEAE, 0);
	int index = 0;
	
	if (minimum.g == 0) {
		supprimer(t.LEAE, index);
		inserer(t.LEE, longueur(t.LEE), minimum);
		return minimum;
	}
	else {
		for (int i = 0; i < longueur(t.LEAE); i++) {
			Etat temporaire = lire(t.LEAE, i);

			if (temporaire.g < minimum.g) {
				index = i;
				minimum = temporaire;
			}
			else if (temporaire.g == minimum.g) {
				if (temporaire.g < minimum.g) {
					index = i;
					minimum = temporaire;
				}
			}
		}
	}

	supprimer(t.LEAE, index);
	inserer(t.LEE, longueur(t.LEE), minimum);


	return  minimum;
}