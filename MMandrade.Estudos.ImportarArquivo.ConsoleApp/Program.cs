using System;
using System.IO;
using System.Reflection;
using MMandrade.Estudos.ImportarArquivo.ConsoleApp.Models;
using MMandrade.Estudos.ImportarArquivo.ConsoleApp.Services;

namespace MMandrade.Estudos.ImportarArquivo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicializando a leitura do arquivo CSV");
            
            var _estudanteService = new EstudanteServices();
            //var caminho = @"./MMandrade.Estudos.ImportarArquivo.ConsoleApp/Estudante.csv";
            var caminhoLeitura = @"../../../Estudante.csv";
            var caminhoEscrita = @"../../../ArquivoEscrito.csv";

            //Faz a chamada da função para leitura do arquivo CSV
             var resultData = _estudanteService.LerArquivoCSV(caminhoLeitura);

            //Gravação de um arquivo CSV
            //Criar um objeto estudante:
            Estudante estudante = new Estudante();
                estudante.Id = 4;
                estudante.Nome = "Aluno de teste";
                estudante.Curso = "Analise e desenvolvimento de sistemas";
                estudante.ValorMensalidades = 25000;
                estudante.Celular = "00123456";
                estudante.Cidade = "Mogi das Cruzes";
                resultData.Add(estudante);

                //Chamada da função para escrita do CSV
                _estudanteService.EscreverArquivoCSV(caminhoEscrita, resultData);
                
                Console.WriteLine("Arquivo gravado");




        }
    }
}
