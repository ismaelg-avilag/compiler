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


        public static Element lexicalAnalyze(string s)
        {
            int state = 0;
            string lexeme = "", token = "";

            for(int i=0; i<s.Length; i++) {
                switch(state) {
                    case 0:
                        if (Char.IsLetter(s[i]) || s[i] == '_') {
                            state = 1;
                            lexeme += s[i];
                            token = Grammar.Identifier.ToString();
                            break;
                        }
                        else if (Char.IsDigit(s[i])) {
                            state = 2;
                            lexeme += s[i];
                            token = Grammar.Number.ToString();
                            break;
                        }
                        else if (s[i] == ';') {
                            state = 4;
                            lexeme += s[i];
                            token = Grammar.Semicolon.ToString();
                            break;
                        }
                        else if (s[i] == ',') {
                            state = 5;
                            lexeme += s[i];
                            token = Grammar.Comma.ToString();
                            break;
                        }
                        else if (s[i] == '(') {
                            state = 6;
                            lexeme += s[i];
                            token = Grammar.LeftParenthesis.ToString();
                            break;
                        }
                        else if (s[i] == ')') {
                            state = 7;
                            lexeme += s[i];
                            token = Grammar.RightParenthesis.ToString();
                            break;
                        }
                        else if (s[i] == '{') {
                            state = 8;
                            lexeme += s[i];
                            token = Grammar.LeftCurlyBrace.ToString();
                            break;
                        }
                        else if (s[i] == '}') {
                            state = 9;
                            lexeme += s[i];
                            token = Grammar.RightCurlyBrace.ToString();
                            break;
                        }
                        else if (s[i] == '$') {
                            state = 10;
                            lexeme += s[i];
                            token = Grammar.DollarSing.ToString();
                            break;
                        }
                        else if (s[i] == '!') {
                            state = 11;
                            lexeme += s[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (s[i] == '>') {
                            state = 12;
                            lexeme += s[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (s[i] == '<') {
                            state = 13;
                            lexeme += s[i];
                            token = Grammar.RelationalOperator.ToString();
                            break;
                        }
                        else if (s[i] == '=') {
                            state = 14;
                            lexeme += s[i];
                            break;
                        }
                        else if (s[i] == '|') {
                            state = 15;
                            lexeme += s[i];
                            token = Grammar.LogicOperator.ToString();
                            break;
                        }
                        else if (s[i] == '&') {
                            state = 16;
                            lexeme += s[i];
                            token = Grammar.LogicOperator.ToString();
                            break;
                        }
                        else if (s[i] == '+' || s[i] == '-') {
                            state = 17;
                            lexeme += s[i];
                            token = Grammar.AdditionOperator.ToString();
                            break;
                        }
                        else if (s[i] == '*' || s[i] == '/') {
                            state = 18;
                            lexeme += s[i];
                            token = Grammar.MultiplicationOperator.ToString();
                            break;
                        }
                        else if(s == "int" || s == "float") {
                            state = 19;
                            lexeme = s;
                            token = Grammar.DataType.ToString();
                            break;
                        }
                        else if(s == "if" || s == "else" || s == "while" || s == "return") {
                            state = 20;
                            lexeme = s;
                            token = Grammar.KeyWord.ToString();
                            break;
                        }
                        else
                            state = -1;
                        break;

                    case 1:
                        if (Char.IsDigit(s[i]) || Char.IsLetter(s[i]) || s[i] == '_') {
                            state = 1;
                            lexeme += s[i];
                            token = Grammar.Identifier.ToString();

                            if (i == s.Length -1)
                                return new Element(lexeme, token, (int)Grammar.Identifier);
                        }
                    break;

                    case 2:
                        if (Char.IsDigit(s[i])) {
                            state = 2;
                            lexeme += s[i];
                            token = Grammar.Number.ToString();
                        }
                        else if (s[i] == '.') {
                            state = 3;
                            lexeme += s[i];
                            token = Grammar.Number.ToString();
                        }
                        else
                            return new Element(lexeme, token, (int)Grammar.Number);
                    break;

                    case 3:
                        if (char.IsDigit(s[i])) {
                            state = 3;
                            lexeme += s[i];
                            token = Grammar.Number.ToString();

                            if (i == s.Length -1)
                                return new Element(lexeme, token, (int)Grammar.Number);
                        }
                    break;

                    case 4: return new Element(lexeme, token, (int)Grammar.Semicolon);

                    case 5: return new Element(lexeme, token, (int)Grammar.Comma);

                    case 6: return new Element(lexeme, token, (int)Grammar.LeftParenthesis);

                    case 7: return new Element(lexeme, token, (int)Grammar.RightParenthesis);

                    case 8: return new Element(lexeme, token, (int)Grammar.LeftCurlyBrace);

                    case 9: return new Element(lexeme, token, (int)Grammar.RightCurlyBrace);

                    case 10: return new Element(lexeme, token, (int)Grammar.DollarSing);

                    case 11:
                        if (s[i] == '=') {
                            lexeme += s[i];
                            return new Element(lexeme, token, (int)Grammar.RelationalOperator);
                        }
                    break;

                    case 12:
                        if (s[i] == '=')
                            lexeme += s[i];
                        return new Element(lexeme, token, (int)Grammar.RelationalOperator);

                    case 13:
                        if (s[i] == '=')
                            lexeme += s[i];
                        return new Element(lexeme, token, (int)Grammar.RelationalOperator);

                    case 14:
                        if (s[i] == '=') {
                            lexeme += s[i];
                            token = Grammar.RelationalOperator.ToString();
                            return new Element(lexeme, token, (int)Grammar.RelationalOperator);
                        }
                        token = Grammar.AssignmentOperator.ToString();
                        return new Element(lexeme, token, (int)Grammar.AssignmentOperator);

                    case 15:
                        if (s[i] == '|') {
                            lexeme += s[i];
                            return new Element(lexeme, token, (int)Grammar.LogicOperator);
                        }
                    break;

                    case 16:
                        if (s[i] == '|') {
                            lexeme += s[i];
                            return new Element(lexeme, token, (int)Grammar.LogicOperator);
                        }
                    break;

                    case 17: return new Element(lexeme, token, (int)Grammar.AdditionOperator);

                    case 18: return new Element(lexeme, token, (int)Grammar.MultiplicationOperator);

                    case 19: return new Element(lexeme, token, (int)Grammar.DataType);

                    case 20: return new Element(lexeme, token, (int)Grammar.KeyWord);

                    case -1: return null;
                }
            }
            return null;
        }


    }
}
