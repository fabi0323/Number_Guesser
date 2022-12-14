# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   muss          |  funtional      | zufallszahl gemerieren |
| 2    |   muss          | funktional      |    eingabe wird mit zufallszahl verglichen                                |
| 3    |   muss          | funktional      |    ausgabe ob zahl zu gross oder zu klein ist                                |
| 4    |   kann          | qualität        |   guess counter                                |
| 5    |   kann          | qualität        |   guess penalty                               |
✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |   programm lauft          |   start      |  zufallszahl                 |
| 2.1  |     zahl wurde generiert        |   zahl      |                   |
| 3.1  |     zahl wurde generiert        |   1. guess      |    zu gross/zu klein               |
| 4.1  |     nummer gefunden    |   enter    |    counter              |
| 5.1  |     falscher input    |   enter    |    guess penalty für inputs >10 und <1              |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

<img width="347" alt="Screenshot 2022-08-23 103330" src="https://user-images.githubusercontent.com/77541325/186111970-fb626316-bf80-4bed-88a3-1c79d762c09b.png">
✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |      ich     |     30min          |    15min               |
| 2.A  |       |      ich     |        45min       |       20min            |
| 3.A  |       |      ich     |       20min             |       25min            |
| 4.A  |       |      ich     |         10min      |         25min          |
| 5.A  |       |      ich     |          5min     |          5min         |
✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       | Funkioniert         | ich    |
| 2.1  |       | Funkioniert          | ich    |
| 3.1  |       | Funkioniert          | ich    |
| 4.1  |       | Funkioniert          | ich    |
| 5.1  |       | Funkioniert          | ich    |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.
alles funktionert wie es soll

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |       Start vom Programm       |    Buchstaben, Kommazahlen, Space,    |     Zurechtweisung             |           Error           |
| ...  |       Fertig       |     Irgendwas    |        Restart            |   Abbruch                   |
| ...  |       Im Spiel       |    korrket dann eine zu grosse Zahl     |         Zurechtweisung          |         Keine Fehlermeldung             |
| ...  |              |         |                   |                      |
| ...  |              |         |                   |                      |

elias spycher
✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
