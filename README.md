# FootyApp ⚽

## Problematyka
Celem projektu było stworzenie aplikacji mobilnej związanej z piłką nożną. Aplikacja
powinna udostępniać kluczowe informacje z najważniejszych lig europejskich.
Nazwa została określona jako Footy App.
Początkowe założenia były następujące:
- połączenie z zewnętrznym API celem uzyskania potrzebnych danych
w formacie JSON;
- wykorzystanie frameworka MAUI.NET celem poznania nowej technologii
i jej korzyści dla programu;
- wyświetlanie najważniejszych informacji na temat wybranych lig krajowych;
- pominięcie mechanizmu autoryzacji użytkownika - pojawiał się on już
w innych projektach i zwiększyłby niepotrzebnie złożoność tego projektu.

Wszystkie powyższe założenia zostały spełnione.
Aplikacja została stworzona na podstawie wzorca Model-View-Viewmodel
(w skrócie: MVVM).

Docelowo aplikacja była rozwijana pod kątem systemu Android. Działa również bez
problemu na systemie Windows (choć tu widok nie jest zoptymalizowany pod kątem
UX). Aplikacja powinna działać na systemie iOS bez dodatkowych zmian ze względu
na zastosowanie frameworka MAUI.NET

## Działanie aplikacji
Aplikacja umożliwia przeglądanie podstawowych statystyk wszystkich klubów pięciu
najważniejszych lig krajowych (Premier League, La Liga, Serie A, Ligue 1,
Bundesliga).
Po uruchomieniu aplikacji, użytkownik może wybrać ligę z rozwijanej listy.

![](https://github.com/Digislaw/FootyApp/blob/master/Screenshots/1.png)

Po wybraniu ligi, pojawia się tabela z najważniejszymi informacjami, takimi jak:
- Pozycja w bieżącym sezonie
- Liczba wygranych/remisów/przegranych (W/D/L)
- Suma uzyskanych punktów w tym sezonie (Pts)
- Różnica bramek (Diff

![](https://github.com/Digislaw/FootyApp/blob/master/Screenshots/2.png)

Dodatkowo, po wybraniu danego klubu (tj. kliknięcie lub dotyk w zależności od
platformy), aplikacja wyświetla pełną listę zawodników wraz z podstawowymi
informacjami:
- Imię i nazwisko
- Numer na koszulce (jeśli istnieje)
- Rola w klubie
- Zdjęcie zawodnika

![](https://github.com/Digislaw/FootyApp/blob/master/Screenshots/3.png)

## Możliwości rozwoju aplikacji
Możliwe usprawnienia:
- stylizacja UI aplikacji
- dodanie zakładki z podglądem bieżących rozgrywek
- dostosowanie UI do pozostałych platform
- dodanie cache dla pobieranych danych (działanie offline?)
- dodanie statystyk, np. ranking goli, ranking asys
