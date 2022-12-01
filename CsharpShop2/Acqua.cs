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
        public double GetLitri()
        { 
            return litri;
        }
        public double GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }

        //Metodi Pubb
        #region METODI PUBBLICI
        public void litriDaBere(double DaBere)
        {
            if (litri >= DaBere)
            {
                this.litri -= DaBere;
                Console.WriteLine("Sono stai bevuti: "+DaBere+" L" + "\nTi mancano: "+ GetLitri() +" L"  );
            }
            else
            {
                Console.WriteLine("Mi dispaiace i litri richiesti da bere non ci sono");
            }
        }

        #endregion

    }
}
