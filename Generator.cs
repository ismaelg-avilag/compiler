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
        public static List<AsmInstruction> GenerateAsm(List<LexicalComponent> elements)
        {
            List<AsmInstruction> asmInstructions = new List<AsmInstruction>();

            for (int i = 0; i < elements.Count; i++) {
                if (elements[i].Token == "Identifier" && elements[i + 1].Token == "AssignmentOperator") {
                    string destination = elements[i].Lexeme;

                    // Handle the right-hand side of the assignment
                    if (elements[i + 2].Token == "Number") {
                        // Asignación de número
                        asmInstructions.Add(new AsmInstruction("MOV", destination, elements[i + 2].Lexeme));

                    }
                    else if (elements[i + 2].Token == "Identifier") {
                        // Asignación de identificador
                        asmInstructions.Add(new AsmInstruction("MOV", destination, elements[i + 2].Lexeme));

                    }
                    else if (elements[i + 2].Token == "AdditionOperator" || 
                               elements[i + 2].Token == "SubstractionOperator" ||
                               elements[i + 2].Token == "MultiplicationOperator" ||
                               elements[i + 2].Token == "DivisionOperator") {
                        // Asignación con operación
                        string tempReg = "EAX";  // Puedes usar otro registro temporal si es necesario
                        asmInstructions.Add(new AsmInstruction("MOV", tempReg, elements[i + 2].Lexeme));
                        asmInstructions.Add(new AsmInstruction("MOV", destination, tempReg));
                    }
                    i += 2;
                }
                else if (elements[i].Token == "AdditionOperator" ||
                         elements[i].Token == "SubstractionOperator" ||
                         elements[i].Token == "MultiplicationOperator" ||
                         elements[i].Token == "DivisionOperator") {


                    // Operaciones aritméticas
                    string destination = elements[i - 1].Lexeme;
                    string tempReg = "EAX";  // Puedes usar otro registro temporal si es necesario

                    if (elements[i + 1].Token == "Number" || elements[i + 1].Token == "Identifier") {
                        asmInstructions.Add(new AsmInstruction("MOV", tempReg, elements[i + 1].Lexeme));
                        // Generar la instrucción de la operación correspondiente
                        switch (elements[i].Token) {
                            case "AdditionOperator":
                                asmInstructions.Add(new AsmInstruction("ADD", destination, tempReg));
                                break;
                            case "SubstractionOperator":
                                asmInstructions.Add(new AsmInstruction("SUB", destination, tempReg));
                                break;
                            case "MultiplicationOperator":
                                asmInstructions.Add(new AsmInstruction("MUL", destination, tempReg));
                                break;
                            case "DivisionOperator":
                                asmInstructions.Add(new AsmInstruction("DIV", tempReg));
                                asmInstructions.Add(new AsmInstruction("MOV", destination, "EAX"));
                                break;
                        }
                        i += 1;
                    }
                }
            }


            return asmInstructions;
        }
    }   

}
