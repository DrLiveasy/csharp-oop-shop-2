using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{

    public class Prodotto
    {
        private string nome;
        private string descrizione;
        private int Codice;
        private double prezzo;
        private double iva;

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            Random rnd = new Random();
            this.Codice = rnd.Next(1, 100000);
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }



        //Getters 

        public string GetNome()
        {
            return this.nome;
        }
        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public int GetCodice()
        {
            return this.Codice;
        }

        public double GetIva()
        {
            return this.iva;
        }
        


        //SETTERS
        public void CambiaNome(string nome)
        {
            if (nome != "")
            {
                this.nome = nome;
            }
            else
            {
                Console.WriteLine("il nome non può essere vuoto"); ;
            }
        }
        public void CambiaDiscrezione(string descrizione)
        {
            if (descrizione != "")
            {
                this.descrizione = descrizione;
            }
            else
            {
                Console.WriteLine("non hai inserito nessuna descrizione");
            }
        }
        public void CambiaPrezzo(int prezzo)
        {
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("il Prezzo non può essere uguale o minore di 0 ");
            }
        }
        public void CambiaIva(int iva)
        {
            if (iva > 0)
            {
                this.iva = iva;
            }
            else
            {
                Console.WriteLine("l'iva inserita non può essere uguale o minore di 0 ");
            }
        }


        //Metodi pubblici
        public double PrezzoBase()
        {
            return prezzo;
        }


        public string NomeEsteso()
        {
            var concatenato = Codice + nome;

            return concatenato;
        }




        public virtual void StampaDatiProdotto()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-----------------------");
            Console.WriteLine("il Codice del prodotto è :" + GetCodice());
            Console.WriteLine("il Nome :" + GetNome());
            Console.WriteLine("Descrezione Prodotto :" + GetDescrizione());
            Console.WriteLine("il prezzo senza iva è di :" + GetPrezzo() + " €");
            Console.WriteLine($"Prezzo compreso iva è di:{CalcoloIva()} €");
            Console.WriteLine("il nome esteso è :" + NomeEsteso());
            Console.WriteLine("-----------------------");
        }

        //Metodi di Utilità

        private double CalcoloIva()
        {
            double PIva = prezzo * iva;

            double PrezzoFinale = prezzo + PIva;

            PrezzoFinale = (double)System.Math.Round(PrezzoFinale, 2);

            return PrezzoFinale;
        }

    }
}
