using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //            int numero1 = 10;
            //            int numero2 = 20;
            //            Calculos Calculos = new Calculos();
            //            Calculos.Soma(numero1, numero2);
            //            Calculos.Multiplica(numero1, numero2);
            //            Analises mega = new Analises();
            //            mega.Analise();




            ConnDb conecta = new ConnDb();

            conecta.abrirPostgress();
            conecta.fecharPostgress();







        }
    }
}
