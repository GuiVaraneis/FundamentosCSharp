using ScreenSound;
Banda beatles = new Banda("Beatles");


Album AlbumDoQueen = new Album();

AlbumDoQueen.Nome = "At Night Of The Opera";

Musicas musica1 = new Musicas();

musica1.Nome = "bohemian rhapsody";

Musicas musica2 = new Musicas();
musica2.Nome = "Love of my life";

AlbumDoQueen.AdicionarMusica(musica1);
AlbumDoQueen.AdicionarMusica(musica2);

AlbumDoQueen.ExibirMusicasDoAlbum();