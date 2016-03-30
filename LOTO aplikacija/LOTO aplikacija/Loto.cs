using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTO_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }

        /// <summary>
        /// Dodaje korisničke vrijednosti u listu uplaćenih brojeva. Svaka vrijednost se
        /// prethodno provjerava i uzima u obzir samo ukoliko se radi o cjelobrojnoj
        /// vrijednosti u rasponu od 1 do 39, i ako već ne postoji ista vrijednost u listi.
        /// </summary>
        /// <param name="korisnickeVrijednosti">Vrijednosti koje je unio korisnik.<param>
        /// <returns>True ako se u listi nalazi 7 jedinstvenih brojeva u rasponu od 1 do
        /// 39, u suprotnom False.</returns>
        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);                            
                        }                      
                    }
                }
            }

            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }

            return ispravni;
        }

        /// <summary>
        /// Dodaje korisničke vrijednosti u listu uplaćenih brojeva. Svaka vrijednost se
        /// prethodno provjerava i uzima u obzir samo ukoliko se radi o cjelobrojnoj
        /// vrijednosti u rasponu od 1 do 39, i ako već ne postoji ista vrijednost u listi.
        /// </summary>
        /// <param name="korisnickeVrijednosti">Vrijednosti koje je unio korisnik.</param>
        /// <returns>True ako se u listi nalazi 7 jedinstvenih brojeva u rasponu od 1 do
        /// 39, u suprotnom False.</returns>
        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            }

            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }

            return ispravni;
        }

        /// <summary>
        /// Generira 7 nasumičnih jedinstvenih cijelih brojeva u rasponu od 1 do 39,
        /// te ih sprema u listu kao dobitnu kombinaciju brojeva.
        /// </summary>
        public void GenerirajDobitnuKombinaciju()
        {
            DobitniBrojevi.Clear();
            Random generatorBrojeva = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = generatorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }

        /// <summary>
        /// Izračunava broj pogođenih brojeva dobitne kombinacije.
        /// </summary>
        /// <returns>Broj pogođenih brojeva dobitne kombinacije.</returns>
        public int IzracunajBrojPogodaka()
        {
            int brojPogodaka = 0;

            foreach (int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }

            return brojPogodaka;
        }
    }
}
