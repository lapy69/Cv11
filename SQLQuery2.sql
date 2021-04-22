DELETE FROM Predmety
DELETE FROM Studenti
DELETE FROM SpojovaciTabulka
DELETE FROM Hodnoceni

--DROP TABLE SpojovaciTabulka
--DROP TABLE Hodnoceni

CREATE TABLE Predmety (Zkratka varchar(3) PRIMARY KEY, Nazev varchar(50), )
CREATE TABLE Studenti (Jmeno varchar(30), Prijmeni varchar(30), Datum_narozeni date, ID int PRIMARY KEY)

INSERT INTO Predmety(Zkratka,Nazev)VALUES ('OOP','Objektově orientované programování')
INSERT INTO Predmety(Zkratka,Nazev)VALUES ('AN4','Angličtina pro bakaláře')
INSERT INTO Predmety(Zkratka,Nazev)VALUES ('DIO','Digitální obvody')

INSERT INTO Studenti(Jmeno,Prijmeni,Datum_narozeni,ID)VALUES ('Petr','Novák','2000-06-02',220113)
INSERT INTO Studenti(Jmeno,Prijmeni,Datum_narozeni,ID)VALUES ('Adam','Novák','2000-03-14',220813)
INSERT INTO Studenti(Jmeno,Prijmeni,Datum_narozeni,ID)VALUES ('Pavel','Novotný','2000-08-03',220148)
INSERT INTO Studenti(Jmeno,Prijmeni,Datum_narozeni,ID)VALUES ('Petr','Skácel','2000-02-21',220286)
INSERT INTO Studenti(Jmeno,Prijmeni,Datum_narozeni,ID)VALUES ('Eva','Joeová','1999-12-19',220083)

CREATE TABLE SpojovaciTabulka(Zkratka varchar(3), ID int, PRIMARY KEY (Zkratka, ID), FOREIGN KEY (Zkratka) REFERENCES Predmety(Zkratka), FOREIGN KEY (ID) REFERENCES Studenti(ID))

INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('DIO',220113)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('AN4',220113)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('OOP',220113)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('DIO',220813)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('AN4',220813)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('AN4',220148)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('OOP',220148)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('OOP',220286)
INSERT INTO SpojovaciTabulka(Zkratka,ID)VALUES ('OOP',220083)

CREATE TABLE Hodnoceni (Zkratka varchar(3), ID int, PRIMARY KEY (Zkratka, ID), FOREIGN KEY (Zkratka) REFERENCES Predmety (Zkratka), FOREIGN KEY (ID) REFERENCES Studenti(ID), datum_hodnoceni date, hodnoceni float)

INSERT INTO Hodnoceni (Zkratka,ID) SELECT Zkratka, ID FROM SpojovaciTabulka

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-02'  WHERE ID = 220113 AND Zkratka = 'DIO'
UPDATE Hodnoceni SET hodnoceni = 1  WHERE ID = 220113 AND Zkratka = 'DIO'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-02'  WHERE ID = 220113 AND Zkratka = 'AN4'
UPDATE Hodnoceni SET hodnoceni = 2  WHERE ID = 220113 AND Zkratka = 'AN4'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-02'  WHERE ID = 220113 AND Zkratka = 'OOP'
UPDATE Hodnoceni SET hodnoceni = 1.5  WHERE ID = 220113 AND Zkratka = 'OOP'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-03'  WHERE ID = 220813 AND Zkratka = 'DIO'
UPDATE Hodnoceni SET hodnoceni = 2.5  WHERE ID = 220813 AND Zkratka = 'DIO'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-03'  WHERE ID = 220813 AND Zkratka = 'AN4'
UPDATE Hodnoceni SET hodnoceni = 2  WHERE ID = 220813 AND Zkratka = 'AN4'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-04'  WHERE ID = 220148 AND Zkratka = 'AN4'
UPDATE Hodnoceni SET hodnoceni = 1  WHERE ID = 220148 AND Zkratka = 'AN4'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-04'  WHERE ID = 220148 AND Zkratka = 'OOP'
UPDATE Hodnoceni SET hodnoceni = 1.5  WHERE ID = 220148 AND Zkratka = 'OOP'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-04'  WHERE ID = 220286 AND Zkratka = 'OOP'
UPDATE Hodnoceni SET hodnoceni = 2  WHERE ID = 220286 AND Zkratka = 'OOP'

UPDATE Hodnoceni SET datum_hodnoceni = '2021-05-04' WHERE ID = 220083 AND Zkratka = 'OOP'
UPDATE Hodnoceni SET hodnoceni = 1  WHERE ID = 220083 AND Zkratka = 'OOP'

SELECT Studenti.*, SpojovaciTabulka.Zkratka FROM Studenti LEFT JOIN SpojovaciTabulka ON Studenti.ID = SpojovaciTabulka.ID
