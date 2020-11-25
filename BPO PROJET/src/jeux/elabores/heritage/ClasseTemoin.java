package jeux.elabores.heritage;

import jeuxT.elabores.heritage.InterfaceTemoin;

//Ce fichier ne doit pas être modifié.
public class ClasseTemoin {
	public void heritage() {
		System.out.println((this instanceof InterfaceTemoin ? "" : "pur ") + "héritier");
	}
}
