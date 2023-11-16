using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
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
            DollarSing = 3,
            AssignmentOperator = 4,
            AdditionOperator = 5,
            MultiplicationOperator = 6,
        }


        public static void LexicalAnalyze(string line, List<LexicalComponent> elements)
        {
            int state = 0;
            string lexeme = "";

            for(int i=0; i<line.Length; i++) {
                switch(state) {
                    case 0:
                        if (line[i] == ' ' || line[i] == '\t' || line[i] == '\n') {
                            state = 0; lexeme = "";
                        }

                        else if (Char.IsLetter(line[i]) || line[i] == '_') {
                            state = 1;
                            lexeme += line[i];

                            if (!Char.IsDigit(line[i + 1]) && !Char.IsLetter(line[i + 1]) && line[i + 1] != '_') {
                                elements.Add(new LexicalComponent(lexeme, Grammar.Identifier.ToString(), (int)Grammar.Identifier));

                                state = 0; lexeme = "";
                            }
                        }
                        else if (Char.IsDigit(line[i])) {
                            state = 2;
                            lexeme += line[i];

                            if (!Char.IsDigit(line[i + 1]) || line[i] != '.') {
                                elements.Add(new LexicalComponent(lexeme, Grammar.Number.ToString(), (int)Grammar.Number));
                                state = 0; lexeme = "";
                            }
                        }
                        else if (line[i] == ';') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.Semicolon.ToString(), (int)Grammar.Semicolon));
                            state = 0; lexeme = "";
                        }
                        else if (line[i] == '$') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.DollarSing.ToString(), (int)Grammar.DollarSing));
                            state = 0; lexeme = "";
                        }
                        else if (line[i] == '=') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.AssignmentOperator.ToString(), (int)Grammar.AssignmentOperator));

                            state = 0; lexeme = "";
                        }
                        else if (line[i] == '+' || line[i] == '-') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.AdditionOperator.ToString(), (int)Grammar.AdditionOperator));
                            state = 0; lexeme = "";
                        }
                        else if (line[i] == '*' || line[i] == '/') {
                            lexeme += line[i];
                            elements.Add(new LexicalComponent(lexeme, Grammar.MultiplicationOperator.ToString(), (int)Grammar.MultiplicationOperator));
                            state = 0; lexeme = "";
                        }
                    break;

                    case 1:
                        if (Char.IsDigit(line[i]) || Char.IsLetter(line[i]) || line[i] == '_') {
                            state = 1;
                            lexeme += line[i];
                            
                            if (!Char.IsDigit(line[i+1]) && !Char.IsLetter(line[i+1]) && line[i+1] != '_') {
                                elements.Add(new LexicalComponent(lexeme, Grammar.Identifier.ToString(), (int)Grammar.Identifier));
                                state = 0; lexeme = "";
                            }
                        }

                    break;

                    case 2:
                        if (Char.IsDigit(line[i])) {
                            state = 2;
                            lexeme += line[i];
                        }
                        else if (line[i] == '.') {
                            state = 3;
                            lexeme += line[i];
                        }
                        else {
                            elements.Add(new LexicalComponent(lexeme, Grammar.Number.ToString(), (int)Grammar.Number));
                            state = 0; lexeme = "";
                        }
                    break;

                    case 3:
                        if (char.IsDigit(line[i])) {
                            state = 3;
                            lexeme += line[i];
                        }
                        else {
                            elements.Add(new LexicalComponent(lexeme, Grammar.Number.ToString(), (int)Grammar.Number));
                            state = 0; lexeme = "";
                        }
                    break;

                }
            }
        }


        public static bool SyntaxAnalyze(List<LexicalComponent> elements)
        {
            bool isValid = false;
            int state = 0;

            for(int i = 0; i < elements.Count; i++) {
                switch(state) {
                    case 0:
                        if (elements[i].Number == (int)Grammar.Identifier)
                            state = 1;
                        else
                            state = -1;
                    break;
                    
                    case 1:
                        if (elements[i].Number == (int)Grammar.AssignmentOperator)
                            state = 2;
                        else
                            state = -1;
                    break;

                    case 2:
                        if (elements[i].Number == (int)Grammar.Identifier)
                            state = 3;
                        
                        else if (elements[i].Number == (int)Grammar.Number)
                            state = 4;
                        
                        else
                            state = -1;
                    break;
                    
                    case 3:
                        if (elements[i].Number == (int)Grammar.AdditionOperator || elements[i].Number == (int)Grammar.MultiplicationOperator)
                            state = 5;
                        
                        else if (elements[i].Number == (int)Grammar.Semicolon)
                            state = 6;

                        else
                            state = -1;
                    break;

                    case 4:
                        if (elements[i].Number == (int)Grammar.AdditionOperator || elements[i].Number == (int)Grammar.MultiplicationOperator)
                            state = 5;

                        else if (elements[i].Number == (int)Grammar.Semicolon)
                            state = 6;

                        else
                            state = -1;
                    break;

                    case 5:
                        if (elements[i].Number == (int)Grammar.Identifier)
                            state = 3;

                        else if (elements[i].Number == (int)Grammar.Number)
                            state = 4;

                        else
                            state = -1;
                        break;

                    case 6:
                        if (elements[i].Number == (int)Grammar.DollarSing)
                            isValid = true;
                        
                        state = -1;
                    break;
                }

                if (state == -1)
                    break;
            }

            return isValid;
        }

        public static void SemanticAnalyze(List<LexicalComponent> elements, List<SemanticSymbol> symbolsTable)
        {
            for(int i = 0; i < elements.Count; i++) {
                if (elements[i].Number == (int)Grammar.Identifier && elements[i+1].Number == (int)Grammar.AssignmentOperator)
                    symbolsTable.Add(new SemanticSymbol(elements[i].Lexeme, "Se declaró la variable " + elements[i].Lexeme));
            }
        }


    }
}
