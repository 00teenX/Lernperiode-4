CREATE DATABASE Fussballdatenbank;
USE Fussballdatenbank

CREATE TABLE Spieler
(
spielerID INT PRIMARY KEY IDENTITY,
vorname VARCHAR(50) NOT NULL,
nachname VARCHAR(50) NOT NULL,
geburtsdatum DATE,
position VARCHAR(50)
); 

CREATE TABLE Saison
(
saisonID INT PRIMARY KEY IDENTITY,
jahr NVARCHAR(300)
);

CREATE TABLE Tore
(
toreID INT PRIMARY KEY IDENTITY,
spielerID INT FOREIGN KEY REFERENCES Spieler(spielerID),
saisonID INT FOREIGN KEY REFERENCES Saison(saisonID),
anzahlTore INT
);

INSERT INTO Spieler (vorname, nachname, geburtsdatum, position) 
VALUES
('Cristiano', 'Ronaldo', '1985-02-05', 'Stürmer'),
('Kylian', 'Mbappé', '1998-12-20', 'Stürmer'),
('Neymar', 'da Silva Santos Júnior', '1992-02-05', 'Stürmer'),
('Zlatan', 'Ibrahimović', '1981-10-03', 'Stürmer'),
('Diego', 'Maradona', '1960-10-30', 'Mittelfeldspieler'),
('Gareth', 'Bale', '1989-07-16', 'Mittelfeldspieler'),
('Mohamed', 'Salah', '1992-06-15', 'Mittelfeldspieler'),
('Andrés', 'Iniesta', '1984-05-11', 'Mittelfeldspieler'),
('Manuel', 'Neuer', '1986-03-27', 'Torwart'),
('David', 'de Gea', '1990-11-07', 'Torwart'),
('Virgil', 'van Dijk', '1991-07-08', 'Verteidiger'),
('Marcelo', 'Vieira da Silva Júnior', '1988-05-12', 'Verteidiger'),
('Luka', 'Modric', '1985-09-09', 'Mittelfeldspieler'),
('Sergio', 'Ramos', '1986-03-30', 'Verteidiger'),
('Karim', 'Benzema', '1987-12-19', 'Stürmer'),
('Lionel', 'Messi', '1987-06-24', 'Stürmer');

INSERT INTO Saison (jahr) 
VALUES 
('78/79'), ('79/80'), ('80/81'), ('81/82'), ('82/83'), ('83/84'), ('84/85'), ('85/86'), ('86/87'), ('87/88'), ('88/89'), ('89/90'), ('90/91'), ('91/92'), ('92/93'), ('93/94'),
('94/95'), ('95/96'), ('96/97'), ('97/98'), ('98/99'), ('99/00'), ('00/01'), ('01/02'), ('02/03'), ('03/04'), ('04/05'), ('05/06'), ('06/07'), ('07/08'), ('08/09'), ('09/10'),
('10/11'), ('11/12'), ('12/13'), ('13/14'), ('14/15'), ('15/16'), ('16/17'), ('17/18'), ('18/19'), ('19/20'), ('20/21'), ('21/22'), ('22/23');


INSERT INTO Tore (spielerID, saisonID, anzahlTore) VALUES
(5, 1, 8),
(5, 2, 4),
(5, 3, 3),
(5, 4, 2),
(5, 5, 23),
(5, 6, 15),
(5, 7, 17),
(5, 8, 13),
(5, 9, 17),
(5, 10, 21),
(5, 11, 19),
(5, 12, 18),
(5, 13, 10),
(5, 14, 7),
(5, 15, 2);

INSERT INTO Tore (spielerID, saisonID, anzahlTore) VALUES 
(1, 25, 5), 
(1, 26, 6), 
(1, 27, 9), 
(1, 28, 12), 
(1, 29, 23), 
(1, 30, 42), 
(1, 31, 26), 
(1, 32, 33), 
(1, 33, 53), 
(1, 34, 60), 
(1, 35, 55), 
(1, 36, 51), 
(1, 37, 61), 
(1, 38, 51), 
(1, 39, 42), 
(1, 40, 44), 
(1, 41, 28), 
(1, 42, 37), 
(1, 43, 36), 
(1, 44, 24), 
(1, 45, 17);

INSERT INTO Tore (spielerID, saisonID, anzahlTore) VALUES 
(16, 27, 7), 
(16, 28, 8), 
(16, 29, 17), 
(16, 30, 16), 
(16, 31, 38), 
(16, 32, 47), 
(16, 33, 53), 
(16, 34, 73), 
(16, 35, 60), 
(16, 36, 41), 
(16, 37, 58), 
(16, 38, 41), 
(16, 39, 54), 
(16, 40, 45), 
(16, 41, 51), 
(16, 42, 31), 
(16, 43, 38), 
(16, 44, 11), 
(16, 45, 32);

INSERT INTO Tore (spielerID, saisonID, anzahlTore) VALUES 
(2, 38, 4),  
(2, 39, 28), 
(2, 40, 21), 
(2, 41, 39), 
(2, 42, 30), 
(2, 43, 42), 
(2, 44, 39), 
(2, 45, 41);

INSERT INTO Tore (spielerID, saisonID, anzahlTore) VALUES 
(3, 31, 10),  
(3, 32, 19), 
(3, 33, 19), 
(3, 34, 24), 
(3, 35, 1), 
(3, 36, 15), 
(3, 37, 39), 
(3, 38, 31), 
(3, 39, 20), 
(3, 40, 28), 
(3, 41, 23), 
(3, 42, 19), 
(3, 43, 17), 
(3, 44, 13), 
(3, 45, 18);


SELECT * FROM Spieler
SELECT * FROM Tore
SELECT * FROM Saison
