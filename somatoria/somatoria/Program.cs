class Progam
{
    static void Main(string[] args)
    {

        int n1;
        int n2;
        Console.WriteLine("Somar dois Valores");
        Console.WriteLine("Digite valor 1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite valor 2: ");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Os números digitados foram: ", n1, " e ", n2);
        int resultado = n1 + n2;
        Console.WriteLine("A soma entre os dois valores é de: ", resultado);
    }
}
    