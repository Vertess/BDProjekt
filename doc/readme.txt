System informatyczny wspomagaj�cy prac� ksi�garni

Spis tre�ci

-----
1. Opis programu
2. Instalacja programu
3. Instalacja serwera bazy danych
4. Autorzy
-----

1. Opis programu
----------------

Zadaniem programu jest wspomaganie pracy ksi�garni. Program posiada r�ne funkcjonalno�ci w zale�no�ci
zalogowania si� jako admin, pracownik, oferent lub klient. O konkretnych funkcjonalno�ciach mo�na przeczyta� w za��czonym
pliku <dokumentacja.pdf>

2. Instalacja programu
----------------------

Aby zainstalowa� program nale�y uruchomi� plik <setup.exe> i post�powa� zgodnie z instrukcjami podanymi podczas instalacji.

Aby m�c zalogowa� si� na konto klienta, oferenta lub pracownika konta te musz� zosta� najpierw stworzone i zapisane do
bazy danych (wi�cej o instalacji serwera bazy danych napisane jest poni�ej). Konta te mog� zosta� stworzone przez
administratora lub przez niezalogowanego u�ytkownika (konta klienta oraz oferenta)

Aby zalogowa� si� na konto administratora nale�y poda� nast�puj�ce dane:
Login: admin
Has�o: admin

3. Instalacja serwera bazy danych
---------------------------------

Aby aplikacja dzia�a�a prawid�owo nale�y zainstalowa� serwer bazy danych (SQL Server 2014). 
Aby poprawnie zainstalowa� serwer nale�y post�powa� zgodnie z instrukcjami instalatora.

Po instalacji i uruchomieniu Microsoft SQL Server Management Studio nale�y si� zalogowa� na 
podane podczas instalacji dane. Domy�lna nazwa serwera to localhost

Nale�y klikn�� prawym przyciskiem myszy na folderze Databases, wybra� New Database i wpisac nazw� Ksiegarnia
Po wybraniu bazy Ksi�garnia nale�y wybra� New Query, wprowadzi� kod dost�pny w za��czonym pliku <install.sql> 
oraz wybra� Execute.

Nale�y pami�ta� o wpisie w pliku App.config programu, source=NAZWA_SERWERA (domy�lnie localhost)

Wi�cej informacji odno�nie instalacji serwera bazy danych mo�na znale�� w pliku <dokumentacja.pdf>
