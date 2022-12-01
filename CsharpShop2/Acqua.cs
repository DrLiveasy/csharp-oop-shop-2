using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Acqua : Prodotto
    {

        #region Proprietà
        private double litri;
        private double ph;
        private string sorgente;
        #endregion



        //Costruttori
        public Acqua(string nome, string descrizione, double prezzo, double iva, double litri, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            this.sorgente = sorgente;
            this.litri = litri;
            this.ph = ph;
        }
        //Getters

    }
}
