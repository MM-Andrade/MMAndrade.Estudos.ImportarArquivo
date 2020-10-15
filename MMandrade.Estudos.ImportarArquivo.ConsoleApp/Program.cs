using System;
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
            var caminho = @"../MMandrade.Estudos.ImportarArquivo.ConsoleApp/Estudante.csv";

            //Faz a chamada da função para leitura do arquivo CSV
             var resultData = _estudanteService.LerArquivoCSV(caminho);

            //Gravação de um arquivo CSV
            //Criar um objeto estudante:
            Estudante estudante = new Estudante();
                estudante.Id = 3;
                estudante.Nome = "Aluno de teste";
                estudante.Curso = "Analise e desenvolvimento de sistemas";
                estudante.ValorMensalidades = 25000;
                estudante.Celular = "055111234567890";
                estudante.Cidade = "Mogi das Cruzes";
                resultData.Add(estudante);

                //Chamada da função para escrita do CSV
                _estudanteService.EscreverArquivoCSV(@"../MMandrade.Estudos.ImportarArquivo.ConsoleApp/ArquivoEscrito.csv",resultData);
                
                Console.WriteLine("Arquivo gravado");




        }
    }
}
