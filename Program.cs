using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] dados = lerArquivo();
            imprimeMatriz(dados);
            Console.ReadLine();

        }

        static void imprimeMatriz(int[,] matriz)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]);
                    Console.Write(",");

                }
                Console.WriteLine("");
            }
        }

        static int[,] lerArquivo()
        {
 
            int contador = 0;
            string linha;

            System.IO.StreamReader arquivo =
               new System.IO.StreamReader("z:\\coord.txt");
            
            while (arquivo.ReadLine() != null){ contador++;}
            arquivo.Close();

            int[,] dados = new int[contador, 8];

            arquivo =
               new System.IO.StreamReader("z:\\coord.txt");

            contador = 0;
            while ((linha = arquivo.ReadLine()) != null) {
                string[] coordenadas = linha.Split(',');
                for(int i =0; i < 8; i++)
                {
                    if (i < coordenadas.Length)
                    {
                        dados[contador, i] = int.Parse(coordenadas[i]);
                    }
                    else
                    {
                        dados[contador, i] = -1;
                    }
                }
                contador++;
            }
            arquivo.Close();
            return dados;
        }
    }
}
