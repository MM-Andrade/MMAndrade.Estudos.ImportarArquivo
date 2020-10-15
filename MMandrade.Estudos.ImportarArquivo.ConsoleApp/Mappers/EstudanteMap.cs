using CsvHelper.Configuration;
using MMandrade.Estudos.ImportarArquivo.ConsoleApp.Models;

namespace MMandrade.Estudos.ImportarArquivo.ConsoleApp.Mappers
{
    public sealed class EstudanteMap : ClassMap<Estudante>
    {
        public EstudanteMap()
        {
            Map(x => x.Id).Name("Id");
            Map(x => x.Nome).Name("Nome");
            Map(x => x.Curso).Name("Curso");
            Map(x => x.ValorMensalidades).Name("Mensalidades");
            Map(x => x.Celular).Name("Celular");
            Map(x => x.Cidade).Name("Cidade");
        }
    }
}
