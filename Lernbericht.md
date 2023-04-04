# Lern-Bericht
Lupin = Rebecca Willi, Filip Mitrovic, Tobin Pinto, Pascal Oestrich

## Einleitung

Unser Programm ist windowschschnitzeljagt spiel, indem man eine .txt Datei, die auf einem zufälligen Ort generiert finden muss.

## Was habe ich gelernt?

 Wir haben gelernt, wie man in C# Dateiordner in den 6 Haubtorder (Desktop, Dokumente, Downloads, Bilder, Videos, Musik) auslesen kann.
✍️ Beschreiben Sie in einem Satz **eine** Sache, die Sie bei diesem Projekt gelernt haben und die Sie in diesem Lern-Bericht dokumentieren.

## Beschreibung
In diesem Lerbericht erklären wir, was wir über das Auslesen on Pfade der 6 Haubtorder in C# gelernt haben.
✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

##Text
In vielen Projekten ist es wichtig verschiedene Pfade auslesen zu können, um allenfalls Dateien an den Richitgen Ort abzuspeichern. Bei jeder Instalation von Windows, generiert Windows 6 Haubtorder auch **SpeacilFolder** gennant. Die haben jeweils einen eigenen Namen, somit ist der Name vom Ordner Dokumente **MyDocuments**. Dazu gibt es in C# eigene Methoden und Funktionen, die das Auslesen der Pfade ermöglicht. Um einen Pfad eines **SpecialFolders** auszulesen, bracht man die Methoden
**Environmen** und **GetFolderPath**, wie auch die Funktion **SpecialFolder**. **Environmen** ruft alle Computerinformationen auf, zum Beispiel das Datum oder abgespeicherte Dateien. Die Methode **GetFolderPath** Gibt an, das der Rückgabewert ein Pfad von einer Datei oder Ordner sein soll. Mit diesen Angaben, sagt man dem Computer, "Computer gib mir einen Pfad aus, Computer gib mit den Pfad von SpecialFolder myDocuments aus". Wenn man einen Pfad eines haubtorder hat, kann man die Pfade der Ordner, die in einem **SpecialFolder** sind auslesen. Somit kann man den Code **Directory.GetDirectories(*Pfad des Specialfolder*)** schreiben und ausführe. **(Directory.GetDirectories)** gibt alle Pfade aller Ordner in dem erwähnten **SpecialFolder** aus. Die Pfade kann man dann schliesslich ich einen Array oder Liste speichern.
 
* Ein deutliches, aussagekräftiges Bild oder eine kommentierte Bildschirm-Aufnahme
* Ein gut dokumentierter Code-Fetzen
* Ein Link zu einem *selbst aufgenommenen* youtube-Video oder `.gif`.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

Unser Arbeitsprozess verlief reibungslos. Das Team hat gut zusammen gearbeitet und wir kamen mit unserem Projekt schnell voran. Jeder hat die Aufgaben erledigt, die ihm zugeteilt wurden.

Da das Team so gut funktioniert hat, waren wir sehr schnell, sodass wir fast zu wenige Arbeitspakete hatten und so Teammitglieder teilweise fast nichts zu tun hatten. Wir haben dann aber das Testen etwas vorgezogen und etwas mehr Zeit in die Präsentation investiert.

**VBV**: Für das nächste Mal müssten wir unbedingt mehr Arbeitspakete machen, sodass alle immer genug zu tun haben.
