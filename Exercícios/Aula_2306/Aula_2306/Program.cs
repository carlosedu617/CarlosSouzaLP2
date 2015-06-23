using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;


namespace Aula_2306
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] nome = new string[n];
            int[] cpf = new int[n];
            int[] nasc = new int[n];
            int[] admis = new int[n];
            double[] slatual = new double[n];
            double[] slnovo = new double[n];
            
            for(int i = 0; i < n; i++)
            {
                nome[i] = Console.ReadLine();
                cpf[i] = int.Parse(Console.ReadLine());
                nasc[i] = int.Parse(Console.ReadLine());
                admis[i] = int.Parse(Console.ReadLine());
                slatual[i] = double.Parse(Console.ReadLine());

            }

            for (int i = 0; i < n; i++)
            { 
                if (admis[i] >= 2014)
                {
                    slnovo[i] = slatual[i] + 423.45;
                 }
                else if(admis[i] >= 2010 && admis[i] <= 2013)
                {
                    slnovo[i] = slatual[i] + (9.84 / 100)*slatual[i];
                }
                else if (admis[i] >= 2000 && admis[i] <= 2009)
                {
                    slnovo[i] = slatual[i]+ slatual[i] * (16.4 / 100);
                 }
                else
                {
                    slnovo[i] = slatual[i]+ slatual[i] * (22.6 / 100);
                }

            }
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(nome[i]);
                Console.WriteLine(cpf[i]);
                Console.WriteLine(nasc[i]);
                Console.WriteLine(admis[i]);
                Console.WriteLine(slatual[i]);
                Console.WriteLine(slnovo[i]);
            }
            Console.ReadLine();


        }
    }
}
