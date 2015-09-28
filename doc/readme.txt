System informatyczny wspomagaj¹cy pracê ksiêgarni

Spis treœci

-----
1. Opis programu
2. Instalacja programu
3. Instalacja serwera bazy danych
4. Autorzy
-----

1. Opis programu
----------------

Zadaniem programu jest wspomaganie pracy ksiêgarni. Program posiada ró¿ne funkcjonalnoœci w zale¿noœci
zalogowania siê jako admin, pracownik, oferent lub klient. O konkretnych funkcjonalnoœciach mo¿na przeczytaæ w za³¹czonym
pliku <dokumentacja.pdf>

2. Instalacja programu
----------------------

Aby zainstalowaæ program nale¿y uruchomiæ plik <setup.exe> i postêpowaæ zgodnie z instrukcjami podanymi podczas instalacji.

Aby móc zalogowaæ siê na konto klienta, oferenta lub pracownika konta te musz¹ zostaæ najpierw stworzone i zapisane do
bazy danych (wiêcej o instalacji serwera bazy danych napisane jest poni¿ej). Konta te mog¹ zostaæ stworzone przez
administratora lub przez niezalogowanego u¿ytkownika (konta klienta oraz oferenta)

Aby zalogowaæ siê na konto administratora nale¿y podaæ nastêpuj¹ce dane:
Login: admin
Has³o: admin

3. Instalacja serwera bazy danych
---------------------------------

Aby aplikacja dzia³a³a prawid³owo nale¿y zainstalowaæ serwer bazy danych (SQL Server 2014). 
Aby poprawnie zainstalowaæ serwer nale¿y postêpowaæ zgodnie z instrukcjami instalatora.

Po instalacji i uruchomieniu Microsoft SQL Server Management Studio nale¿y siê zalogowaæ na 
podane podczas instalacji dane. Domyœlna nazwa serwera to localhost

Nale¿y klikn¹æ prawym przyciskiem myszy na folderze Databases, wybraæ New Database i wpisac nazwê Ksiegarnia
Po wybraniu bazy Ksiêgarnia nale¿y wybraæ New Query, wprowadziæ kod dostêpny w za³¹czonym pliku <install.sql> 
oraz wybraæ Execute.

Nale¿y pamiêtaæ o wpisie w pliku App.config programu, source=NAZWA_SERWERA (domyœlnie localhost)

Wiêcej informacji odnoœnie instalacji serwera bazy danych mo¿na znaleŸæ w pliku <dokumentacja.pdf>
