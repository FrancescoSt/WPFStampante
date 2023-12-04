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
        //ultima modifica righe 78-90

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

        //Metodo stampa, torna false se l'inchiostro non è sufficente
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

        public int Statocarta()
        {
            return Fogli;
        }

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



