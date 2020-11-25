#include <iostream>
#include <iomanip>
#include "Tab2D.h"
#include "Item.h"
#include "Taquin.h"
using namespace std;


int main() {
	Taquin taquin;

	initialiser(taquin);

	bool estFin = false;
	unsigned int compteur = 0;

	while(estFin == false && compteur < 100) {
		cout << "Iteration " << compteur << endl;

		if (jouer(taquin)) {
			break;
		}

		cout << "Fin iteration " << compteur << endl;
		cout << endl;
		compteur++;
	}
	detruire(taquin.LEAE);
	detruire(taquin.LEE);

	system("pause");

	return 0;
}