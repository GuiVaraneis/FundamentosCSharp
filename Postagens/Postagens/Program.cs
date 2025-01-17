
using Postagens.Entities;

namespace postagem {
    class Program {
        static void Main(string[] args) {
           Comment c1 = new Comment("Have a nice trip");
           Comment c2 = new Comment("Wow That's awesome!");
           Post p1 = new Post(
               DateTime.Parse("21/06/2018 13:05:24"),
               "Travelling to new Zealand",
               "I'm going to visit this wonderful country",
                12);

            p1.addComment(c1);
            p1.addComment(c2);

            Console.WriteLine(p1);
        
        }
    }
}