using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleExcecoes.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
