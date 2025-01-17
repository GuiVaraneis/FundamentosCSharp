//TAMAGOTCHI

internal class TamagotchiProgram
{

    string nome = "";
    private int alimentado = 50;
    private int limpo = 50;
    private int feliz = 50;

    public string Nome { get => nome; set => nome = value; }
    public int Alimentado { get => alimentado; set => alimentado = value; }
    public int Limpo { get => limpo; set => limpo = value; }
    public int Feliz { get => feliz; set => feliz = value; }
}
class program
{
    public static void main(String[] args)
    {

        Console.WriteLine("aperte qualquer tecla para que nasça o seu bichinho");
        Console.ReadKey();
        Console.Clear();
        Thread.Sleep(3000);

        Console.WriteLine("Pronto! Seu bichinho virtual foi criado");
        Console.WriteLine(@"
            /\_/\
           ( o.o )
            > ^ <
");
        Console.WriteLine("Dê um nome para ele!");
        Console.WriteLine("nome: ");
        nome = Console.ReadLine()!;
        Console.WriteLine($"{nome}, Ótima escolha! vamos cuidar do seu novo companheiro?");
    }
}
