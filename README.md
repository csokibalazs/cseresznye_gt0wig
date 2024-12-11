
# Pontvadász ZH 

## Cherry Picking 

## Árlap 

A pontszámok szorzat formájában kerültek megadásra, pl: `4x1p`. A **második** szám -- a példában `1p` -- azt jelenti, hogy hogy hány pontot ér az adott részfeladat, az **első** pedig az adja meg, hogy hány ismétlés kerül beszámításra. Így nem lehet egyetlen részfeladat ismételgetésével teljesíteni a ZH-t. 

### Windows Forms Application

##### User Interface 

- `2x2p` Olyan alkalmazás **elrendezés, melyben gombok lenyomására UserControl-ok kerülnek elhelyezésre egy Panel vezérlőben**, teljesen kitöltve azt. Minden gombra jár a pont, amennyiben az funckuonlalitással rendelkező UserControl-t tölt be. 

- `1x2p` **Anchorok alkalmazása**: az alkalmazás egészében meg van oldva, hogy az ablak átméretezésekor ki legyen használva a rendelkezésre álló terület.	

##### Tábla adatainak megjelenítése `ListBox`-ban. 

- `1x2p` Adatok  megjelenítése 
- `2x2p` Ha az adatok tetszőleges módszerrel, pl. `TextBox`-on keresztül szűrhetőek. 

##### Tábla adatainak megjelenítése `DataGridView`-ban 

- `1x2p` Adatok  megjelenítése 
- `1x2p` Ha a tábla adatforrása saját osztály. 

##### Adatkötés `BindingSource` -on keresztül

- `1x2p` Működő  `BindingSource` 
- `3x1p` Egy `BindingSource`-ra egy gyűjemény megjelenítésére alkalmas vezérlő (ListÍBox, ComboBox, DataGridVIew) mellett más adatkötött vezérlő is van kötve, mint `TextBox`, `DateTimePicker`, `ComboBox` idegen kulcs értékének beállítására, stb.

### ASP .NET 

ASP .NET alkalmazás, melyet lehet a Forms alapú projekttel közös solution-ben létrehozni.

- `1x2p`  `program.cs` beállítása `wwwroot` mappában tárolt statikus tartalmak megosztására

##### API végpontok

- `1x3p` Teljes SQL tábla adatainak szolgáltatása API végponton keresztül 
- `2x2p` SQL tábla egy választható rekordjának szolgáltatása API végponton keresztül
- `1x3p` SQL tábla egy választható rekordjának törlése
- `1x5p` Új rekord felvétele `HttpPost` metóduson keresztül SQL táblába
- `1x5p` Külső API végpont használata JS kódban

##### Javascript

- `2x5p` (pl: szöveg és kép) DOM feltöltése javascripttel (vizsgán írandó, NEM HOZOTT, aki ezt választja az a hozott anyagba nem rakhatja bele a js kódot amivel feltölti a tartalommal a DOM-ot, tehát ez az előre feltöltött `hozott.js`-ben nem lehet benne, vizsgán kell megírni egy `vizsga.js` fájlba.) 

### Hozott anyagok

##### Saját Adatbázis

SQL script formájában, de legjobb Azure SQL szerveren hosztolni

- `3x1p` Az alkalmazásban használt táblánként pont
- `1x1p` Az adatbázis tartalmaz Constraint-eket (min 2)
- `1x1p` Az adatbázis adatainak forrásmegjelölése értsd: CHATGPT generálta
- `1x2p` Az adatbázis saját Azure SQL szerveren van

##### Weboldal

Itt csak azok az elemek számíthatóak be, amelyeknek meg van a ZH alatt felépített API végpontja. 

- `1x1p` A weboldalnak van egy értelmezhető struktúrája
- `1x1p` A weboldal dinamikus tartalommal tölthető fel adatbázison keresztül
- `1x1p` A weboldal használ legalább 20 sor értelmes css-t
- `1x1p` A weboldal javascriptje más funkciót is ellát, mint az adatok betöltése

### Egyéb, extra

- `2x1p`  `Scaffold-DbContext` használata (ajándék)
