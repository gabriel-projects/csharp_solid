using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.LeitorArquivo
{
    public interface ILeitorArquivo
    {
        void Ler(string path);
    }

    public class LeitorTxt : ILeitorArquivo
    {
        public void Ler(string path)
        {
            throw new NotImplementedException();
        }
    }

    public class Test
    {
        private readonly ILeitorArquivo LeitorArquivo;

        public Test(ILeitorArquivo leitorArquivo)
        {
            LeitorArquivo = leitorArquivo;
        }

        public void Ler(string path)
        {
            LeitorArquivo.Ler(path);
        }
    }
}
