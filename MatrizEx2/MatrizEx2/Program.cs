using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Xml;

class program {
    static void Main(string[] args) {

        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[m, n];

        for (int i = 0; i < m; i++) {
            string[] value = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++) {
                mat[i, j] = int.Parse(value[j]);
            }
        }

        Console.WriteLine("Matriz Impressa: \n\n");
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write(mat[i, j] + " ");

            }
            Console.WriteLine();
        }

        Console.WriteLine("Escolha um valor da matriz: ");
        int valor = int.Parse(Console.ReadLine());


        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i, j] == valor) {
                    
                    if (j >= 0) {
                        Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                    }
                        else {
                            Console.WriteLine("Ops! o valor sai fora dos limites da matriz");
                        }
                    if (j < n - 1) {
                        Console.WriteLine("Direita: " + mat[i, j + 1]);
                    }
                        else {
                         Console.WriteLine("Ops! o valor sai fora dos limites da matriz");
                        }
                    if (i > 0) {
                        Console.WriteLine("Cima: " + mat[i - 1, j]);
                    }
                        else {
                            Console.WriteLine("Ops! o valor sai fora dos limites da matriz\"");
                        }
                    if (i < m - 1) {
                        Console.WriteLine("Baixo: " + mat[i + 1, j]);
                    }
                        else {
                            Console.WriteLine("Ops! o valor sai fora dos limites da matriz");
                        }
                }

            }

        }

    }
}