Console.Clear();

Album albumDoQueen = new Album();
Genero generoDeMusica = new Genero();
generoDeMusica.NomeDoGenero =  "Rock";

albumDoQueen.NomeDoAlbum = "A night at the opera";

Musica musica1 = new Musica();
musica1.NomeDaMusica = "Love of my life";
musica1.Duracao = 213;
musica1.Artista = "Queen";

Musica musica2 = new Musica();
musica2.NomeDaMusica = "Bohemian Rhapsody";
musica2.Duracao = 354;
musica2.Artista = "Queen";

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

generoDeMusica.AdicionarMusica(musica1);
generoDeMusica.AdicionarMusica(musica2);

generoDeMusica.ExibirMusicasDoGenero();