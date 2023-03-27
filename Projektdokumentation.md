# Projekt-Dokumentation

Gruppe Lupin
Willi, Pinto, Oestrich, Mitrovic

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 21.02.2023 | 0.0.1   | Thema ausgewählt und 1.1-1.4 angefangen                                     |
| 28.02.2023 | 0.0.2   | Userstorys Testfälle und Planung/Realisierung: Pfadextraktion und Recherche |
| 7.03.2023  | 0.0.3   | Realisierung der Arbeitspakete Bearbeitung Kapitel 4                        |
| 14.03.2023 | 0.0.4   | Realisierung der Arbeitspakete, Korrektur/Aufarbeitung Projektdokumentation | 


## 1 Informieren

### 1.1 Ihr Projekt

Wir programmieren eine Windows-Schnitzeljagd.

Beim ausführen des Projekts wird zufällig eine Datei im System generiert, die man suchen muss. Dazu wird beim Starten eine Textdatei auf dem Desktop generiert, die gewisse Hinweise liefert. Beim Finden der gesuchten Datei werden die Zeit und Punkte ausgegeben. Dabei erhoffen wir uns mehr über Dateipfade und über Windows zu lernen und unser Wissen zu vertiefen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |Funktional| Als User möchte ich, dass eine Datei auf dem Desktop erstellt wird, damit man einen Hinweis für die versteckte Datei hat .|
| 2    | Muss            |Funktional| Als User möchte ich, dass es Hinweise zur 2. Datei gibt, damit das Finden der Datei eimfacher ist.|
| 3    | Muss            |Funktional| Als User möchte ich, dass eine 2. Datei auf dem Computer sicher versteckt wird, damit man das Spiel spielen kann und die Datei suchen kann .| 
| 4    | Muss            |Funktional| Als User möchte ich, dass die Zeit beim Öffnen der 1. Datei gestartet wird, damit man die Zeit tracken kann. |
| 5    | Kann            |Optional | Als Programmierer möchte ich, dass die Datei nicht immer am selben Ort versteckt wird, damit das Spiel nicht langweilig und zu einfach wird.|
| 6    | Muss            |Funktional| Als User möchte ich, dass es für die besseren Zeiten mehr Punkte gibt, damit man sieht ob man sich verbessert.|
| 7    | Muss            |Funktional| Als User möchte ich, dass die Zeit gestoppt wird, wenn die Datei gefunden und geöffnet wird, damit das Tracken der Zeit möglich ist.|
| 8    | Muss            |Funktional| Als User möchte ich, dass mir die Zeit und die Punktezahl angezeigt wird, damit man seine Zeit und Punktezahl anschauen kann.| 
| 9    | Kann            |Optional| Als User möchte ich, dass mir Angezeigt wird, wie viele Dateien ich während der Schnitzeljagd geöffnet habe, damit ich weitere Informationen für meine Verbesserung habe.|
| 10   | Muss           |Funktional| Als User möchte ich, dass das Programm Fehler abfängt, damit das Programm nicht abstürzt.|
| 11|  Muss             |Funktional| Als User möchte ich, das man das Programm nicht zweimal nacheinander ausführen kann, damit man einen Datensalat auf dem Computer verhindert.|
| 12  | Muss            |Funktional| Als User möchte ich, wenn man die Datei nicht findet eine Möglichkeit besteht, die Datei zu lokalisieren, damit man das Spiel auch beim Nicht-finden der Datei beenden kann.|
| 13  | Muss            | Funktional| Als User möchte ich, dass die Datei nicht in Windows veränderte Ordner generiet wird, damit man dem Computer keinen Schaden zufügt.|
| 14 | Kann             | Optional| Als User möchte ich, dass beim Starten des Spiels eine Anleitung zu finden ist, damit ein Spieler versteht was zu tun ist.|
|15 | Kann              | Rand| Als User möchte ich, dass das Spiel eine Winformsapplikation ist.| 

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm vorhanden | Programm starten| Datei erscheint auf Desktop|
| 2.1  |Datei wurde erstellt | **Keine Eingabe** | Die Datei ist an einem Ort versteckt...|
| 3.1  | Programm vorhanden| Programm starten| Die Datei wurde versteckt|
| 4.1  | Datei wurde erstellt/ Spiel gestartet|**Keine Eingabe**  | Timer startet| 
| 4.2  |Datei wurde erstellt/ Spiel gestartet|**Keine Eingabe**  | Timer beginnt bei 0|
| 5.1  | Spiel einaml gespielt und Datei gefunden| Spiel erneut starten| Datei befindet sich nicht am selben Ort|
| 6.1  | Datei gefunden| Datei öffnen| Zeit xx:xx Punkte yyy|
| 6.2  | Datei gefunden| Datei öffnen| Zeit aa:aa Punkte cc|
| 6.3  | Datei gefunden| Datei öffnen| Zeit qq:qq Punkte z| 
| 7.1  | Datei gefunden| Datei öffnen| Zeit stoppt|  
| 8.1  |Datei gefunden| Datei öffnen| Ihre Zeit: 12min 23sec Ihre Punkte: 34| 
| 8.2  |Datei gefunden| Datei öffnen| Ihre Zeit: 5min 34sec Ihre Punkte: 76| 
| 8.3  |Datei gefunden| Datei öffnen| Ihre Zeit: 20min 56sec  Ihre Punkte: 3|
| 9.1  |Spiel gestartet| 4 Dateien öffnen und danach die gesuchte| Sie haben während dem Spiel 4 Dateien geöffnet.|
| 9.2  |Spiel gestartet| 8 Dateien öffnen und danach die gesuchte| Sie haben während dem Spiel 8 Dateien geöffnet.|
| 9.3  |Spiel gestartet| 2 Dateien öffnen und danach die gesuchte| Sie haben während dem Spiel 2 Dateien geöffnet.| 
| 10.1 | Datei befindet sich auf Desktop| Datei öffnen| Datei öffnet sich| 
| 10.2 |Datei befindet sich auf Desktop| Datei öffnen| Hinweise befinden sich in der Datei|
| 11.1 |Spiel beenden| Spiel starten| Sind sie sicher, dass sie bereits ein neues Spiel starten möchten?| 
| 11.2 |Spiel beenden| 1 Minute warten , dann das Spiel starten| Spiel startet| 
| 11.3 |Spiel beenden| Dateien löschen und Spiel neu starten| Spiel startet| 
| 12.1 |1. Datei geöffnet und 2. Datei nicht gefunden| Button zur Auflösung klicken| Die Datei befindet sich ...| 
| 12.2 |Button zur Auflösung geklickt und gesehen wo sich die Datei befindet| Spiel beenden | Ihre Zeit: Datei nicht gefunden. Ihre Punkte: 0|
| 13.1 | Spiel gestartet| Datei finden| befindet sich im Ordner Schulmaterial|
| 13.2 | Spiel gestartet| Datei finden| befindet sich bei den Downloads|
| 14.1 | Programm offen | Spiel starten| "Hilfe" Knopf erscheint|
| 14.2 | Spiel gestartet| Hilfe Knopf klicken| Regeln des Spiels erscheinen|
| 15.1 | Desktop | Programm starten| Winformsapplikation öffnet sich|


### 1.4 Diagramme

!![Use-Case ](https://user-images.githubusercontent.com/110892622/224939199-75b53461-2161-4319-9733-8d7dfc88be7b.jpg)
![Screenshot 2023-02-21 114017](https://user-images.githubusercontent.com/110892622/220323035-7136533b-49fd-4811-894b-1d9a9a6cf714.jpg)
![Screenshot 2023-02-21 114046](https://user-images.githubusercontent.com/110892622/220323048-af9ebbdc-c5a3-433f-9da4-c0de2a475aea.jpg)
![Screenshot 2023-02-21 114100](https://user-images.githubusercontent.com/110892622/220323058-ebb3bd9e-c10f-4563-b20e-a3d2c123c4e8.jpg)
![Screenshot 2023-02-21 114116](https://user-images.githubusercontent.com/110892622/220323064-213019f9-ea46-4b36-9406-43843471129f.jpg)
![Screenshot 2023-02-21 114131](https://user-images.githubusercontent.com/110892622/220323096-686cd58e-5e52-446d-a54a-374cc08db5e6.jpg)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 0.A  | 21.02.2023| Alle  | Projektdokumentation: Userstory   | 1   |
| 0.B  | 21.02.2023| Rebecca Willi| PAP | 1| 
| 0.C  | 21.02.2023| Filip Mitrovic  |  USE Case Diagramm    |   1 |
| 0.D  | 28.02.2023|Alle       | Projektdokumentation: Testfälle und Planung       |   1 |
| 5.A  | 28.02.2023| Pascal Oestrich, Tobin Pinto |  Realisierung Pfadextraktion MyDocuments, MyDesktop, MyPicture und MyVideos  | 2  |
| 6.A  | 28.02.2023| Rebecca Willi Filip Mitrovic | Rechere Winforms und Dateipfadextraktion  |    2    |
| 7.A  | 07.03.2023| Tobin Pinto  | Realisierung der Stoppuhr             |     1    |
| 8.A  | 07.03.2023| Rebecca Willi     |   Realisierung von Punktesystem           |       1.5    |
| 8.B  | 07.03.2023| Filip Mitrovic    |   Realisierung vom Anzeigen des Punktesystems    |   1.5 |
| 9.A  | 07.03.2023 | Pascal Oestrich     | Fehlerüberprüfung     |     0.5          |
| 10.A | 14.03.2023 |  Tobin Pinto     | Realisieren für das Verhinder des Datensalats  |     1.5    |
| 11.A | 14.03.2023| Rebecca Willi und Filip Mitrovic  |  Realisierung der Auflösungsfunktion   |  2  |
| 12.A | 14.03.2023|  Tobin Pinto und Pascal Oestrich |  Realisierung für die Überprüfung der Dateigenerierung in einem geeigneten Ordner |  1 |
| 13.A | 21.03.2023| Filip Mitrovic | Realisierung der Spielanleitung| 1| 
| 14.A | 21.03.2023| Pascal Oestrich & Rebecca Willi| Design des Startbildschirms| 2 | 
| 15.A | 21.03.2023| Alle                            |  Fertiges Programm mit Fehlerbehebung auf Winforms realisieren  |   0.5    |


Total: 29

1 Arbeitsblock = 45 min


## 3 Entscheiden

1.
Wir haben uns entschieden, dass wir eine WinForms Applikation schreiben, da wir ein Inrerface erstellen möchten, um das Programm übersichtlicher zu gestalten

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 0.A  | 21.02.2023 | Alle                        |  1 |  2    |
| 0.B  | 21.02.2023 | Rebecca Willi               |  1 |  1    |  
| 0.C  | 21.02.2023 | Filip Mitrovic              |  1 |  1    |
| 0.D  | 28.02.2023 | Alle                        |  1 |  2    | 
| 5.A  | 28.02.2023 | Pascal Oestrlich Tobin Pinto| 2  |  2    |
| 6.A  | 28.02.2023 | Rebecca Willi Filip Mitrovic| 2  |  2    |
| 7.A  | 07.03.2023  | Tobin Pinto                 | 1  |  1    |
| 8.A  | 07.03.2023  | Filip Mitrovic              | 1.5|  1    |
| 9.A  | 07.03.2023  | Filip Mitrovic              | 1.5|  1    | 
| 10.A | 07.03.2023  |  Tobin Pinto                |  1  |  1.5 |
| 11.A | 14.03.2023  | Tobin Pinto                 |  2  |   1.5    | 
| 12.A | 14.03.2023  | Pascal Oeswtrich & Tobin Pinto|  1  |   1    |
| 13.A | 14.03.2023  | Tobin Pinto                   |  1  |   1    |
| 14.A | 14.03.2023  |  Pascal Oestrich & Rebecca |  2   |   2     |
| 15.A | 21.03.2023  |  Tobin Pinto    | 0.5 |    1  |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 27.03.2023| OK (Weg wird jedoch auf Startbildschirm angezeigt)|Rebecca Willi|
| 2.1  | 27.03.2023|  OK        |Rebecca Willi|
| 3.1  | 27.03.2023|  OK        |Rebecca Willi|
| 4.1  | 27.03.2023|  OK        |Rebecca Willi|
| 4.2  | 27.03.2023|  OK        |Rebecca Willi|
| 5.1  | 27.03.2023|  OK        |Rebecca Willi|
| 6.1  | 27.03.2023|  OK        |Rebecca Willi|
| 6.2  | 27.03.2023|  OK        |Rebecca Willi|
| 6.3  | 27.03.2023|  OK        |Rebecca Willi|
| 7.1  | 27.03.2023|  OK        |Rebecca Willi|
| 8.1  | 27.03.2023|  NOK       |Rebecca Willi|
| 8.2  | 27.03.2023|  NOK       |Rebecca Willi|
| 8.3  | 27.03.2023|  NOK       |Rebecca Willi|
| 9.1  | 27.03.2023|  NOK       |Rebecca Willi|
| 9.2  | 27.03.2023|  NOK       |Rebecca Willi|
| 9.3  | 27.03.3023|  NOK       |Rebecca Willi|
| 10.1 | 27.03.2023|  NOK       |Rebecca Willi|
| 10.2 | 27.03.2023|  NOK       |Rebecca Willi|
| 11.1 | 27.03.2023|  NOK       |Rebecca Willi|
| 11.2 | 27.03.2023|  NOK       |Rebecca Willi|
| 11.3 | 27.03.2023|  OK        |Rebecca Willi|
| 12.1 | 27.03.2023|  OK        |Rebecca Willi|
| 12.2 | 27.03.2023|  NOK       |Rebecca Willi|
| 13.1 | 27.03.2023|  OK        |Rebecca Willi|
| 13.2 | 27.03.2023|  OK        |Rebecca Willi|
| 14.1 | 27.03.2023|  OK        |Rebecca Willi|
| 14.2 | 27.03.2023|  OK        |Rebecca Willi|
| 15.1 | 27.03.2023|  NOK       |Rebecca Willi|

Das Programm läuft so, wie es von uns geplant war. An einigen Stellen haben wir Änderungen vorgenommen, weshalb diese nun nicht mehr mit den Testfällen übereinstimmen.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
