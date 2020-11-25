#include <iostream>
#include <iomanip>
#include "Tab2D.h"
#include "Item.h"
using namespace std;


int main() {
	Tab2D taquin;
	int nbC, nbL;
	cin >> nbL >> nbC;

	initialiser(taquin, nbL, nbC);
	lire(taquin);
	cout << "Damier : " << nbL << " lignes, " << nbC << " colonnes" << endl;
	afficher(taquin);
	detruire(taquin);



	system("pause");
	return 0;
}