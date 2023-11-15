using System;
using System.CodeDom;
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


        public static bool SyntaxAnalyze(List<LexicalComponent> elements, int[,] parsingTable, int[,] parsingRules)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);

            int elementId = 0;
            int action, rule, pops, row, column;

            bool isValid = false;

            while(elementId < elements.Count) {
                action = parsingTable[stack.Peek(), elements[elementId].Number];

                if (action > 0) {
                    stack.Push(elements[elementId].Number);
                    stack.Push(action);
                    elementId++;
                }
                else if (action == 1) {
                    isValid = true;
                    break;
                }
                else if (action == 0) {
                    isValid = false;
                    break;
                }
                
                else if (action < -1) {
                    rule = (action + 1) * -1;
                    pops = parsingRules[rule, 1];

                    for (int i = 0; i < pops * 2; i++)
                        stack.Pop();

                    row = stack.Peek();
                    column = parsingRules[rule, 0];

                    stack.Push(column);
                    stack.Push(parsingTable[row, column]);
                }
            }

            return isValid;
        }


    }
}
