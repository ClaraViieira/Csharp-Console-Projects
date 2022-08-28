using System;
using System.Collections.Generic;
using System.Text;

namespace Console2Excecoes.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
