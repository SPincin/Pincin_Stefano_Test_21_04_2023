CREATE DATABASE Arts;
GO

USE Arts;
GO

CREATE TABLE MUSEUM (
    Id_Museum INT NOT NULL PRIMARY KEY,
    MuseumName VARCHAR(100) NOT NULL,
    City VARCHAR(100) NOT NULL
);

CREATE TABLE ARTIST (
    Id_Artist INT PRIMARY KEY NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Country VARCHAR(100) NOT NULL
);

CREATE TABLE CHARACTER (
    ID_Character INT PRIMARY KEY,
    Name VARCHAR(100)
);

CREATE TABLE ARTWORK (
    ID_Artwork INT PRIMARY KEY NOT NULL,
    Name VARCHAR(100)NOT NULL,
    ID_Museum INT NOT NULL,
    ID_Artist INT NOT NULL,
    ID_Character INT NULL,
    FOREIGN KEY (ID_Museum) REFERENCES MUSEUM(Id_Museum),
    FOREIGN KEY (ID_Artist) REFERENCES ARTIST(Id_Artist),
    FOREIGN KEY (ID_Character) REFERENCES CHARACTER(ID_Character)
);


INSERT INTO MUSEUM (Id_Museum, MuseumName, City)
VALUES 
    (1, 'Santa Maria Gloriosa dei Frari', 'Venezia'),
    (2, 'Louvre', 'Parigi'),
    (3, 'Galleria Borghese', 'Roma'),
    (4, 'Art Institute of Chicago', 'Chicago');

INSERT INTO ARTIST (Id_Artist, Name, Country)
VALUES
    (1, 'Tiziano Vecellio', 'Italia'),
    (2, 'Caravaggio', 'Italia'),
    (3, 'Picasso', 'Spagna');

INSERT INTO CHARACTER (ID_Character, Name)
VALUES
    (1, 'Flora'),
    (2, 'Davide'),
    (3, 'Chitarrista');

	INSERT INTO ARTWORK (ID_Artwork, Name, ID_Museum, ID_Artist, ID_Character)
VALUES
    (1, 'Flora', 1, 1, 1),
    (2, 'Concerto campestre', 2, 1, NULL),
    (3, 'Davide con la testa di Golia', 3, 2, 2),
    (4, 'Il vecchio chitarrista cieco', 4, 3, 3);

--Prima query--

SELECT M.MuseumName, A.Name AS ArtistName, AW.Name AS ArtworkName, C.Name AS CharacterName
FROM MUSEUM M
JOIN ARTWORK AW ON AW.ID_Museum = M.Id_Museum
JOIN ARTIST A ON A.Id_Artist = AW.ID_Artist
LEFT JOIN CHARACTER C ON C.ID_Character = AW.ID_Character
WHERE A.Country = 'Italia'

--Seconda query--
SELECT A.Name, AW.Name
FROM ARTIST A
JOIN ARTWORK AW ON A.Id_Artist = AW.Id_Artist
JOIN MUSEUM M ON AW.Id_Museum = M.Id_Museum
WHERE M.City = 'Parigi';

--Terza query--

SELECT M.City
FROM MUSEUM M
INNER JOIN ARTWORK AW ON AW.ID_Museum = M.Id_Museum
WHERE AW.Name ='Flora'