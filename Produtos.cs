using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produtos
    {
        List<Produto> ListaProdutos = new List<Produto>();
  //      Produto p = new Produto();

        public void Adicionar(Produto p)
        {
            ListaProdutos.Add(p);
        }

        public Produto Pesquisar(Produto p)
        {

            if (ListaProdutos.IndexOf(p) >= 0)
                return p;

            else
                return p;
            // Console.WriteLine("X: {0} e Y: {1}", coisinha.X, coisinha.Y);
            // Console.WriteLine("---------------------------");
            //   if (.Equals(outraCoisa))
            //        Console.WriteLine("Mesma coisa");
            //   else
            //       Console.WriteLine("Não é a mesma coisa");


        }


        public bool Remover(Produto p)
        {
            ListaProdutos.Remove(p);
            return true;// nada a ver
        }


        public void mostraLista(List<Produto> lista)
        {
           // List<Produto> listaProdutos;
            foreach (Produto coisinha in lista)
                Console.WriteLine("X: {0} e Y: {1} e Y: {2} e Y: {3}",
                    coisinha.cod, coisinha.desc, coisinha.preco, coisinha.qtd);
            Console.WriteLine("---------------------------");
        }
    }
}
