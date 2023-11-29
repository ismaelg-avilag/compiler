using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace compiler
{
    public partial class Form1 : Form
    {
        private List<List<LexicalComponent>> lexicalComponents;
        private List<string> variables;
        private List<string> variablesStatus;

        public Form1()
        {
            InitializeComponent();

            lexicalComponents = new List<List<LexicalComponent>>();
            variables = new List<string>();
            variablesStatus = new List<string>();
        }

        private void buttonLexicalAnalyzer_Click(object sender, EventArgs e)
        {
            lexicalComponents.Clear();
            listView1.Items.Clear();

            List<string> lines = new List<String>();

            foreach (string line in textBoxInput.Lines)
                lines.Add(line + "$");

            foreach (string line in lines)
            {
                List<LexicalComponent> lineComponents = new List<LexicalComponent>();
                lexicalComponents.Add(lineComponents);
                Analyzers.LexicalAnalyze(line, lineComponents);
            }

            foreach (List<LexicalComponent> lineComponentes in lexicalComponents)
                foreach (LexicalComponent component in lineComponentes)
                    listView1.Items.Add(new ListViewItem(new String[] { component.Lexeme, component.Token, component.Number.ToString() }));
        }

        private void buttonSintaxAnalyzer_Click(object sender, EventArgs e)
        {
            textBoxSyntaxAnalyzeOutput.Clear();

            List<LexicalComponent> lineComponents;
            for (int i = 0; i < lexicalComponents.Count; i++)
            {
                lineComponents = lexicalComponents[i];

                if (Analyzers.SyntaxAnalyze(lineComponents))
                    textBoxSyntaxAnalyzeOutput.AppendText("El texto ingresado en la línea " + (i + 1) + " es válido");
                else
                    textBoxSyntaxAnalyzeOutput.AppendText("El texto ingresado en la línea " + (i + 1) + " no es válido \n");

                textBoxSyntaxAnalyzeOutput.AppendText(Environment.NewLine);
            }
        }

        private void buttonSemanticAnalyzer_Click(object sender, EventArgs e)
        {
            listViewSymbolsTable.Items.Clear();
            variables.Clear();
            variablesStatus.Clear();

            foreach (List<LexicalComponent> lineComponentes in lexicalComponents)
                Analyzers.SemanticAnalyze(lineComponentes, variables, variablesStatus);

            for (int i = 0; i < variables.Count; i++)
                listViewSymbolsTable.Items.Add(new ListViewItem(new String[] { variables[i], variablesStatus[i] }));
        }

        private void buttonGenerateAsmCode_Click(object sender, EventArgs e)
        {
            textBoxGeneratedASM.Clear();

            textBoxGeneratedASM.AppendText(".MODEL SMALL" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".STACK" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".DATA" + Environment.NewLine);
            textBoxGeneratedASM.AppendText(".CODE" + Environment.NewLine + Environment.NewLine);

            textBoxGeneratedASM.AppendText("MAIN:" + Environment.NewLine + Environment.NewLine);

            foreach (List<LexicalComponent> lineComponentes in lexicalComponents)
                foreach (AsmInstruction instruction in Generator.GenerateAsm(lineComponentes))
                    textBoxGeneratedASM.AppendText(instruction.ToString() + Environment.NewLine);

            textBoxGeneratedASM.AppendText(Environment.NewLine + "END MAIN");
        }
    }
}