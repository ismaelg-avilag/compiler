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
            SuspendLayout();
            // 
            // buttonLexicalAnalyzer
            // 
            buttonLexicalAnalyzer.BackColor = Color.FromArgb(6, 214, 160);
            buttonLexicalAnalyzer.Cursor = Cursors.Hand;
            buttonLexicalAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonLexicalAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLexicalAnalyzer.ForeColor = Color.Black;
            buttonLexicalAnalyzer.Location = new Point(222, 315);
            buttonLexicalAnalyzer.Name = "buttonLexicalAnalyzer";
            buttonLexicalAnalyzer.Size = new Size(180, 70);
            buttonLexicalAnalyzer.TabIndex = 0;
            buttonLexicalAnalyzer.Text = "Analizador Léxico";
            buttonLexicalAnalyzer.UseVisualStyleBackColor = false;
            buttonLexicalAnalyzer.Click += buttonLexicalAnalyzer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(823, 60);
            label1.TabIndex = 1;
            label1.Text = "Compilador - Seminario de Traductores 2";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.ForeColor = Color.FromArgb(97, 175, 239);
            textBoxInput.Location = new Point(14, 95);
            textBoxInput.Margin = new Padding(5);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Ingresa el código a analizar:";
            textBoxInput.Size = new Size(1254, 173);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxSyntaxAnalyzeOutput
            // 
            textBoxSyntaxAnalyzeOutput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxSyntaxAnalyzeOutput.BorderStyle = BorderStyle.None;
            textBoxSyntaxAnalyzeOutput.Cursor = Cursors.No;
            textBoxSyntaxAnalyzeOutput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSyntaxAnalyzeOutput.ForeColor = Color.Red;
            textBoxSyntaxAnalyzeOutput.Location = new Point(664, 425);
            textBoxSyntaxAnalyzeOutput.Multiline = true;
            textBoxSyntaxAnalyzeOutput.Name = "textBoxSyntaxAnalyzeOutput";
            textBoxSyntaxAnalyzeOutput.ReadOnly = true;
            textBoxSyntaxAnalyzeOutput.Size = new Size(606, 250);
            textBoxSyntaxAnalyzeOutput.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.HoverSelection = true;
            listView1.Location = new Point(12, 425);
            listView1.Name = "listView1";
            listView1.Size = new Size(600, 250);
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
            buttonSintaxAnalyzer.Location = new Point(877, 315);
            buttonSintaxAnalyzer.Name = "buttonSintaxAnalyzer";
            buttonSintaxAnalyzer.Size = new Size(180, 70);
            buttonSintaxAnalyzer.TabIndex = 6;
            buttonSintaxAnalyzer.Text = "Analizador Sintáctico";
            buttonSintaxAnalyzer.UseVisualStyleBackColor = false;
            buttonSintaxAnalyzer.Click += buttonSintaxAnalyzer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 59, 76);
            ClientSize = new Size(1282, 687);
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
    }
}