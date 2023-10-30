using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace compiler
{
    internal class Analyzers
    {

        enum Grammar
        {
            DataType = 0,
            Identifier = 1,
            Semicolon = 2,
            Comma = 3,
            LeftParenthesis = 4,
            RightParenthesis = 5,
            LeftCurlyBrace = 6,
            RightCurlyBrace = 7,
            AssignmentOperator = 8,
            If = 9,
            While = 10,
            Return = 11,
            Else = 12,
            Number = 13,
            AdditionOperator = 14,
            LogicOperator = 15,
            MultiplicationOperator = 16,
            RelationalOperator = 17,
            DollarSing = 18
        }


        public static void LexicalAnalyze(string line, List<LexicalComponent> elements)
        {
            int state = 0;
            string lexeme = "", token = "";

            for(int i=0; i<line.Length; i++) {
                switch(state) {
                    case 0:
                        if (Char.IsLetter(line[i]) || line[i] == '_') {
                            state = 1;
                            lexeme += line[i];
                            token = Grammar.Identifier.ToString();

                            if (!Char.IsDigit(line[i + 1]) && !Char.IsLetter(line[i + 1]) && line[i + 1] != '_') {
                                elements.Add(new LexicalComponent(lexeme, token, (int)Grammar.Identifier));

                                state = 0; lexeme = ""; token = "";
                            }

                        break;
                        }
                        else if (Char.IsDigit(line[i])) {
                            state = 2;
                            lexeme += line[i];
                            token = Grammar.Number.ToString();
                            break;
                        }
                        else if (line[i] == ';') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.Semicolon.ToString(), (int)Grammar.Semicolon));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '(') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.LeftParenthesis.ToString(), (int)Grammar.LeftParenthesis));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == ')') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.RightParenthesis.ToString(), (int)Grammar.RightParenthesis));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '$') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.DollarSing.ToString(), (int)Grammar.DollarSing));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '=') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.AssignmentOperator.ToString(), (int)Grammar.AssignmentOperator));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '+' || line[i] == '-') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.AdditionOperator.ToString(), (int)Grammar.AdditionOperator));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '*' || line[i] == '/') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.MultiplicationOperator.ToString(), (int)Grammar.MultiplicationOperator));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                    break;

                    case 1:
                        if (Char.IsDigit(line[i]) || Char.IsLetter(line[i]) || line[i] == '_') {
                            state = 1;
                            lexeme += line[i];
                            token = Grammar.Identifier.ToString();
                            
                            if (!Char.IsDigit(line[i+1]) && !Char.IsLetter(line[i+1]) && line[i+1] != '_') {
                                elements.Add(new LexicalComponent(lexeme, token, (int)Grammar.Identifier));

                                state = 0; lexeme = ""; token = "";
                            }
                        }

                    break;

                    case 2:
                        if (Char.IsDigit(line[i])) {
                            state = 2;
                            lexeme += line[i];
                            token = Grammar.Number.ToString();
                        }
                        else if (line[i] == '.') {
                            state = 3;
                            lexeme += line[i];
                            token = Grammar.Number.ToString();
                        }
                        else {
                            elements.Add(new LexicalComponent(lexeme, token, (int)Grammar.Number));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 3:
                        if (char.IsDigit(line[i])) {
                            state = 3;
                            lexeme += line[i];
                            token = Grammar.Number.ToString();
                        }
                        else {
                            elements.Add(new LexicalComponent(lexeme, token, (int)Grammar.Number));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                }
            }
        }


    }
}
