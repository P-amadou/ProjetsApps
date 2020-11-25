/**
*@fde Taquin.cpp
*@author Vadim Goldaniga
*@version 14/12/2018
*@brief fonction de Taquin.h
*/

#include <iostream>
#include "Taquin.h"
#include "Tableau2D.h"
#include "Liste.h"

using namespace std;

void initialiser_taquin(Taquin& t) {

	initialiser_liste((Liste&)t.LEAE);
	initialiser_liste((Liste&)t.LEE);

	Etat e;
	initialiser(e);
	ecrire((Liste&)t.LEAE, t.LEAE.nb, e);

	t.nbC = t.LEAE.c.tab[0].d.nbCol;
	t.nbL = t.LEAE.c.tab[0].d.nbLig;
	t.iteration = 0;
}

void afficher(const Taquin& t) {
	cout << "Iteration " << t.iteration << endl;
	
		cout << "*** LEAE - long : " << t.LEAE.nb << endl;
		//for (unsigned int i = gMax; i > 0 ; --i)
		//{
		for (int j = 0; j < t.LEAE.nb; ++j) {
			//if (t.LEAE.c.tab[j].g == i) {
			afficher(t.LEAE.c.tab[j]);
			//}
		}
		
		//}

		cout << "Fin iteration " << t.iteration << endl;

	cout << endl;
	cout << endl;
	//}
}

bool appartient(const Etat& ef, Taquin& t) {
	for (unsigned int i = 0; i < t.LEE.nb; ++i) {
		if (compareTab(ef.d, t.LEE.c.tab[i].d) == true) {
			return true;
		}
	}
	for (unsigned int i = 0; i < t.LEAE.nb; ++i) {
		if (compareTab(ef.d, t.LEAE.c.tab[i].d) == true) {
			return true;
		}
	}
	return false;
}

bool jouet(Taquin& t) {

	//for (unsigned int i = 0; i < VerifIterations; ++i) {

	if (t.iteration != 0) {
		unsigned int index = 0;
		unsigned int heuristique = t.LEAE.c.tab[0].g + t.LEAE.c.tab[0].h;
		for (unsigned int j = 0; j < t.LEAE.nb; ++j) {
			if (t.LEAE.c.tab[j].g + t.LEAE.c.tab[j].h < heuristique) {
				index = j;
			}
		}
		ecrire(t.LEE, t.LEE.nb, t.LEAE.c.tab[index]);
		supprimer((Liste&)t.LEAE, index);
	}
	else {
		ecrire(t.LEE, t.LEE.nb, t.LEAE.c.tab[0]);
		supprimer((Liste&)t.LEAE, 0);
	}

	if (t.LEE.c.tab[t.iteration].pos[0] - 1 >= 0 && t.LEE.c.tab[t.iteration].pos[0] - 1 < t.nbL) { // on teste si le hashtag peut aller au Nord
		Etat e1;

		e1.index = t.iteration; // on indique l'index du précédent damier

		e1.g = t.LEE.c.tab[e1.index].g + 1; // augmente le nombre de coup de 1

		e1.movement = NORD; // on met son mouvement a NORD

		initialiser(e1.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

		

		copieTab2D(e1.d, t.LEE.c.tab[e1.index].d);
		//e1.d.tab = t.LEE.c.tab[e1.index].d.tab; // on copie le tableau en deux dimension de son damier père

		e1.pos[0] = t.LEE.c.tab[e1.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
		e1.pos[1] = t.LEE.c.tab[e1.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

		//--------------------------------------------------------------------------- changement de place du zero
		e1.d.tab[e1.pos[0]][e1.pos[1]] = e1.d.tab[e1.pos[0] - 1][e1.pos[1]]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
		e1.d.tab[e1.pos[0] - 1][e1.pos[1]] = 0; // on place le zero a la bonne place

		//e1.pos[0] = t.LEE.c.tab[e1.index].pos[0] - 1; e1.pos[1] = t.LEE.c.tab[e1.index].pos[1]; // on change la position du zero (hashtag)
		emplacement_zero(e1.d, e1.pos);
		//--------------------------------------------------------------------------- changement de place du zero
		e1.h = heuristique(e1); // ... pas dans sprint 2
		//if (i != 0) {
		if (appartient(e1, t) == false) {
			inserer((Liste&)t.LEAE, 0, e1);
		}
		//}
		/*else {
			if (appartient(e1, t) == false) {
				ecrire((Liste&)t.LEAE, t.LEAE.nb, e1);
			}
		}*/
	}

	//ouest
	Etat e2;

	e2.index = t.iteration; // on indique l'index du précédent damier

	e2.g = t.LEE.c.tab[e2.index].g + 1; // augmente le nombre de coup de 1

	e2.movement = OUEST; // on met son mouvement a OUEST

	initialiser(e2.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

	copieTab2D(e2.d, t.LEE.c.tab[e2.index].d);
	//e2.d.tab = t.LEE.c.tab[e2.index].d.tab; // on copie le tableau en deux dimension de son damier père

	e2.pos[0] = t.LEE.c.tab[e2.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
	e2.pos[1] = t.LEE.c.tab[e2.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

	//--------------------------------------------------------------------------- changement de place du zero
	if (e2.pos[1] == 0) {
		e2.d.tab[e2.pos[0]][e2.pos[1]] = e2.d.tab[e2.pos[0]][e2.pos[1] + (t.nbC - 1)];
		e2.d.tab[e2.pos[0]][e2.pos[1] + (t.nbC - 1)] = 0;

		//e2.pos[0] = t.LEE.c.tab[e2.index].pos[0]; e2.pos[1] = t.LEE.c.tab[e2.index].pos[1] + (t.nbC - 1);
		emplacement_zero(e2.d, e2.pos);
	}
	else {
		e2.d.tab[e2.pos[0]][e2.pos[1]] = e2.d.tab[e2.pos[0]][e2.pos[1] - 1]; // on copie le nombre du tableau2D ou le hashtag doit se placer, sur la place du zero
		e2.d.tab[e2.pos[0]][e2.pos[1] - 1] = 0; // on place le zero a la bonne place

		//e2.pos[0] = t.LEE.c.tab[e2.index].pos[0]; e2.pos[1] = t.LEE.c.tab[e2.index].pos[1] - 1; // on change la position du zero (hashtag)
		emplacement_zero(e2.d, e2.pos);
	}
	//--------------------------------------------------------------------------- changement de place du zero
	e2.h = heuristique(e2); // ... pas dans sprint 2
	//if (i != 0) {
	if (appartient(e2, t) == false) {
		inserer((Liste&)t.LEAE, 0, e2);
	}
	//}
	/*else {
		if (appartient(e2, t) == false) {
			ecrire((Liste&)t.LEAE, t.LEAE.nb, e2);
		}
	}*/

	if (t.LEE.c.tab[t.iteration].pos[0] + 1 < t.nbL && t.LEE.c.tab[t.iteration].pos[0] + 1 >= 0) { // on teste si le hashtag peut aller au Sud
		Etat e3;

		e3.index = t.iteration; // on indique l'index du précédent damier

		e3.g = t.LEE.c.tab[e3.index].g + 1; // augmente le nombre de coup de 1
		
		e3.movement = SUD; // on met son mouvement a SUD

		initialiser(e3.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

		

		copieTab2D(e3.d, t.LEE.c.tab[e3.index].d);
		//e3.d.tab = t.LEE.c.tab[e3.index].d.tab; // on copie le tableau en deux dimension de son damier père

		e3.pos[0] = t.LEE.c.tab[e3.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
		e3.pos[1] = t.LEE.c.tab[e3.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

		//--------------------------------------------------------------------------- changement de place du zero
		e3.d.tab[e3.pos[0]][e3.pos[1]] = e3.d.tab[e3.pos[0] + 1][e3.pos[1]]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
		e3.d.tab[e3.pos[0] + 1][e3.pos[1]] = 0; // on place le zero a la bonne place

		//e3.pos[0] = t.LEE.c.tab[e3.index].pos[0] + 1; e3.pos[1] = t.LEE.c.tab[e3.index].pos[1]; // on change la position du zero (hashtag)
		emplacement_zero(e3.d, e3.pos);
		//--------------------------------------------------------------------------- changement de place du zero
		e3.h = heuristique(e3); // ... pas dans sprint 2
		//if (i != 0) {
		if (appartient(e3, t) == false) {
			inserer((Liste&)t.LEAE, 0, e3);
		}
		/*}
		else {
			if (appartient(e3, t) == false) {
				ecrire((Liste&)t.LEAE, t.LEAE.nb, e3);
			}
		}*/
	}
	// est
	Etat e4;

	e4.index = t.iteration; // on indique l'index du précédent damier

	e4.g = t.LEE.c.tab[e4.index].g + 1; // augmente le nombre de coup de 1

	e4.movement = EST; // on met son mouvement a EST

	initialiser(e4.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

	

	copieTab2D(e4.d, t.LEE.c.tab[e4.index].d);

	//e4.d.tab = t.LEE.c.tab[e4.index].d.tab; // on copie le tableau en deux dimension de son damier père

	e4.pos[0] = t.LEE.c.tab[e4.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
	e4.pos[1] = t.LEE.c.tab[e4.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père
	//--------------------------------------------------------------------------- changement de place du zero
	if (e4.pos[1] == t.nbC - 1) {
		e4.d.tab[e4.pos[0]][e4.pos[1]] = e4.d.tab[e4.pos[0]][e4.pos[1] - (t.nbC - 1)];
		e4.d.tab[e4.pos[0]][e4.pos[1] - (t.nbC - 1)] = 0;

		//e4.pos[0] = t.LEE.c.tab[e4.index].pos[0]; e4.pos[1] = t.LEE.c.tab[e4.index].pos[1] - (t.nbC - 1);
		emplacement_zero(e4.d, e4.pos);
	}
	else {
		e4.d.tab[e4.pos[0]][e4.pos[1]] = e4.d.tab[e4.pos[0]][e4.pos[1] + 1]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
		e4.d.tab[e4.pos[0]][e4.pos[1] + 1] = 0; // on place le zero a la bonne place

		//e4.pos[0] = t.LEE.c.tab[e4.index].pos[0]; e4.pos[1] = t.LEE.c.tab[e4.index].pos[1] + 1; // on change la position du zero (hashtag)
		emplacement_zero(e4.d, e4.pos);
	}
	//--------------------------------------------------------------------------- changement de place du zero
	e4.h = heuristique(e4); // ... pas dans sprint 2
	//if (i != 0) {
	if (appartient(e4, t) == false) {
		inserer((Liste&)t.LEAE, 0, e4);
	}
	//}
	/*else {
		if (appartient(e4, t) == false) {
			ecrire((Liste&)t.LEAE, t.LEAE.nb, e4);
		}
	}*/



	t.iteration++;
	for (unsigned int j = 0; j < t.LEAE.nb; ++j) {
		if (but(t.LEAE.c.tab[j]) == true) {
			return true;
		}
	}
	//}
	return false;
}

void jouer(Taquin& t) {
	bool solutionTrouve = false;
	while (t.LEAE.nb != 0) {
		/*if (gminim((Liste&)t.LEAE) == true) {
		*/	t.LEAE.eCourant = indexminim((Liste&)t.LEAE);
		//}
		/*else if (jeudilejour((Liste&)t.LEAE) == true) {
				t.LEAE.eCourant = vendredilejour((Liste&)t.LEAE);
		}
		else {
			t.LEAE.eCourant = plusrecentindex((Liste&)t.LEAE);
		}*/



		if (but(t.LEAE.c.tab[t.LEAE.eCourant]) == true) {
			solutionTrouve = true;
			break;
		}
		else {
			inserer(t.LEE, t.LEE.nb, t.LEAE.c.tab[t.LEAE.eCourant]);
			supprimer(t.LEAE, t.LEAE.eCourant);

			if (t.LEE.c.tab[t.LEE.nb - 1].pos[0] - 1 >= 0 && t.LEE.c.tab[t.LEE.nb - 1].pos[0] - 1 < t.nbL) { // on teste si le hashtag peut aller au Nord
				Etat e1;

				e1.index = t.LEE.nb - 1; // on indique l'index du précédent damier

				e1.g = t.LEE.c.tab[e1.index].g + 1; // augmente le nombre de coup de 1

				e1.movement = NORD; // on met son mouvement a NORD

				initialiser(e1.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

				copieTab2D(e1.d, t.LEE.c.tab[e1.index].d);
				//e1.d.tab = t.LEE.c.tab[e1.index].d.tab; // on copie le tableau en deux dimension de son damier père

				e1.pos[0] = t.LEE.c.tab[e1.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
				e1.pos[1] = t.LEE.c.tab[e1.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

				//--------------------------------------------------------------------------- changement de place du zero
				e1.d.tab[e1.pos[0]][e1.pos[1]] = e1.d.tab[e1.pos[0] - 1][e1.pos[1]]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
				e1.d.tab[e1.pos[0] - 1][e1.pos[1]] = 0; // on place le zero a la bonne place

				//e1.pos[0] = t.LEE.c.tab[e1.index].pos[0] - 1; e1.pos[1] = t.LEE.c.tab[e1.index].pos[1]; // on change la position du zero (hashtag)
				emplacement_zero(e1.d, e1.pos);
				//--------------------------------------------------------------------------- changement de place du zero
				e1.h = heuristique2(e1); // ... pas dans sprint 2
				if (appartient(e1, t) == false) {
					inserer((Liste&)t.LEAE, 0, e1);
				}
			}

			//ouest
			Etat e2;

			e2.index = t.LEE.nb - 1; // on indique l'index du précédent damier

			e2.g = t.LEE.c.tab[e2.index].g + 1; // augmente le nombre de coup de 1

			e2.movement = OUEST; // on met son mouvement a OUEST

			initialiser(e2.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

			copieTab2D(e2.d, t.LEE.c.tab[e2.index].d);
			//e2.d.tab = t.LEE.c.tab[e2.index].d.tab; // on copie le tableau en deux dimension de son damier père

			e2.pos[0] = t.LEE.c.tab[e2.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
			e2.pos[1] = t.LEE.c.tab[e2.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

			//--------------------------------------------------------------------------- changement de place du zero
			if (e2.pos[1] == 0) {
				e2.d.tab[e2.pos[0]][e2.pos[1]] = e2.d.tab[e2.pos[0]][e2.pos[1] + (t.nbC - 1)];
				e2.d.tab[e2.pos[0]][e2.pos[1] + (t.nbC - 1)] = 0;

				//e2.pos[0] = t.LEE.c.tab[e2.index].pos[0]; e2.pos[1] = t.LEE.c.tab[e2.index].pos[1] + (t.nbC - 1);
				emplacement_zero(e2.d, e2.pos);
			}
			else {
				e2.d.tab[e2.pos[0]][e2.pos[1]] = e2.d.tab[e2.pos[0]][e2.pos[1] - 1]; // on copie le nombre du tableau2D ou le hashtag doit se placer, sur la place du zero
				e2.d.tab[e2.pos[0]][e2.pos[1] - 1] = 0; // on place le zero a la bonne place

				//e2.pos[0] = t.LEE.c.tab[e2.index].pos[0]; e2.pos[1] = t.LEE.c.tab[e2.index].pos[1] - 1; // on change la position du zero (hashtag)
				emplacement_zero(e2.d, e2.pos);
			}
			//--------------------------------------------------------------------------- changement de place du zero
			e2.h = heuristique2(e2); // ... pas dans sprint 2
			if (appartient(e2, t) == false) {
				inserer((Liste&)t.LEAE, 0, e2);
			}

			if (t.LEE.c.tab[t.LEE.nb - 1].pos[0] + 1 < t.nbL && t.LEE.c.tab[t.LEE.nb - 1].pos[0] + 1 >= 0) { // on teste si le hashtag peut aller au Sud
				Etat e3;

				e3.index = t.LEE.nb - 1; // on indique l'index du précédent damier

				e3.g = t.LEE.c.tab[e3.index].g + 1; // augmente le nombre de coup de 1

				e3.movement = SUD; // on met son mouvement a SUD

				initialiser(e3.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

				copieTab2D(e3.d, t.LEE.c.tab[e3.index].d);
				//e3.d.tab = t.LEE.c.tab[e3.index].d.tab; // on copie le tableau en deux dimension de son damier père

				e3.pos[0] = t.LEE.c.tab[e3.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
				e3.pos[1] = t.LEE.c.tab[e3.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père

				//--------------------------------------------------------------------------- changement de place du zero
				e3.d.tab[e3.pos[0]][e3.pos[1]] = e3.d.tab[e3.pos[0] + 1][e3.pos[1]]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
				e3.d.tab[e3.pos[0] + 1][e3.pos[1]] = 0; // on place le zero a la bonne place

				//e3.pos[0] = t.LEE.c.tab[e3.index].pos[0] + 1; e3.pos[1] = t.LEE.c.tab[e3.index].pos[1]; // on change la position du zero (hashtag)
				emplacement_zero(e3.d, e3.pos);
				//--------------------------------------------------------------------------- changement de place du zero
				e3.h = heuristique2(e3); // ... pas dans sprint 2
				if (appartient(e3, t) == false) {
					inserer((Liste&)t.LEAE, 0, e3);
				}
			}
			// est
			Etat e4;

			e4.index = t.LEE.nb - 1; // on indique l'index du précédent damier

			e4.g = t.LEE.c.tab[e4.index].g + 1; // augmente le nombre de coup de 1

			e4.movement = EST; // on met son mouvement a EST

			initialiser(e4.d, t.nbL, t.nbC); // on alloue de la mémoire pour son tableau

			copieTab2D(e4.d, t.LEE.c.tab[e4.index].d);

			e4.pos[0] = t.LEE.c.tab[e4.index].pos[0];// on copie la ligne du zero(hashtag) de son damier père
			e4.pos[1] = t.LEE.c.tab[e4.index].pos[1]; // on copie la colonne du zero(hashtag) de son damier père
			//--------------------------------------------------------------------------- changement de place du zero
			if (e4.pos[1] == t.nbC - 1) {
				e4.d.tab[e4.pos[0]][e4.pos[1]] = e4.d.tab[e4.pos[0]][e4.pos[1] - (t.nbC - 1)];
				e4.d.tab[e4.pos[0]][e4.pos[1] - (t.nbC - 1)] = 0;


				emplacement_zero(e4.d, e4.pos);
			}
			else {
				e4.d.tab[e4.pos[0]][e4.pos[1]] = e4.d.tab[e4.pos[0]][e4.pos[1] + 1]; // on copie le nombre du tableau2D ou le hashtag doit se placer sur la place du zero
				e4.d.tab[e4.pos[0]][e4.pos[1] + 1] = 0; // on place le zero a la bonne place

				emplacement_zero(e4.d, e4.pos);
			}
			//--------------------------------------------------------------------------- changement de place du zero
			e4.h = heuristique2(e4); // ... pas dans sprint 2
			if (appartient(e4, t) == false) {
				inserer((Liste&)t.LEAE, 0, e4);
			}
			afficher(t);
		}
		t.iteration++;
	}

	if (solutionTrouve == true) {
		afficher(t);
	}
	else {
		afficher(t);
		cout << "afficher qu’il n’y a pas de solution au taquin" << endl;
		system("pause");
	}
}

void end(Taquin& t) {
	for (unsigned int i = 0; i < t.LEAE.nb; ++i) {
		if (but(t.LEAE.c.tab[i]) == true) {
			Etat tabl;
			initialiser(tabl.d, t.nbL, t.nbC);
			copiEtat(tabl, t.LEE.c.tab[t.LEAE.c.tab[i].index]);
			Liste fin;
			initialiser_liste(fin);
			inserer(fin, 0, t.LEAE.c.tab[i]);
			unsigned int g = t.LEAE.c.tab[i].g;
			for (unsigned int j = 0; j < g; ++j) {
				inserer(fin, 0, tabl);
				copiEtat(tabl, t.LEE.c.tab[tabl.index]);
			}
			cout << "Solution en " << g << " mouvements" << endl;
			for (unsigned int h = 0; h < fin.nb; ++h) {
				afficher(fin.c.tab[h]);
			}
			detruire(tabl);
			//detruire(fin);
			return;
		}
	}
}