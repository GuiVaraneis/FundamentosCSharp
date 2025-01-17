class program {
    static void Main(string[] args) {
        Console.WriteLine("Informe o a hora inicial e a hora final do jogo, respectivamente (0 - 23h): ");
        int horaInicial = int.Parse(Console.ReadLine());
        int horaFinal = int.Parse(Console.ReadLine());

        int duracao;

        if (horaInicial > horaFinal) {

            duracao = horaFinal - horaInicial;
        
        } else if (horaFinal < horaInicial) {
        
            duracao = ((24 - horaInicial) + horaFinal);
        
        } else {
            
            duracao = 24;
        
        }
        
        if (duracao < 1) {
            duracao = 1;
        }if (duracao > 24) {
            duracao = 24;
        }

        Console.WriteLine(duracao);

    }
}