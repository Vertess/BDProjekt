
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/22/2015 22:02:32
-- Generated from EDMX file: C:\Users\Andreas\Documents\GitHub\BDProjekt\BDProjekt\Ksiegarnia.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ksiegarnia];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_AutorzyKsiazkis_dbo_Autors_Autor_IdAutora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AutorzyKsiazkis] DROP CONSTRAINT [FK_dbo_AutorzyKsiazkis_dbo_Autors_Autor_IdAutora];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AutorzyKsiazkis_dbo_Ksiazkas_IdKsiazka_IdKsiazki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AutorzyKsiazkis] DROP CONSTRAINT [FK_dbo_AutorzyKsiazkis_dbo_Ksiazkas_IdKsiazka_IdKsiazki];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Dostawas_dbo_Oferents_Oferent_IdOferenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dostawas] DROP CONSTRAINT [FK_dbo_Dostawas_dbo_Oferents_Oferent_IdOferenta];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Dostawas_dbo_Pracowniks_Pracownik_IdPracownika]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dostawas] DROP CONSTRAINT [FK_dbo_Dostawas_dbo_Pracowniks_Pracownik_IdPracownika];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Egzemplarzs_dbo_Ksiazkas_Ksiazka_IdKsiazki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Egzemplarzs] DROP CONSTRAINT [FK_dbo_Egzemplarzs_dbo_Ksiazkas_Ksiazka_IdKsiazki];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Egzemplarzs_dbo_Wydawnictwoes_Wydawnictwo_IdWydawnictwa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Egzemplarzs] DROP CONSTRAINT [FK_dbo_Egzemplarzs_dbo_Wydawnictwoes_Wydawnictwo_IdWydawnictwa];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ElementyDostawies_dbo_Dostawas_IdDostawy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElementyDostawies] DROP CONSTRAINT [FK_dbo_ElementyDostawies_dbo_Dostawas_IdDostawy];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ElementyDostawies_dbo_Egzemplarzs_IdEgzemplarza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElementyDostawies] DROP CONSTRAINT [FK_dbo_ElementyDostawies_dbo_Egzemplarzs_IdEgzemplarza];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ElementyZamowienias_dbo_Egzemplarzs_IdEgzemplarza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElementyZamowienias] DROP CONSTRAINT [FK_dbo_ElementyZamowienias_dbo_Egzemplarzs_IdEgzemplarza];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_ElementyZamowienias_dbo_Zamowienies_IdZamowienia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ElementyZamowienias] DROP CONSTRAINT [FK_dbo_ElementyZamowienias_dbo_Zamowienies_IdZamowienia];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Ksiazkas_dbo_Gatuneks_Gatunek_IdGatunku]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ksiazkas] DROP CONSTRAINT [FK_dbo_Ksiazkas_dbo_Gatuneks_Gatunek_IdGatunku];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_OfertaOferentas_dbo_Egzemplarzs_Egzemplarz_IdEgzemplarza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OfertaOferentas] DROP CONSTRAINT [FK_dbo_OfertaOferentas_dbo_Egzemplarzs_Egzemplarz_IdEgzemplarza];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_OfertaOferentas_dbo_Oferents_Oferent_IdOferenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OfertaOferentas] DROP CONSTRAINT [FK_dbo_OfertaOferentas_dbo_Oferents_Oferent_IdOferenta];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Reklamacjas_dbo_RealizacjeReklamacjis_RealizacjeReklamacji_IdRealizacji]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reklamacjas] DROP CONSTRAINT [FK_dbo_Reklamacjas_dbo_RealizacjeReklamacjis_RealizacjeReklamacji_IdRealizacji];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Zamowienies_dbo_Klients_Klient_IdKlienta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zamowienies] DROP CONSTRAINT [FK_dbo_Zamowienies_dbo_Klients_Klient_IdKlienta];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Zamowienies_dbo_Pracowniks_Pracownik_IdPracownika]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zamowienies] DROP CONSTRAINT [FK_dbo_Zamowienies_dbo_Pracowniks_Pracownik_IdPracownika];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Zamowienies_dbo_Rabats_Rabat_IdRabatu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zamowienies] DROP CONSTRAINT [FK_dbo_Zamowienies_dbo_Rabats_Rabat_IdRabatu];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Zamowienies_dbo_RealizacjaZamowienias_RealizacjaZamowienia_IdRealizacji]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zamowienies] DROP CONSTRAINT [FK_dbo_Zamowienies_dbo_RealizacjaZamowienias_RealizacjaZamowienia_IdRealizacji];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_Zamowienies_dbo_RodzajWysylkis_RodzajuWysylki_IdRodzajWysylki]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zamowienies] DROP CONSTRAINT [FK_dbo_Zamowienies_dbo_RodzajWysylkis_RodzajuWysylki_IdRodzajWysylki];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Autors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autors];
GO
IF OBJECT_ID(N'[dbo].[AutorzyKsiazkis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AutorzyKsiazkis];
GO
IF OBJECT_ID(N'[dbo].[Dostawas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dostawas];
GO
IF OBJECT_ID(N'[dbo].[Egzemplarzs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Egzemplarzs];
GO
IF OBJECT_ID(N'[dbo].[ElementyDostawies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElementyDostawies];
GO
IF OBJECT_ID(N'[dbo].[ElementyZamowienias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElementyZamowienias];
GO
IF OBJECT_ID(N'[dbo].[Gatuneks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Gatuneks];
GO
IF OBJECT_ID(N'[dbo].[Klients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Klients];
GO
IF OBJECT_ID(N'[dbo].[Ksiazkas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ksiazkas];
GO
IF OBJECT_ID(N'[dbo].[Oferents]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Oferents];
GO
IF OBJECT_ID(N'[dbo].[OfertaOferentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OfertaOferentas];
GO
IF OBJECT_ID(N'[dbo].[Pracowniks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pracowniks];
GO
IF OBJECT_ID(N'[dbo].[Rabats]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rabats];
GO
IF OBJECT_ID(N'[dbo].[RealizacjaZamowienias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RealizacjaZamowienias];
GO
IF OBJECT_ID(N'[dbo].[RealizacjeReklamacjis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RealizacjeReklamacjis];
GO
IF OBJECT_ID(N'[dbo].[Reklamacjas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reklamacjas];
GO
IF OBJECT_ID(N'[dbo].[RodzajWysylkis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RodzajWysylkis];
GO
IF OBJECT_ID(N'[dbo].[Wydawnictwoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Wydawnictwoes];
GO
IF OBJECT_ID(N'[dbo].[Zamowienies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zamowienies];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Autors'
CREATE TABLE [dbo].[Autors] (
    [IdAutora] int IDENTITY(1,1) NOT NULL,
    [DataUrodzenia] datetime  NOT NULL,
    [Imie] nvarchar(max)  NULL,
    [Nazwisko] nvarchar(max)  NULL
);
GO

-- Creating table 'AutorzyKsiazkis'
CREATE TABLE [dbo].[AutorzyKsiazkis] (
    [Autor_IdAutora] int  NOT NULL,
    [IdKsiazka_IdKsiazki] int  NOT NULL
);
GO

-- Creating table 'Dostawas'
CREATE TABLE [dbo].[Dostawas] (
    [IdDostawy] int IDENTITY(1,1) NOT NULL,
    [Oferent_IdOferenta] int  NOT NULL,
    [Pracownik_IdPracownika] int  NOT NULL,
    [Status] bit  NOT NULL
);
GO

-- Creating table 'Egzemplarzs'
CREATE TABLE [dbo].[Egzemplarzs] (
    [IdEgzemplarza] int IDENTITY(1,1) NOT NULL,
    [Cena] int  NOT NULL,
    [Iloscc] int  NOT NULL,
    [TypOkladki] bit  NOT NULL,
    [Ksiazka_IdKsiazki] int  NOT NULL,
    [Wydawnictwo_IdWydawnictwa] int  NOT NULL
);
GO

-- Creating table 'ElementyDostawies'
CREATE TABLE [dbo].[ElementyDostawies] (
    [IdEgzemplarza] int  NOT NULL,
    [IdDostawy] int  NOT NULL,
    [Ilosc] int  NOT NULL
);
GO

-- Creating table 'ElementyZamowienias'
CREATE TABLE [dbo].[ElementyZamowienias] (
    [IdEgzemplarza] int  NOT NULL,
    [IdZamowienia] int  NOT NULL,
    [Ilosc] int  NOT NULL
);
GO

-- Creating table 'Gatuneks'
CREATE TABLE [dbo].[Gatuneks] (
    [IdGatunku] int IDENTITY(1,1) NOT NULL,
    [NazwaGatunku] nvarchar(max)  NULL
);
GO

-- Creating table 'Klients'
CREATE TABLE [dbo].[Klients] (
    [IdKlienta] int IDENTITY(1,1) NOT NULL,
    [Imie] nvarchar(max)  NULL,
    [Nazwisko] nvarchar(max)  NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Haslo] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'Ksiazkas'
CREATE TABLE [dbo].[Ksiazkas] (
    [IdKsiazki] int IDENTITY(1,1) NOT NULL,
    [Opis] nvarchar(max)  NULL,
    [Tytul] nvarchar(max)  NULL,
    [Gatunek_IdGatunku] int  NOT NULL
);
GO

-- Creating table 'Oferents'
CREATE TABLE [dbo].[Oferents] (
    [IdOferenta] int IDENTITY(1,1) NOT NULL,
    [Adres] nvarchar(max)  NULL,
    [NazwaFirmy] nvarchar(max)  NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Haslo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OfertaOferentas'
CREATE TABLE [dbo].[OfertaOferentas] (
    [IdOfertyOferenta] int IDENTITY(1,1) NOT NULL,
    [CenaHurtowa] int  NOT NULL,
    [Egzemplarz_IdEgzemplarza] int  NOT NULL,
    [Oferent_IdOferenta] int  NOT NULL
);
GO

-- Creating table 'Pracowniks'
CREATE TABLE [dbo].[Pracowniks] (
    [IdPracownika] int IDENTITY(1,1) NOT NULL,
    [Imie] nvarchar(max)  NULL,
    [Nazwisko] nvarchar(max)  NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Haslo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Rabats'
CREATE TABLE [dbo].[Rabats] (
    [IdRabatu] int IDENTITY(1,1) NOT NULL,
    [OpisRabatu] nvarchar(max)  NULL,
    [WysokoscRabatu] int  NOT NULL
);
GO

-- Creating table 'RealizacjaZamowienias'
CREATE TABLE [dbo].[RealizacjaZamowienias] (
    [IdRealizacji] int IDENTITY(1,1) NOT NULL,
    [Opis] nvarchar(max)  NULL,
    [StatusZamowienia] nvarchar(max)  NULL
);
GO

-- Creating table 'RealizacjeReklamacjis'
CREATE TABLE [dbo].[RealizacjeReklamacjis] (
    [IdRealizacji] int IDENTITY(1,1) NOT NULL,
    [Opis] nvarchar(max)  NULL
);
GO

-- Creating table 'Reklamacjas'
CREATE TABLE [dbo].[Reklamacjas] (
    [IdReklamacji] int IDENTITY(1,1) NOT NULL,
    [Opis] nvarchar(max)  NULL,
    [Typ] bit  NOT NULL,
    [IdTypu] int  NOT NULL,
    [RealizacjeReklamacji_IdRealizacji] int  NOT NULL
);
GO

-- Creating table 'RodzajWysylkis'
CREATE TABLE [dbo].[RodzajWysylkis] (
    [IdRodzajWysylki] int IDENTITY(1,1) NOT NULL,
    [Cena] int  NOT NULL,
    [Nazwa] nvarchar(max)  NULL
);
GO

-- Creating table 'Wydawnictwoes'
CREATE TABLE [dbo].[Wydawnictwoes] (
    [IdWydawnictwa] int IDENTITY(1,1) NOT NULL,
    [NazwaWydawnictwa] nvarchar(max)  NULL
);
GO

-- Creating table 'Zamowienies'
CREATE TABLE [dbo].[Zamowienies] (
    [IdZamowienia] int IDENTITY(1,1) NOT NULL,
    [KosztZamowienia] int  NOT NULL,
    [Klient_IdKlienta] int  NOT NULL,
    [Pracownik_IdPracownika] int  NOT NULL,
    [Rabat_IdRabatu] int  NOT NULL,
    [RealizacjaZamowienia_IdRealizacji] int  NOT NULL,
    [RodzajuWysylki_IdRodzajWysylki] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAutora] in table 'Autors'
ALTER TABLE [dbo].[Autors]
ADD CONSTRAINT [PK_Autors]
    PRIMARY KEY CLUSTERED ([IdAutora] ASC);
GO

-- Creating primary key on [Autor_IdAutora], [IdKsiazka_IdKsiazki] in table 'AutorzyKsiazkis'
ALTER TABLE [dbo].[AutorzyKsiazkis]
ADD CONSTRAINT [PK_AutorzyKsiazkis]
    PRIMARY KEY CLUSTERED ([Autor_IdAutora], [IdKsiazka_IdKsiazki] ASC);
GO

-- Creating primary key on [IdDostawy] in table 'Dostawas'
ALTER TABLE [dbo].[Dostawas]
ADD CONSTRAINT [PK_Dostawas]
    PRIMARY KEY CLUSTERED ([IdDostawy] ASC);
GO

-- Creating primary key on [IdEgzemplarza] in table 'Egzemplarzs'
ALTER TABLE [dbo].[Egzemplarzs]
ADD CONSTRAINT [PK_Egzemplarzs]
    PRIMARY KEY CLUSTERED ([IdEgzemplarza] ASC);
GO

-- Creating primary key on [IdEgzemplarza], [IdDostawy] in table 'ElementyDostawies'
ALTER TABLE [dbo].[ElementyDostawies]
ADD CONSTRAINT [PK_ElementyDostawies]
    PRIMARY KEY CLUSTERED ([IdEgzemplarza], [IdDostawy] ASC);
GO

-- Creating primary key on [IdEgzemplarza], [IdZamowienia] in table 'ElementyZamowienias'
ALTER TABLE [dbo].[ElementyZamowienias]
ADD CONSTRAINT [PK_ElementyZamowienias]
    PRIMARY KEY CLUSTERED ([IdEgzemplarza], [IdZamowienia] ASC);
GO

-- Creating primary key on [IdGatunku] in table 'Gatuneks'
ALTER TABLE [dbo].[Gatuneks]
ADD CONSTRAINT [PK_Gatuneks]
    PRIMARY KEY CLUSTERED ([IdGatunku] ASC);
GO

-- Creating primary key on [IdKlienta] in table 'Klients'
ALTER TABLE [dbo].[Klients]
ADD CONSTRAINT [PK_Klients]
    PRIMARY KEY CLUSTERED ([IdKlienta] ASC);
GO

-- Creating primary key on [IdKsiazki] in table 'Ksiazkas'
ALTER TABLE [dbo].[Ksiazkas]
ADD CONSTRAINT [PK_Ksiazkas]
    PRIMARY KEY CLUSTERED ([IdKsiazki] ASC);
GO

-- Creating primary key on [IdOferenta] in table 'Oferents'
ALTER TABLE [dbo].[Oferents]
ADD CONSTRAINT [PK_Oferents]
    PRIMARY KEY CLUSTERED ([IdOferenta] ASC);
GO

-- Creating primary key on [IdOfertyOferenta] in table 'OfertaOferentas'
ALTER TABLE [dbo].[OfertaOferentas]
ADD CONSTRAINT [PK_OfertaOferentas]
    PRIMARY KEY CLUSTERED ([IdOfertyOferenta] ASC);
GO

-- Creating primary key on [IdPracownika] in table 'Pracowniks'
ALTER TABLE [dbo].[Pracowniks]
ADD CONSTRAINT [PK_Pracowniks]
    PRIMARY KEY CLUSTERED ([IdPracownika] ASC);
GO

-- Creating primary key on [IdRabatu] in table 'Rabats'
ALTER TABLE [dbo].[Rabats]
ADD CONSTRAINT [PK_Rabats]
    PRIMARY KEY CLUSTERED ([IdRabatu] ASC);
GO

-- Creating primary key on [IdRealizacji] in table 'RealizacjaZamowienias'
ALTER TABLE [dbo].[RealizacjaZamowienias]
ADD CONSTRAINT [PK_RealizacjaZamowienias]
    PRIMARY KEY CLUSTERED ([IdRealizacji] ASC);
GO

-- Creating primary key on [IdRealizacji] in table 'RealizacjeReklamacjis'
ALTER TABLE [dbo].[RealizacjeReklamacjis]
ADD CONSTRAINT [PK_RealizacjeReklamacjis]
    PRIMARY KEY CLUSTERED ([IdRealizacji] ASC);
GO

-- Creating primary key on [IdReklamacji] in table 'Reklamacjas'
ALTER TABLE [dbo].[Reklamacjas]
ADD CONSTRAINT [PK_Reklamacjas]
    PRIMARY KEY CLUSTERED ([IdReklamacji] ASC);
GO

-- Creating primary key on [IdRodzajWysylki] in table 'RodzajWysylkis'
ALTER TABLE [dbo].[RodzajWysylkis]
ADD CONSTRAINT [PK_RodzajWysylkis]
    PRIMARY KEY CLUSTERED ([IdRodzajWysylki] ASC);
GO

-- Creating primary key on [IdWydawnictwa] in table 'Wydawnictwoes'
ALTER TABLE [dbo].[Wydawnictwoes]
ADD CONSTRAINT [PK_Wydawnictwoes]
    PRIMARY KEY CLUSTERED ([IdWydawnictwa] ASC);
GO

-- Creating primary key on [IdZamowienia] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [PK_Zamowienies]
    PRIMARY KEY CLUSTERED ([IdZamowienia] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Autor_IdAutora] in table 'AutorzyKsiazkis'
ALTER TABLE [dbo].[AutorzyKsiazkis]
ADD CONSTRAINT [FK_dbo_AutorzyKsiazkis_dbo_Autors_Autor_IdAutora]
    FOREIGN KEY ([Autor_IdAutora])
    REFERENCES [dbo].[Autors]
        ([IdAutora])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdKsiazka_IdKsiazki] in table 'AutorzyKsiazkis'
ALTER TABLE [dbo].[AutorzyKsiazkis]
ADD CONSTRAINT [FK_dbo_AutorzyKsiazkis_dbo_Ksiazkas_IdKsiazka_IdKsiazki]
    FOREIGN KEY ([IdKsiazka_IdKsiazki])
    REFERENCES [dbo].[Ksiazkas]
        ([IdKsiazki])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AutorzyKsiazkis_dbo_Ksiazkas_IdKsiazka_IdKsiazki'
CREATE INDEX [IX_FK_dbo_AutorzyKsiazkis_dbo_Ksiazkas_IdKsiazka_IdKsiazki]
ON [dbo].[AutorzyKsiazkis]
    ([IdKsiazka_IdKsiazki]);
GO

-- Creating foreign key on [Oferent_IdOferenta] in table 'Dostawas'
ALTER TABLE [dbo].[Dostawas]
ADD CONSTRAINT [FK_dbo_Dostawas_dbo_Oferents_Oferent_IdOferenta]
    FOREIGN KEY ([Oferent_IdOferenta])
    REFERENCES [dbo].[Oferents]
        ([IdOferenta])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Dostawas_dbo_Oferents_Oferent_IdOferenta'
CREATE INDEX [IX_FK_dbo_Dostawas_dbo_Oferents_Oferent_IdOferenta]
ON [dbo].[Dostawas]
    ([Oferent_IdOferenta]);
GO

-- Creating foreign key on [Pracownik_IdPracownika] in table 'Dostawas'
ALTER TABLE [dbo].[Dostawas]
ADD CONSTRAINT [FK_dbo_Dostawas_dbo_Pracowniks_Pracownik_IdPracownika]
    FOREIGN KEY ([Pracownik_IdPracownika])
    REFERENCES [dbo].[Pracowniks]
        ([IdPracownika])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Dostawas_dbo_Pracowniks_Pracownik_IdPracownika'
CREATE INDEX [IX_FK_dbo_Dostawas_dbo_Pracowniks_Pracownik_IdPracownika]
ON [dbo].[Dostawas]
    ([Pracownik_IdPracownika]);
GO

-- Creating foreign key on [IdDostawy] in table 'ElementyDostawies'
ALTER TABLE [dbo].[ElementyDostawies]
ADD CONSTRAINT [FK_dbo_ElementyDostawies_dbo_Dostawas_IdDostawy]
    FOREIGN KEY ([IdDostawy])
    REFERENCES [dbo].[Dostawas]
        ([IdDostawy])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ElementyDostawies_dbo_Dostawas_IdDostawy'
CREATE INDEX [IX_FK_dbo_ElementyDostawies_dbo_Dostawas_IdDostawy]
ON [dbo].[ElementyDostawies]
    ([IdDostawy]);
GO

-- Creating foreign key on [Ksiazka_IdKsiazki] in table 'Egzemplarzs'
ALTER TABLE [dbo].[Egzemplarzs]
ADD CONSTRAINT [FK_dbo_Egzemplarzs_dbo_Ksiazkas_Ksiazka_IdKsiazki]
    FOREIGN KEY ([Ksiazka_IdKsiazki])
    REFERENCES [dbo].[Ksiazkas]
        ([IdKsiazki])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Egzemplarzs_dbo_Ksiazkas_Ksiazka_IdKsiazki'
CREATE INDEX [IX_FK_dbo_Egzemplarzs_dbo_Ksiazkas_Ksiazka_IdKsiazki]
ON [dbo].[Egzemplarzs]
    ([Ksiazka_IdKsiazki]);
GO

-- Creating foreign key on [Wydawnictwo_IdWydawnictwa] in table 'Egzemplarzs'
ALTER TABLE [dbo].[Egzemplarzs]
ADD CONSTRAINT [FK_dbo_Egzemplarzs_dbo_Wydawnictwoes_Wydawnictwo_IdWydawnictwa]
    FOREIGN KEY ([Wydawnictwo_IdWydawnictwa])
    REFERENCES [dbo].[Wydawnictwoes]
        ([IdWydawnictwa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Egzemplarzs_dbo_Wydawnictwoes_Wydawnictwo_IdWydawnictwa'
CREATE INDEX [IX_FK_dbo_Egzemplarzs_dbo_Wydawnictwoes_Wydawnictwo_IdWydawnictwa]
ON [dbo].[Egzemplarzs]
    ([Wydawnictwo_IdWydawnictwa]);
GO

-- Creating foreign key on [IdEgzemplarza] in table 'ElementyDostawies'
ALTER TABLE [dbo].[ElementyDostawies]
ADD CONSTRAINT [FK_dbo_ElementyDostawies_dbo_Egzemplarzs_IdEgzemplarza]
    FOREIGN KEY ([IdEgzemplarza])
    REFERENCES [dbo].[Egzemplarzs]
        ([IdEgzemplarza])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdEgzemplarza] in table 'ElementyZamowienias'
ALTER TABLE [dbo].[ElementyZamowienias]
ADD CONSTRAINT [FK_dbo_ElementyZamowienias_dbo_Egzemplarzs_IdEgzemplarza]
    FOREIGN KEY ([IdEgzemplarza])
    REFERENCES [dbo].[Egzemplarzs]
        ([IdEgzemplarza])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Egzemplarz_IdEgzemplarza] in table 'OfertaOferentas'
ALTER TABLE [dbo].[OfertaOferentas]
ADD CONSTRAINT [FK_dbo_OfertaOferentas_dbo_Egzemplarzs_Egzemplarz_IdEgzemplarza]
    FOREIGN KEY ([Egzemplarz_IdEgzemplarza])
    REFERENCES [dbo].[Egzemplarzs]
        ([IdEgzemplarza])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_OfertaOferentas_dbo_Egzemplarzs_Egzemplarz_IdEgzemplarza'
CREATE INDEX [IX_FK_dbo_OfertaOferentas_dbo_Egzemplarzs_Egzemplarz_IdEgzemplarza]
ON [dbo].[OfertaOferentas]
    ([Egzemplarz_IdEgzemplarza]);
GO

-- Creating foreign key on [IdZamowienia] in table 'ElementyZamowienias'
ALTER TABLE [dbo].[ElementyZamowienias]
ADD CONSTRAINT [FK_dbo_ElementyZamowienias_dbo_Zamowienies_IdZamowienia]
    FOREIGN KEY ([IdZamowienia])
    REFERENCES [dbo].[Zamowienies]
        ([IdZamowienia])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_ElementyZamowienias_dbo_Zamowienies_IdZamowienia'
CREATE INDEX [IX_FK_dbo_ElementyZamowienias_dbo_Zamowienies_IdZamowienia]
ON [dbo].[ElementyZamowienias]
    ([IdZamowienia]);
GO

-- Creating foreign key on [Gatunek_IdGatunku] in table 'Ksiazkas'
ALTER TABLE [dbo].[Ksiazkas]
ADD CONSTRAINT [FK_dbo_Ksiazkas_dbo_Gatuneks_Gatunek_IdGatunku]
    FOREIGN KEY ([Gatunek_IdGatunku])
    REFERENCES [dbo].[Gatuneks]
        ([IdGatunku])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Ksiazkas_dbo_Gatuneks_Gatunek_IdGatunku'
CREATE INDEX [IX_FK_dbo_Ksiazkas_dbo_Gatuneks_Gatunek_IdGatunku]
ON [dbo].[Ksiazkas]
    ([Gatunek_IdGatunku]);
GO

-- Creating foreign key on [Klient_IdKlienta] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [FK_dbo_Zamowienies_dbo_Klients_Klient_IdKlienta]
    FOREIGN KEY ([Klient_IdKlienta])
    REFERENCES [dbo].[Klients]
        ([IdKlienta])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Zamowienies_dbo_Klients_Klient_IdKlienta'
CREATE INDEX [IX_FK_dbo_Zamowienies_dbo_Klients_Klient_IdKlienta]
ON [dbo].[Zamowienies]
    ([Klient_IdKlienta]);
GO

-- Creating foreign key on [Oferent_IdOferenta] in table 'OfertaOferentas'
ALTER TABLE [dbo].[OfertaOferentas]
ADD CONSTRAINT [FK_dbo_OfertaOferentas_dbo_Oferents_Oferent_IdOferenta]
    FOREIGN KEY ([Oferent_IdOferenta])
    REFERENCES [dbo].[Oferents]
        ([IdOferenta])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_OfertaOferentas_dbo_Oferents_Oferent_IdOferenta'
CREATE INDEX [IX_FK_dbo_OfertaOferentas_dbo_Oferents_Oferent_IdOferenta]
ON [dbo].[OfertaOferentas]
    ([Oferent_IdOferenta]);
GO

-- Creating foreign key on [Pracownik_IdPracownika] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [FK_dbo_Zamowienies_dbo_Pracowniks_Pracownik_IdPracownika]
    FOREIGN KEY ([Pracownik_IdPracownika])
    REFERENCES [dbo].[Pracowniks]
        ([IdPracownika])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Zamowienies_dbo_Pracowniks_Pracownik_IdPracownika'
CREATE INDEX [IX_FK_dbo_Zamowienies_dbo_Pracowniks_Pracownik_IdPracownika]
ON [dbo].[Zamowienies]
    ([Pracownik_IdPracownika]);
GO

-- Creating foreign key on [Rabat_IdRabatu] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [FK_dbo_Zamowienies_dbo_Rabats_Rabat_IdRabatu]
    FOREIGN KEY ([Rabat_IdRabatu])
    REFERENCES [dbo].[Rabats]
        ([IdRabatu])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Zamowienies_dbo_Rabats_Rabat_IdRabatu'
CREATE INDEX [IX_FK_dbo_Zamowienies_dbo_Rabats_Rabat_IdRabatu]
ON [dbo].[Zamowienies]
    ([Rabat_IdRabatu]);
GO

-- Creating foreign key on [RealizacjaZamowienia_IdRealizacji] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [FK_dbo_Zamowienies_dbo_RealizacjaZamowienias_RealizacjaZamowienia_IdRealizacji]
    FOREIGN KEY ([RealizacjaZamowienia_IdRealizacji])
    REFERENCES [dbo].[RealizacjaZamowienias]
        ([IdRealizacji])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Zamowienies_dbo_RealizacjaZamowienias_RealizacjaZamowienia_IdRealizacji'
CREATE INDEX [IX_FK_dbo_Zamowienies_dbo_RealizacjaZamowienias_RealizacjaZamowienia_IdRealizacji]
ON [dbo].[Zamowienies]
    ([RealizacjaZamowienia_IdRealizacji]);
GO

-- Creating foreign key on [RealizacjeReklamacji_IdRealizacji] in table 'Reklamacjas'
ALTER TABLE [dbo].[Reklamacjas]
ADD CONSTRAINT [FK_dbo_Reklamacjas_dbo_RealizacjeReklamacjis_RealizacjeReklamacji_IdRealizacji]
    FOREIGN KEY ([RealizacjeReklamacji_IdRealizacji])
    REFERENCES [dbo].[RealizacjeReklamacjis]
        ([IdRealizacji])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Reklamacjas_dbo_RealizacjeReklamacjis_RealizacjeReklamacji_IdRealizacji'
CREATE INDEX [IX_FK_dbo_Reklamacjas_dbo_RealizacjeReklamacjis_RealizacjeReklamacji_IdRealizacji]
ON [dbo].[Reklamacjas]
    ([RealizacjeReklamacji_IdRealizacji]);
GO

-- Creating foreign key on [RodzajuWysylki_IdRodzajWysylki] in table 'Zamowienies'
ALTER TABLE [dbo].[Zamowienies]
ADD CONSTRAINT [FK_dbo_Zamowienies_dbo_RodzajWysylkis_RodzajuWysylki_IdRodzajWysylki]
    FOREIGN KEY ([RodzajuWysylki_IdRodzajWysylki])
    REFERENCES [dbo].[RodzajWysylkis]
        ([IdRodzajWysylki])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_Zamowienies_dbo_RodzajWysylkis_RodzajuWysylki_IdRodzajWysylki'
CREATE INDEX [IX_FK_dbo_Zamowienies_dbo_RodzajWysylkis_RodzajuWysylki_IdRodzajWysylki]
ON [dbo].[Zamowienies]
    ([RodzajuWysylki_IdRodzajWysylki]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------