# Lern-Bericht
Lupin = Rebecca Willi, Filip Mitrovic, Tobin Pinto, Pascal Oestrich

## Einleitung

Unser Programm ist windowschschnitzeljagd Spiel, indem man eine .txt Datei, die auf einem zufälligen Ort generiert, finden muss.

## Was habe ich gelernt?

 Wir haben gelernt, wie man in C# Dateiordner in den 6 Hauptordner (Desktop, Dokumente, Downloads, Bilder, Videos, Musik) auslesen kann.

## Beschreibung
In diesem Lernbericht erklären wir, was wir über das Auslesen von Pfade der 6 Hauptorder in `C#` gelernt haben.


#### Text:
In vielen Projekten ist es wichtig, verschiedene Pfade auslesen zu können, um allenfalls Dateien an den richtigen Ort abzuspeichern. Bei jeder Installation von Windows generiert Windows 6 Hauptordner auch `SpeacilFolder` genannt. Die haben jeweils einen eigenen Namen, somit ist der Name vom Ordner Dokumente MyDocuments.
Dazu gibt es in C# eigene Methoden und Funktionen, die das Auslesen der Pfade ermöglicht. Um einen Pfad eines SpecialFolders auszulesen, braucht man die Methoden
`Environment` und `GetFolderPath`, wie auch die Funktion `SpecialFolder`.

Environment ruft alle Computerinformationen auf, zum Beispiel das Datum oder abgespeicherte Dateien. Die Methode GetFolderPath gibt an, dass der Rückgabewert ein Pfad von einer Datei oder Ordner sein soll. Mit diesen Angaben, sagt man dem Computer, "Computer, gib mir einen Pfad aus, Computer gib mit dem Pfad von SpecialFolder myDocuments aus". Wenn man den Pfad eines Hauptordners hat, kann man die Pfade der Ordner, die in einem SpecialFolder sind, auslesen.

Somit kann man den Code `Directory.GetDirectories(Pfad des Specialfolder)` schreiben und ausführen. `Directory.GetDirectories` gibt alle Pfade aller Ordner in dem erwähnten SpecialFolder aus. Die Pfade kann man dann schliesslich in einem Array oder einer Liste speichern.
 
#### Bild:

![image](https://user-images.githubusercontent.com/89131744/229720049-efd09555-4f83-4a57-8701-bdd05961de8e.png)

#### GIF:
![giphy](https://user-images.githubusercontent.com/110892622/229720626-6e019881-c6f3-49f4-bb04-9600b9e40a00.gif)

## Verifikation

* `Textbeschreibung:` Die Textbeschreibung beschreibt wie die pfade eines Hauptordners und die Pfade dessen Inhalte ausgelesen werden.

* `Bild vom Code:` Dieses Bild Zeigt, was Environment. GetFolderPath in diesem Bespiel ausgibt.

* `Gif:` Das Gif zeigt die Ausgabe aller Pfade innerhalb eines Hauptordners.

# Reflektion zum Arbeitsprozess

Unser Arbeitsprozess verlief reibungslos. Das Team hat gut zusammengearbeitet und wir kamen mit unserem Projekt schnell voran. Jeder hat die Aufgaben erledigt, die ihm zugeteilt wurden.

Da das Team so gut funktioniert hat, waren wir sehr schnell, sodass wir fast zu wenig Arbeitspakete hatten und so Teammitglieder teilweise weniger zu tun hatten. Wir haben dann aber das Testen etwas vorgezogen und etwas mehr Zeit in die Präsentation investiert.

**VBV**: Für das nächste Mal sollten wir unbedingt die Arbeitspakete besser verwalten und verteilen, sodass alle immer genug zu tun hätten.
