
# Lern-Bericht
Fabian Meyer

## Einleitung

Im Lernatelier mussten wir ein Number-Guesser Spiel programmieren.

## Was habe ich gelernt?

Ich habe Gelernt wie man einen counter , der die anzahl versuche zählt, erstellt.

## Beschreibung


Da bei jeder eingabe überprüft werden muss ob die zahl stimmt, kleiner oder grösser ist habe ich Anfangs den counter dort jeweils um 1 erhöht.

<img width="297" alt="image" src="https://user-images.githubusercontent.com/77541325/189846899-efe1c038-dc62-4050-afe7-759d8611c891.png">

Danach wird nach einem neuen Guess gefragt.
Dies wird wiederholt bis die Zahlt erraten wurde.
Da ich noch genügend Zeit übrig hatte habe ich noch eine penalty eingefügt falls man eine Zahl ausserhalb des Rahmens (1-100) eingibt.

<img width="404" alt="image" src="https://user-images.githubusercontent.com/77541325/189847332-b4d4f6b2-72f7-43ab-a068-6b6407ed5514.png">

Zuletzt soll der Guess bei dem die Zahl erraten wurde auch noch gezählt und danach die Anzahl Guesses angezeigt werden.

<img width="270" alt="image" src="https://user-images.githubusercontent.com/77541325/189847575-c1dbad1b-e999-495d-877d-eb61b496c410.png">


```c#

                if (y < 1)        //wenn ausserhalb des Rahmens
                {
                    Console.WriteLine("only numbers bigger than 0, 1 guess penalty");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine()); //neuer Guess
                    y = nutzer_input;
                    counter = counter +2; //counter und Penalty werden hinzugefügt
                }
                if (y > 100)      //wenn ausserhalb des Rahmens
                {
                    Console.WriteLine("only numbers smaller than 101, 1 guess penalty");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine()); // neuer Guess
                    y = nutzer_input;
                    counter = counter + 2;   //counter und Penalty werden hinzugefügt
                }
                if (y < x) //wenn nicht richtig
                {
                    Console.WriteLine("too small");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine()); //neuer guess
                    y = nutzer_input;
                    counter++; //Counter erhöhen
                }
                if (y > x) //wenn nicht richtig
                {
                    Console.WriteLine("too big");
                    Console.WriteLine("enter a new Number");
                    nutzer_input = Convert.ToInt32(Console.ReadLine()); // neuer Guess
                    y = nutzer_input;
                    counter++;  //counter erhöhen
                }
                if (y == x) //wenn richtig
                {
                    number_guessed = true;
                    Console.WriteLine("nummer gefunden");
                    counter++; //letzten Guess auch zählen
                    Console.WriteLine("guess count " + counter); // counter anzeigen
                }
            }
```


## Verifikation

Text: Beschreibung des Programms

Bilder: Veranschaulichung counter

Code : Veranschaulichung counter



# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

Ich habe alles schnell verstanden und war schnell fertig.
Ich war zu beginn auch sehr motiviert.

👎 und etwas, was nicht gut lief.

Da ich schnell fertig war ging die Motivation auch schnell Bergab.
daruch war auch die Projektdokumentation eher Mangelhaft.
