using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
	        // A. A Média do aluno - Função
	        // B. A quantidade de Aprovados (Média >=7)
	        // C. A quantidade de Reprovados (Méida < 7)
	        // D. A Média geral dos 10 alunos.

            string[] nome = new string[2];
            float[]media = new float[2];
            float[] notas = new float[4];

            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine();
                for (var a = 0; a < notas.Length; a++)
                {
                    Console.WriteLine($"Digite a {a+1}º nota do aluno:");
                    notas[a]=float.Parse(Console.ReadLine());
                }

                media[i]=(notas[0]+notas[1]+notas[2]+notas[3])/4;
            }

           

            for (var i = 0; i < nome.Length; i++)
            {
                 //Função Media
                Console.WriteLine($"Nome:{nome[i]} Media:{media[i]}");
            }


            
        }
    }
}
