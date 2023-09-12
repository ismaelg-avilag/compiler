using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiler
{
    internal class Element
    {
        string lexeme;
        string token;
        int number;

        public Element() { }

        public Element(string lexeme, string token, int number)
        {
            this.lexeme = lexeme;
            this.token = token;
            this.number = number;
        }

        public string Lexeme
        {
            get {  return lexeme; }
            set { lexeme = value; }
        }

        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }


    }
}
