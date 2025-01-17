


class program {

    static void Main(string[] args) {
        Console.Write("Informe sua senha: ");
        int senha = int.Parse(Console.ReadLine());

        while (senha != 2002) {
            Console.Write("Senha incorreta!\nTente novamente:");
            senha = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Senha correta!");
    }

}