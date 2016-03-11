using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CPU
    {
        private Fabricante fabricante;
        private Memoria[] memoria;
        private Armazenamento[] armazenamento;
        private Processador processador;
        private Monitor monitor;
        private Teclado teclado;

        internal Fabricante Fabricante
        {
            get
            {
                return fabricante;
            }

            set
            {
                fabricante = value;
            }
        }

        internal Memoria[] Memoria
        {
            get
            {
                return memoria;
            }

            set
            {
                memoria = value;
            }
        }

        internal Armazenamento[] Armazenamento
        {
            get
            {
                return armazenamento;
            }

            set
            {
                armazenamento = value;
            }
        }

        internal Processador Processador
        {
            get
            {
                return processador;
            }

            set
            {
                processador = value;
            }
        }

        internal Monitor Monitor
        {
            get
            {
                Console.WriteLine("Tem alguem usando o monitor!!!");
                return monitor;
            }

            set
            {
                Console.WriteLine("Um monitor acabou se ser conectado a cpu");
                monitor = value;
            }
        }

        internal Teclado Teclado
        {
            get
            {
                return teclado;
            }

            set
            {
                teclado = value;
            }
        }
    }
}
