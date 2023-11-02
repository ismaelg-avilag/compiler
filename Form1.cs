using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace compiler
{
    public partial class Form1 : Form
    {
        private List<List<LexicalComponent>> lexicalComponents;
        private int[,] parsingTable;
        private int[,] parsingRules;

        public Form1()
        {
            InitializeComponent();

            lexicalComponents = new List<List<LexicalComponent>>();
            parsingTable = loadParsingTable();
            parsingRules = loadParsingRules();
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

                if (Analyzers.SyntaxAnalyze(lineComponents, parsingTable, parsingRules))
                    textBoxSyntaxAnalyzeOutput.AppendText("El texto ingresado en la línea " + (i + 1) + " es válido");
                else
                    textBoxSyntaxAnalyzeOutput.AppendText("El texto ingresado en la línea " + (i + 1) + " no es válido \n");

                textBoxSyntaxAnalyzeOutput.AppendText(Environment.NewLine);
            }
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

        private int[,] loadParsingTable()
        {
            int rows = 84, columns = 39;
            int[,] parsingTable = new int[rows, columns];

            string[] lines = File.ReadAllLines("../../../SyntaxAnalyzeAuxFiles/SLR-Table-id.txt");

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split('\t');

                for (int j = 0; j < columns; j++)
                    if (int.TryParse(values[j], out int parsedValue))
                        parsingTable[i, j] = parsedValue;
            }

            return parsingTable;
        }

        private int[,] loadParsingRules()
        {
            int rows = 43, columns = 2;
            int[,] parsingRules = new int[rows, columns];

            string[] lines = File.ReadAllLines("../../../SyntaxAnalyzeAuxFiles/SLR-Rules-id.txt");

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split('\t');

                for (int j = 0; j < columns; j++)
                    if (int.TryParse(values[j], out int parsedValue))
                        parsingRules[i, j] = parsedValue;
            }

            return parsingRules;
        }

    }
}