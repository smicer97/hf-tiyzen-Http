# Alkalmaz�sfejleszt�s (VIAUMA09) h�zi feladat

Alapadatok:
- A csapat neve: Tiyzen
- Csapattagok (n�v, neptun k�d): 
- Lead�shoz vide� URL:

A vide� k�s�bbi evfolyamok sz�m�ra bemutathat�/felhaszn�lhat� vide� v�g�sra?
- [ ] Igen, n�vtelen�l
- [ ] Igen, szerz�ket megnevezve
- [ ] Nem

Lead�shoz checklist:
- 24 �r�val a szem�lyes (vagy online) lead�si id�pont el�tt 24 �r�val
  - Fentebb meg van adva a csapattagok neve �s Neptun-k�dja.
  - Vide� elk�sz�tve, benne explicit kit�rve minden pontoz�si szempontra (l�sd pontoz�si szempontok vide� elv�r�sai).
  - A pontoz�si list�ban be-X-elve minden pontoz�si szempont, amivel foglalkoztatok.
  - Github pull request l�trehozva, el�ad� hozz�rendelve reviewerk�nt.
  - Amennyiben online id�pont foglal�sos bemutat�s van, az id�pontot le van foglalva a csapat sz�m�ra.

# A h�zi feladat ki�r�sa

A h�zi feladat c�lja egy diagnosztikai kliens program elk�sz�t�se egy szimul�lt vagy val�s robothoz vagy m�s be�gyazott rendszerhez. A kliens program grafikus felhaszn�l�i fel�let seg�ts�g�vel lehet�v� teszi a robot vez�rl�s�t, valamint a t�le �rkez� adatok �ttekinthet�, hibakeres�sre t�nyleg alkalmas megjelen�t�s�t. Szimul�lt robot eset�n a bemutathat�s�g �rdek�ben a szimul�tor biztos�t�sa (meg�r�sa, beszerz�se) is a feladat r�sze, melyre az el�ad�son fogunk l�tni p�ld�t.

## Jelentkez�s m�dja

- A h�zi feladat elk�sz�t�se 3 f�s csapatokban t�rt�nik. Jelentkezni a 3. oktat�si h�t v�g�ig kell az al�bbi m�don:
  - Moodle alatt az erre vonatkoz� k�rd��ven mindenkinek meg kell adni, hogy melyik csapatban van (mi a csapatneve).
  - A classroom.github.com rendszerben l�tre kell hozni a csapatot �s a tagoknak be kell l�pnie. �gy mindenki megkapja a h�zi feladat elk�sz�t�s�re sz�nt (private) repositoryt. Ehhez a megh�v� URL a Moodle alatt �rhet� majd el.

- A 2 f�s csapat is elfogadhat�, de a feladat mennyis�ge miatt 3 f� az ide�lis. A csapaton bel�li esetleges s�rl�d�sok kezel�se a csapat feladata, csak �gy, mint egy �les projektben. Az al��r�s felt�tele a csapatmunk�ban val� akt�v r�szv�tel.
- Nem RobonAUT-hoz kapcsol�d� h�zi feladatok eset�ben er�sen javasolt, hogy besz�ljetek az el�ad�val, nehogy v�letlen�l olyan megold�sba kezdjetek, amivel a sz�ks�ges pontokat nem tudj�tok megszerezni.

(Sajnos �l� p�lda miatt ha valaki a github classroomban olyan, nem szalonk�pes vagy offenz�v csapatnevet v�laszt, ami miatt p�ld�ul a github automatikusan blokkolja a t�rgy organizationj�t �s �gy az �sszes repositoryj�t, az fegyelmi elj�r�st von maga ut�n. De am�gy se igen akarj�tok, hogy k�s�bb a Google a nevetekre keresve ilyen csapatn�v mellett mutasson titeket� pl. egy leend� munk�ltat�nak.)

## A lead�s m�dja

A h�zi feladatot leadni a 14. oktat�si h�ten kell, 2 l�p�sben.
- A szem�lyes (vagy online) lead�si id�pont el�tt 24 �r�val le kell adni
  - Egy max. 5 perces screen capture (vagy m�s m�don elk�sz�tett) vide�t a megold�sr�l. (Ennek c�lja, hogy a lead�skor ne kelljen minden funkci�t v�gign�zni, hanem koncentr�lhassunk az �rdekesekre. Ezen k�v�l hogy ne kelljen azon agg�dni, hogy p�ld�ul a robot �ppen menni fog-e, ne kelljen hozz� felt�tlen�l speci�lis tesztp�lya.) A pontoz�si szempontok mindegyik�nek explicit szerepelnie kell a vide�ban, a pontoz�si szempontn�l megadott form�ban. A vide� URL-j�t ennek a f�jlnak az elej�n kell megadni �s egy b�ng�sz�ben tov�bbi telep�t�sek n�lk�l lej�tszhat�nak kell lennie (pl. youtube vagy google drive megoszt�s).
  - Be kell adni egy github.com pull requestet, benne reviewerk�nt megjel�lve a t�rgyfelel�st.
  - A megold�snak a repository master �g�n kell lennie.
  - A leadott verzi�ban ebben a README.md f�jlban minden olyan pontoz�si szempontot be kell X-elni, amire szeretn�tek pontot kapni.
- A lead�si id�pontban szem�lyes vagy online lead�st fogunk szervezni (j�rv�ny�gyi szempontok f�ggv�ny�ben), amikor megn�zz�k a megold�s �rdekesebb r�szleteit �s egyeztetj�k a kapott pontsz�mot. A RobonAUT robothoz kapcsol�d� megold�sok kedv��rt ezen az alkalmon rendelkez�sre �ll majd egy tesztp�lya, melyen egy�ttal a robotokat is lehet tesztelni, mik�zben megn�zz�k a kliens programok m�k�d�s�t. (A lead�shoz egy saj�t notebookot kell hozni. Ha ez akad�lyba �tk�zik, el�re jelezz�tek �s megoldjuk egy g�pteremben.)

Azoknak a csapatoknak, melyeknek a fenti lead�sokat nem siker�l hat�rid�re teljes�teni, a p�tl�si h�ten lesz lehet�s�g p�tlead�sra, ugyan�gy 2 l�p�sben. (A fenti 1. l�p�s k�sedelmes teljes�t�se eset�n m�r csak a p�tlead�son lehet leadni a h�zi feladatot, mivel a tal�lkoz� el�tt �t kell tudunk n�zni az el�re leadott anyagokat.)

A konkr�t 14. �s p�tl�si heti id�pontokat novemberben hirdetj�k ki.
A f�l�v v�ge �s a RobonAUT verseny ut�n (b�ven hagyva id�t) a kiadott repositorykat t�r�lni fogjuk, �gy a verseny ut�n �rdemes egy v�glegesebb repositoryt l�trehozni �s oda is pusholni.

## K�ztes code reviewk

A f�l�v sor�n lesz k�t hat�rid�, amikor az addig elk�sz�lt r�szekre lehet code reviewt k�rni. Ehhez github alatt pull requestet kell k�sz�teni �s reviewernek meg kell adni a t�rgyfelel�st (usern�v: csorbakristof).

A code review c�lja a min�l hasznosabb, szem�lyes visszajelz�s a csapatok sz�m�ra, a saj�t megold�sukkal kapcsolatban. Nem k�telez�, de pontoz�si szempont ez is.

Annak �rdek�ben, hogy az adhat� visszajelz�s min�l hasznosabb legyen, javasoljuk, hogy a megold�sr�l ilyenkor is k�sz�tsetek egy r�vid vide�t (benne a m�k�d�sr�l, a forr�sk�d fel�p�t�s�r�l, esetleges k�rd�seitekr�l), hogy min�l jobban �tl�ssuk a megold�sotok m�k�d�s�t. A vide�ra az URL-t a pull request sz�veg�be �rdemes bele�rni, mint ahogy oda val� minden megjegyz�s �s esetleges k�rd�sek is.

(�rdemes megeml�teni, hogy minden pull request k�t git branch k�l�nbs�g�t tartalmazza. A legegyszer�bb, ha l�trehoztok egy branchet a f�l�v eleji �llapotra �s ehhez hasonl�tj�tok a beadand� �llapotot.)

## Minim�lis k�vetelm�nyek (al��r�s felt�tele)

- Minden csapattag akt�v r�szv�tele a munk�ban, ami a git commit historyban is l�tszik (kiv�ve, ha p�ros programoztok �s ez�rt a k�z�s commitok egyik�t�k nev�ben k�sz�lnek).
- A forr�sk�d legyen �ttekinthet�, olvashat�, eszt�tikus. (pl. ne legyen benne hatalmas, kikommentezett forr�sk�d blokk, csom� �res sor egym�s ut�n, �teve� �s �maci� (vagy szalonk�ptelen) nev� v�ltoz�, ne egy �ri�s cpp f�jlban legyen meg�rva az eg�sz stb.)
- A kliens programnak C# nyelven, .NET Core alatt kell k�sz�lnie, UWP felhaszn�l�i fel�lettel. (A t�rgy keret�ben UWP-vel foglalkozunk, de v�laszhat� WPF is.)
- A h�zi feladathoz GIT verzi�k�vet�st kell haszn�lni a t�rgy keret�ben l�trehozott classroom.github.com-os repositoryban.
- A kliens programnak grafikus fel�lettel kell rendelkeznie, ami parancsokat tud k�ldeni �s �llapotot tud fogadni.
- A bemutat�skor a felhaszn�l�i fel�leten l�tszania kell, hogy a be�gyazott rendszer reag�l a k�ld�tt parancsokra.
- A lead�skor a master branchen l�v� (v�gleges) verzi� forduljon �s fusson egy Windows 10 alap� g�pen, Visual Studio 2019 alatt. Term�szetesen ha egy igazi robot jelenl�te kell neki, akkor nem gond, ha nem m�k�dik minden funkci�, de induljon el �s ezt a t�nyt eszt�tikus form�ban jelezze. A helyes m�k�d�s pedig a dem� vide�n �gyis l�tszani fog.

## Pontot �r� dolgok

Minden szempontn�l a megadott pont a maxim�lis adhat� pont, r�szleges megold�s kevesebb pontot is �rhet. A p�tlead�son maximum 50 pont szerezhet�.

Architekt�ra, magas szint� koncepci�k
- [ ] 10p: MVVM architekt�ra (legal�bb 3 modell �s 3 view model oszt�llyal) (Vide�ban: solution explorerben megmutatva a modell �s view model oszt�lyokat)
- T�bbsz�l�s�g
  - [ ] 8p: Task �s async-await haszn�lat�val. (Vide�ban: forr�sk�dban kiemelve)
  - [ ] 3p: BackgroundWorker haszn�lat�val progress reporttal.
- [ ] 10p: Entity Framework haszn�lata
- [ ] 5p: H�l�zati kommunik�ci� HTTP felett
  - [ ] +5p: HTTP feletti kommunik�ci�ban legal�bb 3 HTTP ige (get, put, delete, post stb.) haszn�lata, REST API kialak�t�sa

Technol�gi�k
- [ ] 5p: Canvas �s Shape haszn�lata (Vide�ban: UI-on megmutatva)
- [ ] 5p: Adatk�t�s haszn�lata (Vide�ban: xaml k�d)
- [ ] 10p: Heterog�n list�hoz adatk�t�s (DataTemplateSelector) (Vide�ban: xaml k�d)
- [ ] 5p: Regex haszn�lat nem trivi�lis feladatra (pl. nem Substring helyett) (Vide�ban: forr�sk�d r�szlet)
- [ ] 5p: IValueConverter haszn�lata (Vide�ban: xaml k�d)
- [ ] 5p: ICommand (Vide�ban: forr�sk�dban az ICommandot implement�l� oszt�ly)
- [ ] 5p: StaticResource haszn�lata (Vide�ban: xaml k�d)
- [ ] 5p: F�jlba ment�s �s onnan bet�lt�s (az UWP hozz�f�r�si korl�toz�sokat figyelembe v�ve) (Vide�ban: haszn�lat k�zben a UI vagy forr�sk�d r�szlet)
- [ ] 5p: Linq haszn�lata nem trivi�lis feladatra (query vagy method syntax is lehet) (Vide�ban: forr�sk�dban kiemelve)
- [ ] 5p: Soros�t�s JSON vagy XML form�tumba (Vide�ban: gener�lt XML/JSON felvillant�sa)
- [ ] 5p: Alapos �ntesztel� funkci� a robot sz�m�ra. A tesztet futtathatja a kliens program is, de a robot firmwareje is. A l�nyeg, hogy van �ntesztel�si funkci�. (Vide�ban: fut�s k�zben bemutatva)
- [ ] 10p: grafikon megjelen�t� package (pl. oxyplot) haszn�lata nem csak alapbe�ll�t�sokkal (Vide�ban: UI-on megmutatva)

M�dszertani szempontok
- [ ] mint�nk�nt 5p: A t�rgy keret�ben szerepl� tervez�si minta haszn�lata saj�t megval�s�t�sban (vide�ban: forr�sk�dban megmutatva). (Observer csak akkor, ha az esem�ny kiv�lt�sa is saj�t k�d, pl. egy nyom�gomb Click esem�nykezel�j�nek meg�r�sa m�g nem el�g ehhez.)
- [ ] 10p: Legal�bb 20% unit teszt lefedetts�g (Vide�ban: unit tesztek lefutnak �s z�ldek, coverage report 20% feletti sz�mot mutat). Ha kisebb a lefedetts�g, ar�nyosan kevesebb pontot �r. (UWP alkalmaz�sra macer�s tesztet �rni, a tesztelend� oszt�lyokat egy .NET Standard 2.0 projektbe hozz�tok l�tre �s azt tudj�tok hivatkozni xUnit Test projektb�l, ha a teszt projekt .NET Core 2.0-�t c�loz meg.)
- [ ] 10p: DocFX seg�ts�g�vel, XML komment�rokkal gener�lt dokument�ci� legal�bb 3 �ttekint� UML diagrammal. A dokument�ci� fejleszt�i dokument�ci�. Olyan m�rt�kben kell, hogy tartalmazza a rendszer m�k�d�s�t, hogy abb�l kider�lj�n, hogy egy adott funkci� hogy m�k�dik �s hol tal�lhat� a forr�sk�dban. A repository �rtelemszer�en tartalmazza a dokument�ci� minden forr�s�t is. A DocFX �ltal gener�lt HTML dokument�ci� ZIP-elve a github.com release funkci�j�val let�lthet� form�ban kell, hogy el�rhet� legyen a lead�si pull request l�trehoz�sakor. https://github.com/blog/1547-release-your-software 
- [ ] 3p: Hat�rid�re leadott pull request az 1. code reviewra, szignifik�ns mennyis�g� fejleszt�ssel.
- [ ] 2p: Hat�rid�re leadott pull request a 2. code reviewra, szignifik�ns mennyis�g� fejleszt�ssel.

Tov�bbi lehet�s�gek, amik nem r�szei a tananyagnak, de pontot �rnek:
- [ ] 8p: Behaviour haszn�lata (nem r�sze a tananyagnak) (Vide�ban: xaml k�d)
- [ ] 8p: Anim�ci�k haszn�lata (nem r�sze a tananyagnak) (Vide�ban: UI haszn�lat k�zben vagy xaml k�d)
- [ ] 5p: Style haszn�lata (nem r�sze a tananyagnak) (Vide�ban: xaml k�d) Az 5 pont saj�t defini�lt st�lusra vonatkozik, ami legal�bb 2 propertyt be�ll�t. El�re gy�rtott st�lus haszn�lata 1p.
- [ ] 5p: OpenCvSharp haszn�lata (Vide�ban: UI haszn�lat k�zben vagy forr�sk�d r�szlet)
- [ ] 3p: Statikus k�delemz� haszn�lata a fejleszt�s sor�n (Vide�ban: az elemz� visszajelz�seinek felvillant�sa)
- [ ] 8p: Dependency Injection keretrendszer haszn�lata

Ha nincs �tleted, hogy egy szempontot hogyan lehetne a feladatodba integr�lni, tedd fel a k�rd�st a Teams nyilv�nos csatorn�j�ban �s besz�lj�nk r�la!

A felsoroltakon k�v�li egy�b technol�gi�k haszn�lat��rt is lehet pontokat kapni, de hogy az �j pontszerz�si lehet�s�gr�l mindenki id�ben �rtes�lj�n, ezeket legk�s�bb az 5. oktat�si h�tig a tant�rgy Teams csoportj�ban (publikus csatorn�n) kell k�rni az el�ad�t�l. (Ennek f�leg az a c�lja, hogy ha valamire nem gondoltam, hogy haszn�lni fogj�tok, de igen �s sok munka, akkor j�rjon �rte plusz pont is.)

## M�nusz pontok

Van p�r alapelv�r�s, ami pontot nem �r, de ha valaki nem tartja be, az �tk�zik a tant�rgy munkafolyamataival �s ez�rt m�nusz pontot �r. K�r�nk mindenkit, hogy figyeljen a formai k�r�sekre is �s ezekre a retorzi�kra ne legyen sz�ks�g... sajnos ezt kor�bbi sz�mos rossz tapasztalat miatt kellett bevezetni.

- Vide� hossza t�bb, mint 5 perc.
- Gener�lt f�jlok (ford�t�si eredm�nyek, exe, gener�lt dokument�ci�) a git repositoryban
- A beadott verzi� nem a master �gon van.
- Ronda forr�sk�d: forr�sk�dban kikommetezett k�dr�szletek, TODO komment�rok, szalonk�ptelen v�ltoz�nevek, t�bb �res sor egym�s ut�n.

## 50-n�l t�bb pont, jegymegaj�nl�s

A h�zi feladat 50 pontot �r, de a norm�l h�zi feladat lead�si id�pontban enn�l t�bb pont is gy�jthet� a pontoz�si szempontok alapj�n, ami ugyan�gy hozz�ad�dik a f�l�ves pontsz�mhoz. (A p�tlead�son max. 50 pont szerezhet�).  Amennyiben egy csapat el�ri a 70 pontot, a h�zi feladatra megaj�nlott 5-�s adhat�.

N�h�ny minta dem� vide� (az �rintett csapatok beleegyez�s�vel), b�r ezekn�l m�g Qt/C++ volt a platform:
https://drive.google.com/drive/folders/0B4jF_XaQKmkuUm9XRWVRRGRxNjg?usp=sharing
https://www.youtube.com/watch?v=DFJsDSGP1IQ&ab_channel=GyulaSzab%C3%B3

