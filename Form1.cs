using System.Runtime.CompilerServices;

namespace compiler
{
    public partial class Form1 : Form
    {
        List<LexicalComponent> lexicalComponents;

        public Form1()
        {
            InitializeComponent();

            lexicalComponents = new List<LexicalComponent>();
        }

        private void buttonLexicalAnalyzer_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<String>();

            foreach (string line in textBoxInput.Lines)
                lines.Add(line + "$");

            foreach (string line in lines)
                Analyzers.LexicalAnalyze(line, lexicalComponents);

            foreach (LexicalComponent component in lexicalComponents)
                listView1.Items.Add(new ListViewItem(new String[] { component.Lexeme, component.Token, component.Number.ToString() }));

        }
    }
}