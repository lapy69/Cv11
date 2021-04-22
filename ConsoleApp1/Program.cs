using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            Studenti sprvni = new Studenti() { Jmeno = "Josef", Prijmeni = "Čapek", Datum_narozeni = new DateTime(2000,6,12), ID = 220881 };
            Studenti sdruhy = new Studenti() { Jmeno = "Karel", Prijmeni = "Čapek", Datum_narozeni = new DateTime(2000,3,11), ID = 220882 };
            Studenti streti = new Studenti() { Jmeno = "Jan", Prijmeni = "Novák", Datum_narozeni = new DateTime(2000, 4, 18), ID = 220883 };

            Predmety pjedna = new Predmety() { Nazev = "Objektově orientované programování", Zkratka = "OOP" };
            Predmety pdva = new Predmety() { Nazev = "Angličtina pro bakaláře", Zkratka = "AN4" };
            Predmety ptri = new Predmety() { Nazev = "Digitální obvody", Zkratka = "DIO" };

            SpojovaciTabulka st1 = new SpojovaciTabulka() { ID = sprvni.ID, Zkratka = pjedna.Zkratka };
            SpojovaciTabulka st2 = new SpojovaciTabulka() { ID = sprvni.ID, Zkratka = ptri.Zkratka };
            SpojovaciTabulka st3 = new SpojovaciTabulka() { ID = sdruhy.ID, Zkratka = pjedna.Zkratka };
            SpojovaciTabulka st4 = new SpojovaciTabulka() { ID = sdruhy.ID, Zkratka = pdva.Zkratka };
            SpojovaciTabulka st5 = new SpojovaciTabulka() { ID = streti.ID, Zkratka = pjedna.Zkratka };
            SpojovaciTabulka st6 = new SpojovaciTabulka() { ID = streti.ID, Zkratka = pdva.Zkratka };
            SpojovaciTabulka st7 = new SpojovaciTabulka() { ID = streti.ID, Zkratka = ptri.Zkratka };

            Hodnoceni h1 = new Hodnoceni() { ID = st1.ID, Zkratka = st1.Zkratka, hodnoceni1 = 1, datum_hodnoceni = new DateTime(2021, 5, 1) };
            Hodnoceni h2 = new Hodnoceni() { ID = st2.ID, Zkratka = st2.Zkratka, hodnoceni1 = 1.5, datum_hodnoceni = new DateTime(2021, 5, 1) };
            Hodnoceni h3 = new Hodnoceni() { ID = st3.ID, Zkratka = st3.Zkratka, hodnoceni1 = 1, datum_hodnoceni = new DateTime(2021, 5, 3) };
            Hodnoceni h4 = new Hodnoceni() { ID = st4.ID, Zkratka = st4.Zkratka, hodnoceni1 = 1.5, datum_hodnoceni = new DateTime(2021, 5, 3) };
            Hodnoceni h5 = new Hodnoceni() { ID = st5.ID, Zkratka = st5.Zkratka, hodnoceni1 = 2, datum_hodnoceni = new DateTime(2021, 5, 4) };
            Hodnoceni h6 = new Hodnoceni() { ID = st6.ID, Zkratka = st6.Zkratka, hodnoceni1 = 2.5, datum_hodnoceni = new DateTime(2021, 5, 4) };
            Hodnoceni h7 = new Hodnoceni() { ID = st7.ID, Zkratka = st7.Zkratka, hodnoceni1 = 1, datum_hodnoceni = new DateTime(2021, 5, 4) };

            void InsertStudents(Studenti s)
            {
                if (!db.Studenti.Any(st => st.ID == s.ID))
                {
                    db.Studenti.InsertOnSubmit(s);
                    db.SubmitChanges();
                }
            }

            void InsertPredmety(Predmety p)
            {
                if (!db.Predmety.Any(pr => pr.Zkratka == p.Zkratka))
                {
                    db.Predmety.InsertOnSubmit(p);
                    db.SubmitChanges();
                }
            }

            void InsertSpojovaciTabulka(SpojovaciTabulka st)
            {
                if (!(db.SpojovaciTabulka.Any(spt => spt.ID == st.ID) && db.SpojovaciTabulka.Any(spt => spt.Zkratka == st.Zkratka)))
                {
                    db.SpojovaciTabulka.InsertOnSubmit(st);
                    db.SubmitChanges();
                }
            }

            void InsertHodnoceni(Hodnoceni h)
            {
                if (!(db.Hodnoceni.Any(ho => ho.ID == h.ID) && db.Hodnoceni.Any(ho => ho.Zkratka == h.Zkratka)))
                {
                    db.Hodnoceni.InsertOnSubmit(h);
                    db.SubmitChanges();
                }
            }



            InsertStudents(sprvni);
            InsertStudents(sdruhy);
            InsertStudents(streti);

            InsertPredmety(pjedna);
            InsertPredmety(pdva);
            InsertPredmety(ptri);

            InsertSpojovaciTabulka(st1);
            InsertSpojovaciTabulka(st2);
            InsertSpojovaciTabulka(st3);
            InsertSpojovaciTabulka(st4);
            InsertSpojovaciTabulka(st5);
            InsertSpojovaciTabulka(st6);
            InsertSpojovaciTabulka(st7);

            InsertHodnoceni(h1);
            InsertHodnoceni(h2);
            InsertHodnoceni(h3);
            InsertHodnoceni(h4);
            InsertHodnoceni(h5);
            InsertHodnoceni(h6);
            InsertHodnoceni(h7);



            IEnumerable<Studenti> StudentiPredmetu(Predmety pr)
            {
                IEnumerable<Studenti> temp = new List<Studenti>();
                var radky = from s in db.SpojovaciTabulka where s.Zkratka == pr.Zkratka select s.Studenti;
                foreach (var aktualniRadek in radky)
                {
                    temp.Append(aktualniRadek);
                }
                return temp;
            }

            IEnumerable<Predmety> PredmetyStudenta(Studenti st)
            {
                IEnumerable<Predmety> temp = new List<Predmety>();
                var radky = from s in db.SpojovaciTabulka where s.ID == st.ID select s.Predmety;
                foreach(var aktualniRadek in radky)
                {
                    temp.Append(aktualniRadek);
                }
                return temp;
            }

            StudentiPredmetu(pjedna);
            StudentiPredmetu(pdva);
            StudentiPredmetu(ptri);

            PredmetyStudenta(sprvni);
            PredmetyStudenta(sdruhy);
            PredmetyStudenta(streti);
        }
    }
}
