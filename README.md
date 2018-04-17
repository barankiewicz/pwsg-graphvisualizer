#pwsg-graphvisualizer

#### Część 1

Edytor grafów

*   Okno główne:
    *   Okno pojawia się na środku ekranu
    *   Minimalny rozmiar okna: 800x600
    *   Okno dzieli się na dwa główne obszary: lewy - obszar roboczy grafu, zajmujący 80% szerokości okna oraz prawy obszar zajmujący pozostałe 20% okna.
    *   Dodatkowo prawy obszar jest podzielony w pionie: sekcja język i sekcja import/eksport ma stałą wysokość, podczas gdy sekcja edycji zajmuje pozostałą część ekranu w pionie.
    *   Każda sekcja z obszaru po prawej stronie posiada kontener w postaci group boxa.
    *   Sekcja edycji jest początkowo pusta, a pozostałe sekcje posiadają po 2 nieaktywne przyciski
    *   Bitmapa obszaru roboczego zawsze dostosowuje swój rozmiar do rozmiaru okna.
*   Dodawanie wierzchołków:
    *   Kliknięcie LPM w obszar roboczy powoduje dodanie wierzchołka w postaci okręgu.
    *   Dodane do grafu wierzchołki powinny zachowywać swoje pozycje niezależnie od aktualnego rozmiaru okna. Żaden wierzchołek nie powinien znikać.
    *   Okręgi reprezentujące wierzchołki mają stały, ustalony arbitralnie rozmiar.
    *   Nowo tworzone wierzchołki mają nadawany numer, który pojawia się wyśrodkowany wewnątrz wierzchołka
    *   Nie można dodać wierzchołka do grafu tak, aby kolidował on z innym wierzchołkiem
*   Kolor wierzchołka:
    *   W sekcji edycji należy dodać przycisk pozwalający na zmianę koloru dodawanych wierzchołków.
    *   Obok przycisku widnieje ikonka przyjmująca aktualnie wybrany kolor dodawania wierzchołków.
    *   Indeksy wewnątrz wierzchołków również przyjmują kolor wierzchołka.

#### Część 2

*   Plik:
    *   Graf może być zapisywany oraz wczytywany z plików o rozszerzeniu .graph.
    *   Zapisane powinny być wszystkie niezbędne informacje o grafie (oprócz zaznaczenia), tak, aby po wczytaniu uzyskać identyczny efekt na bitmapie.
    *   Nie mogą być zapisane żadne nadmiarowe informacje, lub informacje niezgodne z faktycznym stanem grafu.
    *   W przypadku wadliwych plików użytkownik powinien być informowany o błędzie.
    *   Graf można wyczyścić przyciskiem.
*   Zaznaczanie wierzchołków:
    *   Kliknięcie PPM na istniejący wierzchołek powoduje jego zaznaczenie.
    *   Zaznaczony wierzchołek rysowany jest linią przerywaną.
    *   Zaznaczony wierzchołek można usunąć wciskając klawisz DEL lub klikając przycisk, który jest aktywny tylko wtedy, gdy jest zaznaczony jakiś wierzchołek grafu.
    *   Po usunięciu wierzchołka numery pozostałych wierzchołków powinny się odpowiednio przeliczyć.
    *   Kliknięcie PPM na pozostały obszar roboczy powoduje odznaczenie wierzchołka.
    *   Zmiana koloru tworzenia wierzchołków zmienia też kolor zaznaczonego wierzchołka.
    *   Podczas, gdy kilka wierzchołków jest bardzo blisko siebie, zaznaczony powinien być wierzchołek najbliższy kursorowi.
*   Krawędzie:
    *   Podczas, gdy jeden z wierzchołków jest zaznaczony, kliknięcie na inny wierzchołek powoduje dodanie krawędzi między nimi.
    *   Gdy użytkownik kliknie w wierzchołek, który już jest połączony krawędzią z zaznaczonym, krawędź ta zostaje usunięta.
    *   Krawędzie rysowane są zawsze pod wierzchołkami i łączą ich brzegi.
    *   Usunięcie wierzchołka powoduje również usunięcie wszystkich krawędzi z nim połączonych.
*   Poruszanie wierzchołkiem:
    *   Kliknięcie ŚPM (kółko myszki) w obszar roboczy powoduje poruszanie zaznaczonym wierzchołkiem.
    *   Poruszany wierzchołek może nakładać się z innym wierzchołkiem.
    *   Podczas poruszania wierzchołka poruszają się też wszystkie połączone z nim krawędzie.
    *   Podczas poruszania wierzchołka nadal można wykonywać inne akcje, np. dodawanie kolejnych wierzchołków.
    *   Przy puszczeniu wierzchołka poza obszarem roboczym, wierzchołek powinien być "ściągany" na jego brzeg, tak aby był nadal widoczny.
*   Języki i lokalizacja:
    *   Aplikacja powinna wspierać lokalizację i obsługiwać dwa dowolne języki.
    *   Przy włączeniu aplikacja jest ustawiona na język polski.
    *   Sekcja "Język" zawiera dwa przyciski które zmieniają aktualne culture info. Każdy napis powinien zostać zmieniony na odpowiednik w innym języku.
    *   Wszystkie kontrolki powinny być poprawnie przeładowane po zmianie lokalizacji.
    *   Okno główne powinno pozostać w tej samej pozycji oraz być tej samej wielkości.