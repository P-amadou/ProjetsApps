#include <iostream>
using namespace std;

#include "Tableau2D.h"
#include "Etat.h"
#include "Taquin.h"

int main() {

	Taquin taquin;

	initialiser(taquin);
	jouer(taquin);

	detruire(taquin.LEAE);
	detruire(taquin.LEE);

	return 0;
}