using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FONTE DE DADOS
            var listaProdutos = new List<Produto>()
            {
                new Produto() { Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100 },
                new Produto() { Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 100 },
                new Produto() { Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 100 },
                new Produto() { Id = 4, CategoriaId = 1, Nome = "TV", Status = true, Valor = 100 },
                new Produto() { Id = 5, CategoriaId = 1, Nome = "Maquina de Lavar", Status = false, Valor = 100 },
                new Produto() { Id = 6, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 100 },
                new Produto() { Id = 7, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 100 },
                new Produto() { Id = 8, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 100 },
                new Produto() { Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 100 }
            };

            var listCategoria = new List<Categoria>()
            {
                new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
                new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
                new Categoria{Id = 3, Status = true, Nome = "Vestuario"}
            };


            var result = from produto in listaProdutos
                         group produto by produto.Status into produtosAgrupados
                         select produtosAgrupados;




            //EXECUTAR A CONSULTA

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var prod in item)
                {
                    Console.WriteLine($"Produto: {prod.Nome} | Categoria: {prod.CategoriaId}");
                }
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }

    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }

    class ProdutoDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}
