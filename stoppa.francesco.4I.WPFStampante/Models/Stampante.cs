using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.stampante.Models
{
    public class Stampante
    {
        //property colori
        public int C { get; set;}
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public int Fogli { get; set; }
        //Costruttore Stampante
        public Stampante() 
        { 
            C = M = Y = B = 100;
            Fogli = 200;
        }

        //Metodo stampa: torna false se l'inchiostro non è sufficente
        //viene passato come parametro: (Pagina p)
        //oppure se non ci sono pagine
    public bool Stampa(Pagina p)
    {
            if ( (Fogli > 0) &&
                 (C >= p.C) &&
                 (M >= p.M) &&
                 (Y >= p.Y) &&
                 (B >= p.B) 
                 ) {
                C -= p.C;
                M -= p.M;
                Y -= p.Y;
                B -= p.B;
                Fogli--;

                    return true;
                }
            return false;
        }
        //Metodo StatoInchiostro: questo metodo ritorna tutti i valori di tutti i colori d'inchiostro
        public int StatoInchiostro(int c, int m, int y, int b)
        {
            C = c;
            return c;

            M = m;
            return m;

            Y = y;
            return y;
            
            B = b;
            return b;

        }
        //Metodo statocarta: serve a vedere quanta carta è rimanente nella stampante
        public int Statocarta()
        {
            return Fogli;
        }
        //Metodo che va a sostituire il colore quando sono esauriti
        public void Sostituiscicolore()
        {
            if(C == 0)
            {
                C = 100;

            }else if(M == 0)
            {
                M = 100;

            }else if(Y == 0)
            {
                Y = 100;

            }else if(B == 0)
            {
                B = 100;
            }

        }
        //Metodo aggiungi carta
        //Aggiunge fogli solamente se il "cassetto" della carta è vuota (quindi il valore dato a carta è 0)
        public void Aggiungicarta(int qta)
        {
            int MAX = 200;

            if(Fogli == 0)
            {
                for (int i = 0; i < MAX; i++)
                {
                    Fogli++;
                }
            }
            
        }
            
        }
        
    }



