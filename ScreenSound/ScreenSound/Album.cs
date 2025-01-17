using ScreenSound;

class Album
{   
    List<Musicas> musicas = new List<Musicas>();
    public string Nome { get; set;}

    public int DuracaoTotal { get; set; }
    
    public void AdicionarMusica(Musicas musica) {
        musicas.Add(musica);
    }
public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Músicas do album {Nome}\n");
        Console.WriteLine($"Musicas: "); 
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
    }
}
