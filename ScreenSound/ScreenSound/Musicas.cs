using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musicas
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public GeneroMusical genero;
        public string Descricao {
            get
            {
                return $"A música {Nome} é da banda {Artista}";
            }
                
                }


        public void exibeFichaTecnica()
        {
            Console.WriteLine($"Nome da musica: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            
            if (Disponivel)
            {
                Console.WriteLine("Você está no utilizando o plano premium");
            }else { 
                Console.WriteLine("você está utilizando o plano gratuito");
            }
            Console.WriteLine();
            
        }
    }
}
