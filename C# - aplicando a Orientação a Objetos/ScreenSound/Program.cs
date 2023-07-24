Console.Clear();
Genero generoDeMusica = new Genero("Rock");
Genero generoDeMusica2 = new Genero("Pop");
Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");



Musica musica1 = new Musica(queen, "Love of my life", generoDeMusica)
{
    Duracao = 313,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody",generoDeMusica)
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);



generoDeMusica.AdicionarMusica(musica1);
generoDeMusica.AdicionarMusica(musica2);



musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();




Banda ladyGaga = new Banda("Lady Gaga");
Musica musica3 = new Musica(ladyGaga, "Poker Face",generoDeMusica2)
{
    Duracao = 340,
    Disponivel = true,
};
generoDeMusica2.AdicionarMusica(musica3);
musica3.ExibirFichaTecnica();

generoDeMusica.ExibirMusicasDoGenero();
generoDeMusica2.ExibirMusicasDoGenero();



queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();
albumDoQueen.ExibirMusicasDoAlbum();

Console.ReadKey();
Console.Clear();
Episodio episodio = new Episodio(490, 1, "Episódio 1");

episodio.AdicionarConvidados("Afrânio");
episodio.AdicionarConvidados("Viana");

episodio.Resumo();