# Alkalmazásfejlesztés (VIAUMA09) házi feladat

Alapadatok:
- A csapat neve: Tiyzen
- Csapattagok (név, neptun kód): Csoma Viktor (MW2RW9), Schmidl Gergő (H9JJLJ), ccc (ghi123)
- Leadáshoz videó URL:

A videó későbbi evfolyamok számára bemutatható/felhasználható videó vágásra?
- [x] Igen, névtelenül
- [ ] Igen, szerzőket megnevezve
- [ ] Nem

## Pontot érő dolgok

Minden szempontnál a megadott pont a maximális adható pont, részleges megoldás kevesebb pontot is érhet. A pótleadáson maximum 50 pont szerezhető.

Architektúra, magas szintű koncepciók
- [x] 10p: MVVM architektúra (legalább 3 modell és 3 view model osztállyal) (Videóban: solution explorerben megmutatva a modell és view model osztályokat)
- Többszálúság
  - [ ] 8p: Task és async-await használatával. (Videóban: forráskódban kiemelve)
  - [ ] 3p: BackgroundWorker használatával progress reporttal.
- [ ] 10p: Entity Framework használata
- [x] 5p: Hálózati kommunikáció HTTP felett
  - [ ] +5p: HTTP feletti kommunikációban legalább 3 HTTP ige (get, put, delete, post stb.) használata, REST API kialakítása

Technológiák
- [ ] 5p: Canvas és Shape használata (Videóban: UI-on megmutatva)
- [ ] 5p: Adatkötés használata (Videóban: xaml kód)
- [x] 10p: Heterogén listához adatkötés (DataTemplateSelector) (Videóban: xaml kód)
- [ ] 5p: Regex használat nem triviális feladatra (pl. nem Substring helyett) (Videóban: forráskód részlet)
- [ ] 5p: IValueConverter használata (Videóban: xaml kód)
- [ ] 5p: ICommand (Videóban: forráskódban az ICommandot implementáló osztály)
- [ ] 5p: StaticResource használata (Videóban: xaml kód)
- [ ] 5p: Fájlba mentés és onnan betöltés (az UWP hozzáférési korlátozásokat figyelembe véve) (Videóban: használat közben a UI vagy forráskód részlet)
- [ ] 5p: Linq használata nem triviális feladatra (query vagy method syntax is lehet) (Videóban: forráskódban kiemelve)
- [ ] 5p: Sorosítás JSON vagy XML formátumba (Videóban: generált XML/JSON felvillantása)
- [x] 5p: Alapos öntesztelő funkció a robot számára. A tesztet futtathatja a kliens program is, de a robot firmwareje is. A lényeg, hogy van öntesztelési funkció. (Videóban: futás közben bemutatva)
- [ ] 10p: grafikon megjelenítő package (pl. oxyplot) használata nem csak alapbeállításokkal (Videóban: UI-on megmutatva)

Módszertani szempontok
- [ ] mintánként 5p: A tárgy keretében szereplő tervezési minta használata saját megvalósításban (videóban: forráskódban megmutatva). (Observer csak akkor, ha az esemény kiváltása is saját kód, pl. egy nyomógomb Click eseménykezelőjének megírása még nem elég ehhez.)
- [x] 10p: Legalább 20% unit teszt lefedettség (Videóban: unit tesztek lefutnak és zöldek, coverage report 20% feletti számot mutat). Ha kisebb a lefedettség, arányosan kevesebb pontot ér. (UWP alkalmazásra macerás tesztet írni, a tesztelendő osztályokat egy .NET Standard 2.0 projektbe hozzátok létre és azt tudjátok hivatkozni xUnit Test projektből, ha a teszt projekt .NET Core 2.0-át céloz meg.)
	- [x] Observer
	- [x] Composite
	- [x] Strategy
	- [x] Dependency Injection
	- [x] Abstract Factory
	- [x] Proxy
	- [x] Singleton
- [ ] 10p: DocFX segítségével, XML kommentárokkal generált dokumentáció legalább 3 áttekintő UML diagrammal. A dokumentáció fejlesztői dokumentáció. Olyan mértékben kell, hogy tartalmazza a rendszer működését, hogy abból kiderüljön, hogy egy adott funkció hogy működik és hol található a forráskódban. A repository értelemszerűen tartalmazza a dokumentáció minden forrását is. A DocFX által generált HTML dokumentáció ZIP-elve a github.com release funkciójával letölthető formában kell, hogy elérhető legyen a leadási pull request létrehozásakor. https://github.com/blog/1547-release-your-software 
- [x] 3p: Határidőre leadott pull request az 1. code reviewra, szignifikáns mennyiségű fejlesztéssel.
- [x] 2p: Határidőre leadott pull request a 2. code reviewra, szignifikáns mennyiségű fejlesztéssel.

További lehetőségek, amik nem részei a tananyagnak, de pontot érnek:
- [ ] 8p: Behaviour használata (nem része a tananyagnak) (Videóban: xaml kód)
- [ ] 8p: Animációk használata (nem része a tananyagnak) (Videóban: UI használat közben vagy xaml kód)
- [ ] 5p: Style használata (nem része a tananyagnak) (Videóban: xaml kód) Az 5 pont saját definiált stílusra vonatkozik, ami legalább 2 propertyt beállít. Előre gyártott stílus használata 1p.
- [ ] 5p: OpenCvSharp használata (Videóban: UI használat közben vagy forráskód részlet)
- [x] 3p: Statikus kódelemző használata a fejlesztés során (Videóban: az elemző visszajelzéseinek felvillantása)
- [ ] 8p: Dependency Injection keretrendszer használata

Ha nincs ötleted, hogy egy szempontot hogyan lehetne a feladatodba integrálni, tedd fel a kérdést a Teams nyilvános csatornájában és beszéljünk róla!

A felsoroltakon kívüli egyéb technológiák használatáért is lehet pontokat kapni, de hogy az új pontszerzési lehetőségről mindenki időben értesüljön, ezeket legkésőbb az 5. oktatási hétig a tantárgy Teams csoportjában (publikus csatornán) kell kérni az előadótól. (Ennek főleg az a célja, hogy ha valamire nem gondoltam, hogy használni fogjátok, de igen és sok munka, akkor járjon érte plusz pont is.)

## Mínusz pontok

Van pár alapelvárás, ami pontot nem ér, de ha valaki nem tartja be, az ütközik a tantárgy munkafolyamataival és ezért mínusz pontot ér. Kérünk mindenkit, hogy figyeljen a formai kérésekre is és ezekre a retorziókra ne legyen szükség... sajnos ezt korábbi számos rossz tapasztalat miatt kellett bevezetni.

- Videó hossza több, mint 5 perc.
- Generált fájlok (fordítási eredmények, exe, generált dokumentáció) a git repositoryban
- A beadott verzió nem a master ágon van.
- Ronda forráskód: forráskódban kikommetezett kódrészletek, TODO kommentárok, szalonképtelen változónevek, több üres sor egymás után.

## 50-nél több pont, jegymegajánlás

A házi feladat 50 pontot ér, de a normál házi feladat leadási időpontban ennél több pont is gyűjthető a pontozási szempontok alapján, ami ugyanúgy hozzáadódik a féléves pontszámhoz. (A pótleadáson max. 50 pont szerezhető).  Amennyiben egy csapat eléri a 70 pontot, a házi feladatra megajánlott 5-ös adható.

Néhány minta demó videó (az érintett csapatok beleegyezésével), bár ezeknél még Qt/C++ volt a platform:
https://drive.google.com/drive/folders/0B4jF_XaQKmkuUm9XRWVRRGRxNjg?usp=sharing
https://www.youtube.com/watch?v=DFJsDSGP1IQ&ab_channel=GyulaSzab%C3%B3

