using System.Globalization;
class program {


    static void Main(string[] args) {
        
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) {
            Console.Write($"informe a {i}º nota: ");
            string[] line = Console.ReadLine().Split(' ');

            double n1 = double.Parse(line[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(line[0], CultureInfo.InvariantCulture);
            double n3 = double.Parse(line[0], CultureInfo.InvariantCulture);

            double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                
        }

        

    }
}