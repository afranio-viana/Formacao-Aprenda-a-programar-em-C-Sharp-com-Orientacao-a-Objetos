Console.Clear();

Musica musical1 = new Musica();
musical1.nomeDaMusica = "Faroeste Caboclo";
musical1.artista = "Legião Urbana";
musical1.duracao = 540;
musical1.disponivel = true;

Musica musical2 = new Musica();
musical2.nomeDaMusica = "Roxane";
musical2.artista = "The Police";
musical2.duracao = 273;
musical2.disponivel = false;

musical1.ExibirFichaTecnica();
musical2.ExibirFichaTecnica();

musical1.ExibirNomeMusicaArtista();
musical2.ExibirNomeMusicaArtista();
