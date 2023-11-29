namespace compiler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonLexicalAnalyzer = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            textBoxSyntaxAnalyzeOutput = new TextBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonSintaxAnalyzer = new Button();
            buttonSemanticAnalyzer = new Button();
            listViewSymbolsTable = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            textBoxGeneratedASM = new TextBox();
            buttonGenerateAsmCode = new Button();
            SuspendLayout();
            // 
            // buttonLexicalAnalyzer
            // 
            buttonLexicalAnalyzer.BackColor = Color.FromArgb(6, 214, 160);
            buttonLexicalAnalyzer.Cursor = Cursors.Hand;
            buttonLexicalAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonLexicalAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLexicalAnalyzer.ForeColor = Color.Black;
            buttonLexicalAnalyzer.Location = new Point(1063, 80);
            buttonLexicalAnalyzer.Name = "buttonLexicalAnalyzer";
            buttonLexicalAnalyzer.Size = new Size(220, 60);
            buttonLexicalAnalyzer.TabIndex = 0;
            buttonLexicalAnalyzer.Text = "Análisis Léxico";
            buttonLexicalAnalyzer.UseVisualStyleBackColor = false;
            buttonLexicalAnalyzer.Click += buttonLexicalAnalyzer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(476, 9);
            label1.Name = "label1";
            label1.Size = new Size(750, 54);
            label1.TabIndex = 1;
            label1.Text = "Compilador - Seminario de Traductores 2";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Font = new Font("Fira Code", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.ForeColor = Color.FromArgb(97, 175, 239);
            textBoxInput.Location = new Point(199, 146);
            textBoxInput.Margin = new Padding(10, 11, 10, 11);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Ingresa el código a analizar:";
            textBoxInput.Size = new Size(550, 250);
            textBoxInput.TabIndex = 0;
            // 
            // textBoxSyntaxAnalyzeOutput
            // 
            textBoxSyntaxAnalyzeOutput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxSyntaxAnalyzeOutput.BorderStyle = BorderStyle.None;
            textBoxSyntaxAnalyzeOutput.Cursor = Cursors.No;
            textBoxSyntaxAnalyzeOutput.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSyntaxAnalyzeOutput.ForeColor = Color.FromArgb(97, 175, 239);
            textBoxSyntaxAnalyzeOutput.Location = new Point(19, 502);
            textBoxSyntaxAnalyzeOutput.Margin = new Padding(10, 11, 10, 11);
            textBoxSyntaxAnalyzeOutput.Multiline = true;
            textBoxSyntaxAnalyzeOutput.Name = "textBoxSyntaxAnalyzeOutput";
            textBoxSyntaxAnalyzeOutput.ReadOnly = true;
            textBoxSyntaxAnalyzeOutput.Size = new Size(550, 250);
            textBoxSyntaxAnalyzeOutput.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.HoverSelection = true;
            listView1.Location = new Point(898, 146);
            listView1.Name = "listView1";
            listView1.Size = new Size(550, 250);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Lexema";
            columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Token";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tipo";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 195;
            // 
            // buttonSintaxAnalyzer
            // 
            buttonSintaxAnalyzer.BackColor = Color.FromArgb(255, 209, 102);
            buttonSintaxAnalyzer.Cursor = Cursors.Hand;
            buttonSintaxAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonSintaxAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSintaxAnalyzer.ForeColor = Color.Black;
            buttonSintaxAnalyzer.Location = new Point(184, 428);
            buttonSintaxAnalyzer.Name = "buttonSintaxAnalyzer";
            buttonSintaxAnalyzer.Size = new Size(220, 60);
            buttonSintaxAnalyzer.TabIndex = 6;
            buttonSintaxAnalyzer.Text = "Análisis Sintáctico";
            buttonSintaxAnalyzer.UseVisualStyleBackColor = false;
            buttonSintaxAnalyzer.Click += buttonSintaxAnalyzer_Click;
            // 
            // buttonSemanticAnalyzer
            // 
            buttonSemanticAnalyzer.BackColor = Color.FromArgb(239, 71, 111);
            buttonSemanticAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonSemanticAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSemanticAnalyzer.Location = new Point(783, 428);
            buttonSemanticAnalyzer.Name = "buttonSemanticAnalyzer";
            buttonSemanticAnalyzer.Size = new Size(220, 60);
            buttonSemanticAnalyzer.TabIndex = 10;
            buttonSemanticAnalyzer.Text = "Análisis Semántico";
            buttonSemanticAnalyzer.UseVisualStyleBackColor = false;
            buttonSemanticAnalyzer.Click += buttonSemanticAnalyzer_Click;
            // 
            // listViewSymbolsTable
            // 
            listViewSymbolsTable.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            listViewSymbolsTable.Location = new Point(618, 502);
            listViewSymbolsTable.Name = "listViewSymbolsTable";
            listViewSymbolsTable.Size = new Size(550, 247);
            listViewSymbolsTable.TabIndex = 11;
            listViewSymbolsTable.UseCompatibleStateImageBehavior = false;
            listViewSymbolsTable.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Variable";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Estatus";
            columnHeader5.Width = 350;
            // 
            // textBoxGeneratedASM
            // 
            textBoxGeneratedASM.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxGeneratedASM.Location = new Point(1209, 502);
            textBoxGeneratedASM.Multiline = true;
            textBoxGeneratedASM.Name = "textBoxGeneratedASM";
            textBoxGeneratedASM.Size = new Size(550, 247);
            textBoxGeneratedASM.TabIndex = 12;
            // 
            // buttonGenerateAsmCode
            // 
            buttonGenerateAsmCode.BackColor = Color.FromArgb(17, 138, 178);
            buttonGenerateAsmCode.FlatStyle = FlatStyle.Popup;
            buttonGenerateAsmCode.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerateAsmCode.ForeColor = Color.Black;
            buttonGenerateAsmCode.Location = new Point(1354, 428);
            buttonGenerateAsmCode.Name = "buttonGenerateAsmCode";
            buttonGenerateAsmCode.Size = new Size(260, 60);
            buttonGenerateAsmCode.TabIndex = 13;
            buttonGenerateAsmCode.Text = "Generador de Código";
            buttonGenerateAsmCode.UseVisualStyleBackColor = false;
            buttonGenerateAsmCode.Click += buttonGenerateAsmCode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 59, 76);
            ClientSize = new Size(1771, 761);
            Controls.Add(buttonGenerateAsmCode);
            Controls.Add(textBoxGeneratedASM);
            Controls.Add(listViewSymbolsTable);
            Controls.Add(buttonSemanticAnalyzer);
            Controls.Add(buttonSintaxAnalyzer);
            Controls.Add(listView1);
            Controls.Add(textBoxSyntaxAnalyzeOutput);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(buttonLexicalAnalyzer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compilador - Seminario de Traductores 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLexicalAnalyzer;
        private Label label1;
        private TextBox textBoxInput;
        private TextBox textBoxSyntaxAnalyzeOutput;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button buttonSintaxAnalyzer;
        private Button buttonSemanticAnalyzer;
        private ListView listViewSymbolsTable;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox textBox1;
        private TextBox textBoxGeneratedASM;
        private Button button1;
        private TextBox textBox2;
        private Button buttonGenerateAsmCode;
    }
}