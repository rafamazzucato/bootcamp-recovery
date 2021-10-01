using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Repository.Impl
{
    public class TesteImpl : ITeste
    {
        public void Mensagem()
        {
            Console.WriteLine("Realizando teste de DI");
        }
    }
}
