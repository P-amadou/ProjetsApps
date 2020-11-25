/**
*@fde Liste.cpp
*@author Vadim Goldaniga
*@version 20/12/2018
*@brief composant de liste
*/
#include <iostream>
#include "Etat.h"
#include "Liste.h"
#include <assert.h>


void initialiser_liste(Liste& l) {
	initialiser(l.c);
	l.nb = 0;
	l.eCourant = 0;
}

void detruire(Liste& l) {
	for (unsigned int i = 0; i < l.nb; ++i) {
		detruire(l.c.tab[i]);
	}
	detruire(l.c);
}

unsigned int longueur(const Liste& l) {
	return l.nb;
}

Etat lire(Liste& l, unsigned int i) {
	assert((i >= 0) && (i < longueur(l)));
	return lire(l.c, i);
}

void ecrire(Liste& l, unsigned int i, const Etat& it) {
	assert((i >= 0) && (i <= longueur(l)));
	ecrire(l.c, i, it);
	l.nb++;
}

void inserer(Liste& l, unsigned int pos, const Etat& it) {
	assert((pos >= 0) && (pos <= longueur(l)));
	for (unsigned int i = l.nb; i > pos; i--) {
		ecrire(l.c, i, lire(l.c, i - 1));
	}
	ecrire(l.c, pos, it);
	l.nb++;
}

void supprimer(Liste& l, unsigned int pos) {
	assert((l.nb != 0) && (pos >= 0) && (pos < longueur(l)));
	if (l.nb == 1) {
		l.nb--;
	}
	else {
		for (unsigned int i = pos; i < l.nb; ++i)
			ecrire(l.c, i, lire(l.c, i + 1));
		l.nb--;
	}
}

bool gminim(Liste& l) {
	unsigned int nb = 0, g = l.c.tab[0].g;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g == g) {
			nb++;
		}
		if (l.c.tab[i].g < g) {
			g = l.c.tab[i].g;
			nb = 1;
		}
		
	}
	if (nb == 1) {
		return true;
	}
	else {
		return false;
	}
}

unsigned int indexminim(Liste& l) {
	unsigned int f = l.c.tab[0].g+ l.c.tab[0].h, index = 0;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if ((l.c.tab[i].g + l.c.tab[i].h) < f) {
			f = l.c.tab[i].g+ l.c.tab[i].h;
			index = i;
		}
	}
	return index;
}

bool ettuni(Liste& l) {
	unsigned int gmin = l.c.tab[0].g, nb = 0;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g < gmin) {
			gmin = l.c.tab[i].g;
		}
	}
	unsigned int h = l.c.tab[0].h;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g == gmin) {
			if (l.c.tab[i].h == h) {
				nb++;
			}
			if (l.c.tab[i].h < h) {
				h = l.c.tab[i].h;
				nb = 1;
			}
		}
	}
	if (nb == 1) {
		return true;
	}
	else {
		return false;
	}
}

unsigned int indexhmin(Liste& l) {
	unsigned int gmin = l.c.tab[0].g;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g < gmin) {
			gmin = l.c.tab[i].g;
		}
	}
	unsigned int h = l.c.tab[0].h, index = 0;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g == gmin) {
			if (l.c.tab[i].h == h) {
				index = i;
			}
			if (l.c.tab[i].h < h) {
				h = l.c.tab[i].h;
				index = i;
			}
		}
	}
	return index;
}

unsigned int plusrecentindex(Liste& l) {
	unsigned int gmin = l.c.tab[0].g;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g < gmin) {
			gmin = l.c.tab[i].g;
		}
	}
	unsigned int hmin = l.c.tab[0].h, nb = 0;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g == gmin) {
			if (l.c.tab[i].g == gmin && nb == 0) {
				hmin = l.c.tab[i].h;
				nb++;
			}
			if (l.c.tab[i].h < hmin) {
				hmin = l.c.tab[i].h;
			}
		}
	}
	unsigned int index = 0;
	for (unsigned int i = 0; i < l.nb; ++i) {
		if (l.c.tab[i].g == gmin && l.c.tab[i].h == hmin) {
			index = i;
			return index;
		}
	}
	return index;
}