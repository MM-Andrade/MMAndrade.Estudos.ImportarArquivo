
using CsvHelper;
using MMandrade.Estudos.ImportarArquivo.ConsoleApp.Mappers;
using MMandrade.Estudos.ImportarArquivo.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MMandrade.Estudos.ImportarArquivo.ConsoleApp.Services
{
    public class EstudanteServices
    {
        public List<Estudante> LerArquivoCSV(string local)
        {
            try
            {
                using (var reader = new StreamReader(local, Encoding.UTF8))
                {
                    using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.RegisterClassMap<EstudanteMap>();
                        var records = csv.GetRecords<Estudante>().ToList();

                        //retorna o valor lido do CSV
                        return records;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EscreverArquivoCSV(string local, List<Estudante> estudantes)
        {
            using (StreamWriter sw = new StreamWriter(local, false, new UTF8Encoding(true)))
            {
                using (CsvWriter csvWriter = new CsvHelper.CsvWriter(sw, System.Globalization.CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<Estudante>();
                    csvWriter.NextRecord();
                    foreach (Estudante est in estudantes)
                    {
                        csvWriter.WriteRecord<Estudante>(est);
                        csvWriter.NextRecord();
                    }
                }
                  
            }
        }
    }
}

