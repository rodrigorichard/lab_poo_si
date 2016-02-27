using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Monitor
    {
        private float tamanho;
        private Fabricante fabricante;
        private string modelo;
        private bool ligado = false;
        private CPU cpu;
        private string serial;

        public void ligar()
        {
            this.ligado = true;
            //Conecte com a internet e mande dados pessoais do usuario
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public bool isLigado()
        {
            return this.ligado;
        }
    }
}
