using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject_BDD.CustomException {
    public class NoSuitableDriverFoundException : Exception {
        public NoSuitableDriverFoundException(string message) : base(message) { }
    }
}
