using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiler
{
    internal class SemanticSymbol
    {
        string symbol;
        string status;

        public SemanticSymbol() { }

        public SemanticSymbol(string symbol, string status)
        {
            this.symbol = symbol;
            this.status = status;
        }

        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

    }
}
