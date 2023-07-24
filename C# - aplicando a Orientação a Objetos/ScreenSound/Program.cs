Console.Clear();

Musica musical1 = new Musica();
musical1.NomeDaMusica = "Faroeste Caboclo";
musical1.Artista = "Legião Urbana";
musical1.Duracao = 540;
musical1.Disponivel = true;

Musica musical2 = new Musica();
musical2.NomeDaMusica = "Roxane";
musical2.Artista = "The Police";
musical2.Duracao = 273;
musical2.Disponivel = false;

musical1.ExibirFichaTecnica();
musical1.ExibirNomeMusicaArtista();

musical2.ExibirFichaTecnica();
musical2.ExibirNomeMusicaArtista();
