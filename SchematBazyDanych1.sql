Use Master 
Go
Drop DataBase WypozyczalniaLodzi
Go

Create Database WypozyczalniaLodzi
Go

Use WypozyczalniaLodzi
Go

Create Table Klienci
(
	  IdKlienta Integer Identity
	, Imie Varchar (100) Not Null
	, Nazwisko Varchar (200) Not Null
	, Adres Varchar (500) Not Null
	, Pesel Decimal (11, 0) Not Null
	, Telefon Decimal (9, 0)
	, Email Varchar (200)
	, UprawnieniaId Integer
	, Haslo Varchar (50) Not Null

	,Constraint PK_Klienci Primary Key (IdKlienta)
)
Go

Insert Into Klienci (Imie, Nazwisko, Adres, Pesel, Telefon, Email, UprawnieniaId, Haslo)
Values 
	  ('Beata', 'Grzybek', 'Piwna 14 87-123 Gdynia', '87101723472', '678453213','muchomor@wp.pl', '2', '$$aj321')
	, ('Aneta', 'Knypek', 'Garbatych 7 88-712 Gdañsk', '87091856771', '514247891', NULL, '2', 'Spodenki998')
	, ('Gabriela', '£amaga', 'Wybitnych 3/4 87-153 Gdynia', '85031277652', '665432456', 'Piknagabi@onet.pl', '1', 'Musk321')
	, ('Zbygniew', 'Leniwy', 'Szyderców 25 88-521 Sopot', '68111145600', '887657901', '',  '2', 'Niechemisie123')
	, ('Anna', 'Martwa', 'Cmentarna 18 84-124 Gdynia', '85041277682', '889367666', 'Drogadoziemi@wp.pl', '2', 'deadOralive!')

Create Table Uprawnienia
(
	  IdUprawnien Integer Identity
	, NazwaUprawnien Varchar (200) Not Null

	, Constraint PK_Uprawnienia Primary Key (IdUprawnien)
)
Go

Insert Into Uprawnienia (NazwaUprawnien)
Values ('Pracownik'), ('Klient'), ('Administrator')

Create Table Pracownicy
(
	  IdPracownika Integer Identity
	, Imie Varchar (100) Not Null
	, Nazwisko Varchar (200) Not Null
	, Adres Varchar (500) Not Null
	, Pesel Decimal (11, 0) Not Null
	, Telefon Decimal (9, 0)
	, UprawnieniaId Integer
	, Haslo Varchar (50) Not Null

	,Constraint PK_Pracownicy Primary Key (IdPracownika)
	,Constraint FK_Pracownicy_Uprawnienia Foreign Key (UprawnieniaId) References Uprawnienia (IdUprawnien)
)
Go

Insert Into Pracownicy (Imie, Nazwisko, Adres, Pesel, Telefon, UprawnieniaId, Haslo)
Values 
	  ('Maciej', 'Zadziorny', 'Kotliny 23/5 82-212 Gdañsk', '78041612472', '700884112', '2', 'krety123')
	, ('Bartek', 'Knypek', 'Garbatych 7 88-712 Gdañsk', '85071156772', '514321123', '1', 'UkrytyTrabant')
	, ('Barbara', 'Krutka', 'Krzywego 12 65-123 Sopot', '89042699852', '678882123', '1', 'Wetwetwet')
	, ('Kinga', 'Rusin', 'Polna 2/5 Kraków 61-100', '62121906100', '700084974', '1', 'R3jcz3l')
	, ('Marcin', 'Kowalczuk', 'Krabia 24 81-666 Gdynia', '70032556482', '700380400', '1', 'fear123')

Create Table Magazyny
(
	  IdMagazynu Integer Identity
	, NazwaMagazynu Varchar (200) Not Null
	, Adres Varchar (200) Not Null

	, Constraint PK_Magazyny Primary Key (IdMagazynu)
)
Go

Insert Into Magazyny (NazwaMagazynu, Adres)
Values ('G³ówny', 'Gdynia'), ('Wycieczkowe', 'Gdañsk')


Create Table Lodzie
(
	  IdLodzi Integer Identity
	, NazwaLodzi Varchar (200) Not Null
	, Model Varchar (200) Not Null
	, CenaWynajmu Decimal (16, 2) Not Null
	, Stan Integer Not Null
	, MagazynyId Integer

	, Constraint PK_Lodzie Primary Key (IdLodzi)
	, Constraint FK_Lodzie_Magazyny Foreign Key (MagazynyId) References Magazyny (IdMagazynu)
)
Go

Insert Into Lodzie (NazwaLodzi, Model, CenaWynajmu, Stan, MagazynyId)
Values 
	  ('Shenfunkel 1', 'G-123', '2500', '1', '1')
	, ('Shenfunkel 2', 'G-123', '2500', '1', '1')
	, ('Ziberon 1', 'Prenola', '3000', '2', '2')
	, ('Shenfunkel 3', 'G-123', '1700', '1', '2')
	, ('Ziberon 2', 'Royal', '3200', '2', '1')

Create Table Rezerwacje
(
	  IdRezerwacji Integer Identity (1, 1)
	, LodzieId Integer
	, PracownicyId Integer
	, KlienciId Integer
	, DataWynajmu Date
	, DataZwrotu Date
	, Zakonczona Bit Default 0

	, Constraint PK_Rezerwacje Primary Key (IdRezerwacji)
	, Constraint FK_Rezerwacje_Lodzie Foreign Key (LodzieId) References Lodzie (IdLodzi)
	, Constraint FK_Rezerwacje_Pracownicy Foreign Key (PracownicyId) References Pracownicy (IdPracownika)
	, Constraint FK_Rezerwacje_Klienci Foreign Key (KlienciId) References Klienci (IdKlienta)
)
Go

Insert Into Rezerwacje (LodzieId, PracownicyId, KlienciId, DataWynajmu, DataZwrotu)
Values 
	  ('1', '2', '3', '08/10/2014', '08/15/2014')
	, ('2', '4', '1', '06/11/2014', NULL)