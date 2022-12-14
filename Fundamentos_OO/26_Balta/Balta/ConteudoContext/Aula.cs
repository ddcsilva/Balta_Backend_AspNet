using Balta.ConteudoContext.Enums;
using Balta.SharedContext;

namespace Balta.ConteudoContext
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
}