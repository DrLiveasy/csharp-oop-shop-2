using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Sacchetto_di_Frutta : Prodotto
    {
        #region Proprietà
        private int pezzi;
        private double peso;
        #endregion

        //stato
        private int MaxPezzi;
        //costruttori
        public Sacchetto_di_Frutta(string nome, string descrizione, double prezzo, double iva, double peso, int pezzi): base(nome,  descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.pezzi = PezziMaxControllo();
        }

        //Metodo Privati 
        private int PezziMaxControllo()
        {
           if(pezzi > MaxPezzi )
            {
                pezzi= MaxPezzi;
            }
           return pezzi;
        }
        

    }
}
