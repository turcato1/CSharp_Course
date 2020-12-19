using System;

namespace Ex01_Excecoes.Entities
{
    class DomainException : ApplicationException
    {
        public DomainException(string message)
            : base(message)
        {
        }
    }
}
