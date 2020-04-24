using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Analises{

        public void Analise(){
        //  int seq = 6;
            int i;

            string[] conjNum = new string[60];
              
            Numeros Num = new Numeros();

            conjNum = Num.Num();

            Console.WriteLine("Classe Analises");

            for (i = 0; i < conjNum.Length; i++){

                
                if (i % 7 == 0){
                    //Console.WriteLine(conjNum[i]);
                    Console.WriteLine("--------------------------------");
                }else{
                    Console.WriteLine(conjNum[i]);
                    //Console.WriteLine("--------------------------------");
                }
                



            }
        }





    }
}
