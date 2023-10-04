using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Valiuta
    {
        int valiuta;
        int centai;

        public Valiuta (int valiuta, int centai)
        {
            this.valiuta = valiuta;
            this.centai = centai;
        }

        public int imtivaliuta() { return valiuta; }
        public int imticentus() { return centai; }  
    }
    internal class Program
    {
         const int Cn = 100;
            const string Cfd = "TextFile1.txt";
            const string Cfz = "TextFile2.txt";
        static void Main(string[] args)
        {

            Valiuta [] a = new Valiuta[Cn];
            Valiuta[] b = new Valiuta[Cn];


        }

        static void skaityti (string fv, int valiuta, int centai, Valiuta[] a, Valiuta[] b)
        {
            int valiutaa;
            int centaiaa;

            using (StreamReader reader = new StreamReader(fv))
            {
                string line;
                line = reader.ReadLine();
                string[] parts;
                valiuta = int.Parse(line);
                centai = int.Parse(line);
               
            }

        }
        static int Anupropinigai(int valiuta, int centai, Valiuta[]a, Valiuta[]b )
        {
            int suma = 0;


        }

        static int Barborospinigai(int valiuta, int centai)
        {

        }
    }
}
