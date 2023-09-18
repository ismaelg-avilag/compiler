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
            Identifier = 0,
            Number = 1,
            Semicolon = 2,
            Comma = 3,
            LeftParenthesis = 4,
            RightParenthesis = 5,
            LeftCurlyBrace = 6,
            RightCurlyBrace = 7,
            DollarSing = 8,
            RelationalOperator = 9,
            AssignmentOperator = 10,
            LogicOperator = 11,
            AdditionOperator = 12,
            MultiplicationOperator = 13,
            DataType = 14,
            KeyWord = 15
        }


        public static void LexicalAnalyze(string line, List<LexicalElement> elements)
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
                                if (lexeme == "int" || lexeme == "float")
                                    elements.Add(new LexicalElement(lexeme, Grammar.DataType.ToString(), (int)Grammar.DataType));

                                else if (lexeme == "if" || lexeme == "else" || lexeme == "while" || lexeme == "return")
                                    elements.Add(new LexicalElement(lexeme, Grammar.KeyWord.ToString(), (int)Grammar.KeyWord));

                                else
                                    elements.Add(new LexicalElement(lexeme, token, (int)Grammar.Identifier));

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
                            elements.Add(new LexicalElement(lexeme, Grammar.Semicolon.ToString(), (int)Grammar.Semicolon));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == ',') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.Comma.ToString(), (int)Grammar.Comma));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '(') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.LeftParenthesis.ToString(), (int)Grammar.LeftParenthesis));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == ')') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.RightParenthesis.ToString(), (int)Grammar.RightParenthesis));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '{') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.LeftCurlyBrace.ToString(), (int)Grammar.LeftCurlyBrace));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '}') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.RightCurlyBrace.ToString(), (int)Grammar.RightCurlyBrace));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '$') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.DollarSing.ToString(), (int)Grammar.DollarSing));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '!') {
                            state = 11;
                            lexeme += line[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (line[i] == '>') {
                            state = 12;
                            lexeme += line[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (line[i] == '<') {
                            state = 13;
                            lexeme += line[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (line[i] == '=') {
                            state = 14;
                            lexeme += line[i];
                            break;
                        }
                        else if (line[i] == '|') {
                            state = 15;
                            lexeme += line[i];
                            token = Grammar.LogicOperator.ToString();
                            break;
                        }
                        else if (line[i] == '&') {
                            state = 16;
                            lexeme += line[i];
                            token = Grammar.LogicOperator.ToString();
                            break;
                        }
                        else if (line[i] == '+' || line[i] == '-') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.AdditionOperator.ToString(), (int)Grammar.AdditionOperator));
                            state = 0; lexeme = ""; token = "";
                            break;
                        }
                        else if (line[i] == '*' || line[i] == '/') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, Grammar.MultiplicationOperator.ToString(), (int)Grammar.MultiplicationOperator));
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
                                if (lexeme == "int" || lexeme == "float")
                                    elements.Add(new LexicalElement(lexeme, Grammar.DataType.ToString(), (int)Grammar.DataType));

                                else if (lexeme == "if" || lexeme == "else" || lexeme == "while" || lexeme == "return")
                                    elements.Add(new LexicalElement(lexeme, Grammar.KeyWord.ToString(), (int)Grammar.KeyWord));

                                else
                                    elements.Add(new LexicalElement(lexeme, token, (int)Grammar.Identifier));

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
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.Number));
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
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.Number));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 11:
                        if (line[i] == '=') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.RelationalOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 12:
                        if (line[i] == '=') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.RelationalOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 13:
                        if (line[i] == '=') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.RelationalOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 14:
                        if (line[i] == '=') {
                            lexeme += line[i];
                            token = Grammar.RelationalOperator.ToString();
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.RelationalOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                        else {
                            token = Grammar.AssignmentOperator.ToString();
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.AssignmentOperator));
                        }
                        state = 0; lexeme = ""; token = "";
                    break;

                    case 15:
                        if (line[i] == '|') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.LogicOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;

                    case 16:
                        if (line[i] == '|') {
                            lexeme += line[i];
                            elements.Add(new LexicalElement(lexeme, token, (int)Grammar.LogicOperator));
                            state = 0; lexeme = ""; token = "";
                        }
                    break;
                }
            }
        }


    }
}
