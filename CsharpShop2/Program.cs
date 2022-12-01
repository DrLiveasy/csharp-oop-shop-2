// See https://aka.ms/new-console-template for more information
using CsharpShop2;


Prodotto Carne = new Prodotto("Carne", "Carne di Mucca", 7 , 0.22);
Acqua Aqua = new Acqua("Acqua", "Acqua Naturale", 0.60, 0.22,1.5,2.2, "sant'anna");
Prodotto Banana = new Prodotto("Banana", "Banana", 0.6, 0.22);


Aqua.StampaDatiProdotto();
Aqua.litriDaBere(0.5);
Aqua.RiempieLaBottiglia(0.4);
Aqua.RiempieLaBottiglia(15);

