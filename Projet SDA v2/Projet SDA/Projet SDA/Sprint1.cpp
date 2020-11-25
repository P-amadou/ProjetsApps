#include <iostream>
#include <iomanip>
#include "Tab2D.h"
#include "Item.h"
#include <cstdio> 
#include <cstdlib> 
using namespace std;


int main() {
	Tab2D taquin;
	int nbC, nbL;
	cin >> nbL >> nbC;
	cout << "Damier : " << nbL << " lignes, " << nbC << " colonnes" << endl;

	initialiser(taquin, nbL, nbC);
	lire(taquin);
	afficher(taquin);
	detruire(taquin);

	system("pause");
	return 0;
}