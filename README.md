 Implementacja gry wyścigowej 3D w środowisku Unity z zastosowaniem technik autonomicznego prowadzenia samochodu

 Wprowadzenie

Niniejsza dokumentacja dotyczy projektu gry wyścigowej 3D stworzonej w środowisku Unity. Gra umożliwia autonomiczne prowadzenie samochodów dzięki zastosowaniu algorytmów sztucznej inteligencji oraz uczenia maszynowego. Projekt jest idealny dla osób zainteresowanych tworzeniem gier oraz implementacją AI w kontekście prowadzenia pojazdów.

 Wymagania

- Unity 2019.4.10f1 lub nowszy
- Visual Studio (lub inny edytor kodu zintegrowany z Unity)
- System operacyjny Windows, macOS lub Linux

 Instalacja i uruchomienie (dla deweloperów)

1. Sklonuj repozytorium projektu
   git clone https://github.com/slowik93/RacingGame.git
   
2. Otwórz projekt w Unity
   - Upewnij się, że masz zainstalowaną odpowiednią wersję Unity.
   - Otwórz Unity Hub, kliknij `Add` i wskaż folder z projektem.

3. Zainstaluj zależności
   - Wszystkie niezbędne pakiety Unity powinny zostać automatycznie zainstalowane przy pierwszym uruchomieniu projektu.

4. Uruchom grę
   - W Unity otwórz scenę startową (np. `MainMenu`) i kliknij przycisk `Play`.

 Konfiguracja

Przed uruchomieniem gry upewnij się, że wszystkie wymagane pakiety są zainstalowane, a ustawienia projektu są prawidłowo skonfigurowane w Unity. W razie potrzeby możesz dostosować ustawienia fizyki oraz AI w odpowiednich skryptach w folderze `Scripts`.

 Użycie (dla użytkowników)

- Rejestracja i logowanie: Użytkownicy mogą rozpocząć grę bez konieczności rejestracji.
- Tryb wyścigu z AI: Gracze mogą ścigać się z przeciwnikami sterowanymi przez AI.
- Personalizacja pojazdów: Możliwość dostosowania wyglądu i parametrów samochodu.
- Historia wyścigów: Możliwość przeglądania wyników poprzednich wyścigów.

 API

Projekt zawiera kilka punktów końcowych (endpoints) API, które mogą być użyte do interakcji z grą oraz zarządzania danymi:
- `/race/start`: Endpoint do rozpoczęcia nowego wyścigu.
- `/race/history`: Endpoint do przeglądania historii wyścigów.
- `/car/customize`: Endpoint do personalizacji pojazdu.
- `/ai/settings`: Endpoint do konfiguracji ustawień AI.

 Bezpieczeństwo

Gra wykorzystuje mechanizmy Unity do zarządzania stanem gry oraz danymi użytkowników. Wszystkie dane są przechowywane lokalnie, a hasła i inne wrażliwe informacje są zabezpieczone zgodnie z najlepszymi praktykami branżowymi.


