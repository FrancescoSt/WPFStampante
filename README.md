# WPFStampante
Simula le funzioni di una stampante, ovvero: stampa, controllo stato inchiostro, controllo stato carta, sostituzione del colore, aggiunta carta.
È stato creato l'UML per avere una visione completa sulle classi.

## classe "Stampante"
### atttibuti
* int C
* int M
* int Y
* int B
* int Folgi
### Costruttore
#### N.1: imposta tutti i colori e i fogli al livello massimo, 
``` c#
     public Stampante() 
        { 
            C = M = Y = B = 100;
            Fogli = 200;
        }
```
#### i valori massimi sono: per i colori 100, e per i fogli 200.

### metodi
* Stampa (bool)
* StatoInchiostro (int)
* StatoCarta()
* SostituisciColore(void)
* AggiungiCarta(void)

## Classe "Pagina"
### attributi
* int C
* int M
* int Y
* int B
* bool valido

### costruttore
#### N.1: Accetta colori specifici al massimo di valore 3
``` c#
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
```
#### N.2: crea una Pagina con colori random
``` c#
public Pagina(Random random)
        {
            this.C = random.Next(0, 4);
            this.M = random.Next(0, 4);
            this.Y = random.Next(0, 4);
            this.B = random.Next(0, 4);
        }
``` 
#### In questo costruttore viene scelto il colore e il livello del colore alla stampa, se: il valore del colore è 0, allora il colore non verrà selezionato.
