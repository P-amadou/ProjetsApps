#include <iostream>
#include <iomanip>
#include "Tab2D.h"
#include "Item.h"
#include "Taquin.h"
using namespace std;


int main() {
	Taquin taquin;

	initialiser(taquin);

	for (int compteur = 0; compteur < 2; compteur++) {
		cout << "Iteration " << compteur << endl;

		jouer(taquin);

		cout << "Fin iteration " << compteur << endl;
		cout << endl;
	}
	detruire(taquin.LEAE);
	detruire(taquin.LEE);

	system("pause");

	return 0;
}