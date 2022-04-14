Create database MUsicList
use MUsicList


create Table Artists(
Id int primary key identity,
[Name] varchar(50),
Surname varchar(50)
)

create Table Albums(
Id int primary key identity,
[Name] varchar(50),
Quality int,
)

create Table Musics(
Id int primary key identity,
[Name] varchar(50),
[Type] varchar(50),
Duration decimal,
AlbumId int Foreign key references Albums(Id)
)

create Table MusicsArtists(
Id int primary key identity,
MusicId int Foreign key references Musics(Id),
ArtistId int Foreign key references Artists(Id)
)

CREATE VIEW MusicView AS
SELECT Musics.Name,Musics.Duration,Artists.Id,Albums.[Name]
FROM Musics
Join Artists
ON Musics.Id=Artists.Id

Join Albums
ON Musics.Id=Albums.Id


CREATE VIEW AlbView AS
SELECT Albums.[Name],Albums.Quality
FROM Musics
Join Albums
ON Musics.Id=Albums.Id






