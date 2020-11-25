/**
*@fde main.cpp
*@author Vadim Goldaniga
*@version 14/12/2018
*@brief fichier main
*/

#include <iostream>
#include "Tableau2D.h"
#include "Item1.h"
#include "Taquin.h"
#include "Etat.h"

#define VerifIterations 100

using namespace std;

int main() {
	Taquin t;
	initialiser_taquin(t);

	
	system("pause>nul");
	cout << "Damier : " << t.nbL << " lignes, " << t.nbC << " colonnes" << endl;
		jouer(t);

	detruire((Liste&)t.LEE);
	detruire((Liste&)t.LEAE);
	
	system("pause>nul");
}