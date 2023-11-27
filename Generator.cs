using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compiler
{
    internal class AsmInstruction
    {
        public string Instruction { get; set; }
        public string Operand1 { get; set; }
        public string Operand2 { get; set; }

        public AsmInstruction(string instruction, string operand1, string operand2 = "")
        {
            Instruction = instruction;
            Operand1 = operand1;
            Operand2 = operand2;
        }

        public override string ToString()
        {
            return $"{Instruction} {Operand1}{(Operand2 != "" ? ", " + Operand2 : "")}";
        }
    }

    internal class Generator
    {
        public static List<AsmInstruction> Generate(List<LexicalComponent> elements)
        {
            List<AsmInstruction> asmInstructions = new List<AsmInstruction>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Token == "Identifier" && elements[i + 1].Token == "AssignmentOperator")
                {
                    asmInstructions.Add(new AsmInstruction("mov", elements[i].Lexeme, elements[i + 2].Lexeme));
                    i += 2;
                }
                else if (elements[i].Token == "Identifier" && elements[i + 1].Token == "AdditionOperator")
                {
                    asmInstructions.Add(new AsmInstruction("add", elements[i].Lexeme, elements[i + 2].Lexeme));
                    i += 2;
                }
                else if (elements[i].Token == "Identifier" && elements[i + 1].Token == "MultiplicationOperator")
                {
                    asmInstructions.Add(new AsmInstruction("mul", elements[i].Lexeme, elements[i + 2].Lexeme));
                    i += 2;
                }
                else if (elements[i].Token == "Identifier" && elements[i + 1].Token == "Semicolon")
                {
                    asmInstructions.Add(new AsmInstruction("push", elements[i].Lexeme));
                    asmInstructions.Add(new AsmInstruction("pop", "eax"));
                    i += 1;
                }
            }

            return asmInstructions;
        }
    }   

}
