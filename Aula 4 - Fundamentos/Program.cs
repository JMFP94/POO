//-----------------------------------------------------------------
// <copyright file="Aula_4.cs" company="IPCA">
// Copyright (c) IPCA-EST 2024. All rights reserved.
// </copyright>
// <date>2024-10-03</date>
// <time>16:00/time>
// <version>0.1</version>
// <author>Juan Peixoto</author>
// <description></description>
//-----------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ma

namespace Aula_4___Fundamentos
{
    internal class Program
    {
        #region ZonaDeTeste
        static void Main(string[] args)
        {
            Console.WriteLine("Teste aula 3");


            //Calculadora
            //Opções: +, -, *, /
            //Pedir apenas dois valores númericos
            //Mostrar resultado arredondado a 2 casas
            //Segundo valor é utilizado 
            //

            //Variaveis
            double primeiroValor = 0.0, segundoValor = 0.0, valorFinal = 0.0;
            string escolha = "";
            bool bIncorreto = "true";

            //Ler e escrever
            Console.WriteLine("1º Valor: ");
            primeiroValor = double.Parse(Console.ReadLine());
            
            Console.WriteLine("2º Valor: ");
            segundoValor = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação possivel ( +, -, *, /): ");
            escolha = Console.ReadLine();

            if (escolha == "+")
            {
                valorFinal = primeiroValor + segundoValor;
            }
            else if (escolha == "-")
            {       
                valorFinal= primeiroValor - segundoValor;   
            }
            else if (escolha == "*") 
            { 
                valorFinal = primeiroValor * segundoValor;
            } 

            else if (escolha == "/")
            {
                valorFinal = primeiroValor / segundoValor;
            }
            else
            {
                Console.WriteLine("Opção incorreta");
                bIncorreto = false;
            }

            Console.WriteLine("Opção incorreta");



            Console.ReadKey();
        }
    }
}
