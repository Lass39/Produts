using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produto
    {


        public int cod { get; set; }
        public string desc { get; set; }
        public int qtd { get; set; }
        public double preco { get; set; }

        public double Custo()
        {
            return qtd * preco;
        }

        public Produto()
        {
            this.cod = 0;
            this.desc = "";
            this.qtd = 0;
            this.preco = 0;
        }

        public Produto(int x, string y, int w, double z)
        {
            this.cod = x;
            this.desc = y;
            this.qtd = w;
            this.preco = z;

        }
        



        //public override bool Equals(object obj)
        //{
        //    return cod == ((Produto)obj).cod;
        //}

    }
}
