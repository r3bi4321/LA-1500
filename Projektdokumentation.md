# Projekt-Dokumentation

Gruppe Lupin
Willi, Pinto, Oestrich, Mitrovic

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 21.02.2023 | 0.0.1   | Thema ausgewählt und 1.1-1.4 angefangen  |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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
| 10   | Muss           |Funktional| Als User möchte ich, dass das Spiel fehlerfrei funktioniert, damit man das Spiel gut spielen kann.|
| 11|  Muss             |Funktional| Als User möchte ich, das man das Programm nicht zweimal nacheinander ausführen kann, damit man einen Datensalat auf dem Computer verhindert.|
| 12  | Muss            |Funktional| Als User möchte ich, wenn man die Datei nicht findet eine Möglichkeit besteht, die Datei zu lokalisieren, damit man das Spiel auch beim Nicht-finden der Datei beenden kann.|
| 13  | Muss            | Funktional| Als User möchte ich, dass die Datei nicht Windows veränderte Ordner generiet wird, damit man dem Computer keinen Schaden zufügt.|
| 14 | Kann             | Optional| Als User möchte ich, dass beim Starten des Spiels eine Anleitung zu finden ist, damit ein Spieler versteht was zu tun ist.|
|15 | Kann              | Rand| Als User möchte ich, dass das Speil eine Konsolenapplikation ist.| 

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

![UseCase-Diagramm-LA1500](https://user-images.githubusercontent.com/110892622/220322534-37401d51-f5bd-4292-bfd4-ab9487b0ab3c.jpg)
![Screenshot 2023-02-21 114017](https://user-images.githubusercontent.com/110892622/220323035-7136533b-49fd-4811-894b-1d9a9a6cf714.jpg)
![Screenshot 2023-02-21 114046](https://user-images.githubusercontent.com/110892622/220323048-af9ebbdc-c5a3-433f-9da4-c0de2a475aea.jpg)
![Screenshot 2023-02-21 114100](https://user-images.githubusercontent.com/110892622/220323058-ebb3bd9e-c10f-4563-b20e-a3d2c123c4e8.jpg)
![Screenshot 2023-02-21 114116](https://user-images.githubusercontent.com/110892622/220323064-213019f9-ea46-4b36-9406-43843471129f.jpg)
![Screenshot 2023-02-21 114131](https://user-images.githubusercontent.com/110892622/220323096-686cd58e-5e52-446d-a54a-374cc08db5e6.jpg)

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
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.