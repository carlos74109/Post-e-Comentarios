using System;
using System.Collections.Generic;

namespace Traveling.Entity
{
    internal class Post
    {
        public int Id;
        public DateTime momento = DateTime.Now;
        public string titulo;
        public string conteudo;
        public int like;
        public List<Comentarios> comentarios { get; set; } = new List<Comentarios>();
        public Comentarios comentario;
        public Post()
        {
        }

        public Post(int id, DateTime momento, string titulo, string conteudo, int like)
        {
            this.Id = id;
            this.like = like;
            this.momento = momento;
            this.titulo = titulo;
            this.conteudo = conteudo;
        }

        public void addComentarios(Comentarios comentario)
        {
            comentarios.Add(comentario);
        }

        public void exibirLista()
        {
            foreach (Comentarios comentario in comentarios)
            {
                Console.WriteLine("Comentarios:" + comentario.comentario);
                Console.WriteLine();
            }
        }
    }
}
