using System;
using System.Collections.Generic;
using Traveling.Entity;

namespace Traveling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos posts são?");
            int qutdePost = int.Parse(Console.ReadLine());

            List<Post> posts = new List<Post>();


            for(int i = 0; i < qutdePost; i++)
            {
                Console.WriteLine("Digite o Id " + " do post de numero " + (i + 1) + ": ");
                int id = int.Parse(Console.ReadLine());

                DateTime dataAtual = DateTime.Now;

                Console.WriteLine("Escreva o titulo: ");
                string titulo = Console.ReadLine();

                Console.WriteLine("COnteudo: ");
                string conteudo = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de likes: ");
                int like = int.Parse(Console.ReadLine());

                Post post = new Post(id, dataAtual, titulo, conteudo, like);

                posts.Add(post);

                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine();
            }

            foreach (Post post in posts)
            {
                Console.WriteLine("Id: " + post.Id);
                Console.WriteLine("Titulo: " + post.titulo);
                Console.WriteLine(post.like + " Likes - " + post.momento);
                Console.WriteLine("Conteudo: " + post.conteudo);
                Console.WriteLine();
            }

            Console.WriteLine("Selecione qual post vc quer comentar atraves do Id");
            int Id = int.Parse(Console.ReadLine());

            Post post0 = posts.Find(x => x.Id == Id);
            Console.WriteLine("Quantos comentarios vc quer adicionar? ");
            int qtdeCOments = int.Parse(Console.ReadLine());

            for(int i = 0; i < qtdeCOments; i++)
            {
                Console.WriteLine("Digite seu comentario: ");
                string comentario = Console.ReadLine();
                Comentarios comentarios = new Comentarios(comentario);
                post0.addComentarios(comentarios);
                //post0.exibirLista();
            }

            Console.WriteLine("-----------------");

            foreach(Post post in posts)
            {
                Console.WriteLine("Titulo: " + post0.titulo);
                Console.WriteLine();
                
                Console.WriteLine("Momentos e likes: " + post0.like + " Likes - " + post0.momento);
                Console.WriteLine();
                
                Console.WriteLine("Conteudo: "  + post0.conteudo);
                Console.WriteLine();

                post0.exibirLista();
            }

            



        }
    }
}
