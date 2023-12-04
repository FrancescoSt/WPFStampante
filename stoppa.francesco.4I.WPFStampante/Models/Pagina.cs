using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoppa.francesco._4I.stampante.Models
{
    public class Pagina
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public bool valido = true;

        // Crea una pagina con colori specificati dal chiamante
        public Pagina(int c, int m, int y, int b)
        {
            // Imposta i valori dei colori specificati dal chiamante
            this.C = c;
            this.M = m;
            this.Y = y;
            this.B = b;

            // Controlla che i valori dei colori siano validi
            
            if (c < 0 || c > 3)
            {
                valido = false;
            }

            if (m < 0 || m > 3)
            {
                valido = false;
            }

            if (y < 0 || y > 3)
            {
                valido = false;
            }

            if (b < 0 || b > 3)
            {
                valido = false;
            }
            
        }

        // Crea una pagina con colori casuali
        public Pagina(Random random)
        {
            this.C = random.Next(0, 4);
            this.M = random.Next(0, 4);
            this.Y = random.Next(0, 4);
            this.B = random.Next(0, 4);
        }
    }
}
