using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroCSharpGuiaProgramador_Estudo
{
    class Program
    {
        struct Texto
        {
            public string txt;
            public int num;
        }
        public static void Main()
        {
            Console.Clear();
            int i;
            // Cria um array de objects
            object[] array = new object[6];
            Texto linha = new Texto();
            linha.txt = "String ";
            linha.num = 0;
            // Armazena valores do tipo int
            for (i = 0; i < 3; i++)
                array[i] = i;
            // Armazena valores do tipo Texto
            for (int j = i; j < 6; j++)
            {
                linha.num++;
                array[j] = linha.txt + linha.num;
            }
            // Exibe o array de objects
            Console.WriteLine("Array de objects");
            for (int j = 0; j < array.Length; j++)
                Console.WriteLine("[{0}] {1}", j, array[j]);

            Console.ReadLine();
        }
    }
}
