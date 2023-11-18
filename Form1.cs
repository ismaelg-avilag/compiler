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
        private void buttonBlackBox_Click(object sender, EventArgs e)
        {
            string[] lines = new string[4];

            lines[0] = "int a 0;";
            lines[1] = "int a =;";
            lines[2] = "if else";
            lines[3] = "int a = 0";

            textBoxInput.Text = "";
            textBoxInput.Lines = lines;
        }

        private void buttonWhiteBox_Click(object sender, EventArgs e)
        {
            string[] lines = new string[4];

            lines[0] = "int a = 0;";
            lines[1] = "float area;";
            lines[2] = "b = 0.001";
            lines[3] = "while(1)";

            textBoxInput.Text = "";
            textBoxInput.Lines = lines;
        }

    }
}