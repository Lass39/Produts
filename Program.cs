using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos pts = new Produtos();
            Produto pt = new Produto();

            
            int op = 0;
            int cod;
            string desc;
            int qtd;
            double preco;

            do
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("|            MENU              |");
                Console.WriteLine("| ============================ |");
                Console.WriteLine("| 0 - Sair                     |");
                Console.WriteLine("| 1 - Adicionar Produto        |");
                Console.WriteLine("| 2 - Excluir Produto          |");
                Console.WriteLine("| 3 - Pesquisar Produto        |");
                Console.WriteLine("| 4 - Listar Produtos          |");
                Console.WriteLine("================================");
                Console.Write("Escolha uma opcao:   ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                            Console.WriteLine("Programa Finalizado !!!!!");
                            break;
                    case 1:
                        Console.Write("Insira o Codigo do Produto:  ");
                        cod = int.Parse(Console.ReadLine());
                        Console.Write("Insira a descrição do Produto:  ");
                        desc = Console.ReadLine();
                        Console.Write("Insira a Quantidade:  ");
                        qtd = int.Parse(Console.ReadLine());
                        Console.Write("Insira o Valor: R$ ");
                        preco = double.Parse(Console.ReadLine());
                        //pt.cod = cod;
                        //pt.desc = desc;
                        //pt.qtd = qtd;
                        //pt.preco = preco;

                        //Produto pt = new pt(cod, desc, qtd, preco); // da erro essa porra *****************
                        pt(cod, desc, qtd, preco);
                        pts.Adicionar(pt);
                        break;

                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:// listar produtos
                           //pts.mostraLista(pts.ListaProdutos); //krlho
                        Console.WriteLine("\nCodigo do Produto: {0} ", pt.cod);

                        Console.WriteLine("Descrição do Produto: {0}  ", pt.desc);

                        Console.WriteLine("Quantidade:  {0}", pt.qtd);

                        Console.WriteLine("Valor: R$ {0} ", pt.preco);

                        Console.WriteLine("Custo: R$ {0} ", pt.Custo());

                        break;

                }



            } while (op != 0);




            Console.ReadKey();
        }
    }
}
