﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            comma = 3,
            LeftParenthesis = 4,
            RightParenthesis = 5,
            LeftCurlyBrace = 6,
            RightCurlyBrace = 7,
            DollarSing = 8,
            RelationalOperator = 9,
            Assignment = 10,
            LogicOperator = 11,
            AdditionOperator = 12,
            MultiplicationOperator = 13,
            DataType = 14,
            KeyWord = 15
        }


        public static Element lexicalAnalyze(string s)
        {
            int state = 0;
            string lexeme = "", token = "error";

            for(int i=0; i<s.Length; i++) {
                switch(state) {
                    case 0:
                    break;

                    case 1: break;

                    case 2: break;

                    case 3: break;

                    case 4: break;

                    case 5: break;

                    case 6: break;

                    case 7: break;

                    case 8: break;

                    case 9: break;

                    case 10: break;

                    case 11: break;

                    case 12: break;

                    case 13: break;

                    case 14: break;

                    case 15: break;

                    case 16: break;

                    case 17: break;

                    case 18: break;

                    case 19: break;

                    case 21: break;

                    case 22: break;

                    case 23: break;

                    case 24: break;

                    case 25: break;

                    case 26: break;

                }
            }


        }

    }
}