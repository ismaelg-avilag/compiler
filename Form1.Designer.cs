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
            buttonBlackBox = new Button();
            buttonWhiteBox = new Button();
            textBox1 = new TextBox();
            buttonSemanticAnalyzer = new Button();
            SuspendLayout();
            // 
            // buttonLexicalAnalyzer
            // 
            buttonLexicalAnalyzer.BackColor = Color.FromArgb(6, 214, 160);
            buttonLexicalAnalyzer.Cursor = Cursors.Hand;
            buttonLexicalAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonLexicalAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLexicalAnalyzer.ForeColor = Color.Black;
            buttonLexicalAnalyzer.Location = new Point(221, 397);
            buttonLexicalAnalyzer.Name = "buttonLexicalAnalyzer";
            buttonLexicalAnalyzer.Size = new Size(180, 70);
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
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(750, 54);
            label1.TabIndex = 1;
            label1.Text = "Compilador - Seminario de Traductores 2";
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.ForeColor = Color.FromArgb(97, 175, 239);
            textBoxInput.Location = new Point(14, 165);
            textBoxInput.Margin = new Padding(10);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Ingresa el código a analizar:";
            textBoxInput.Size = new Size(598, 180);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxSyntaxAnalyzeOutput
            // 
            textBoxSyntaxAnalyzeOutput.BackColor = Color.FromArgb(35, 39, 46);
            textBoxSyntaxAnalyzeOutput.BorderStyle = BorderStyle.None;
            textBoxSyntaxAnalyzeOutput.Cursor = Cursors.No;
            textBoxSyntaxAnalyzeOutput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSyntaxAnalyzeOutput.ForeColor = Color.FromArgb(97, 175, 239);
            textBoxSyntaxAnalyzeOutput.Location = new Point(681, 165);
            textBoxSyntaxAnalyzeOutput.Margin = new Padding(10);
            textBoxSyntaxAnalyzeOutput.Multiline = true;
            textBoxSyntaxAnalyzeOutput.Name = "textBoxSyntaxAnalyzeOutput";
            textBoxSyntaxAnalyzeOutput.ReadOnly = true;
            textBoxSyntaxAnalyzeOutput.Size = new Size(550, 180);
            textBoxSyntaxAnalyzeOutput.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.HoverSelection = true;
            listView1.Location = new Point(12, 473);
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
            buttonSintaxAnalyzer.Location = new Point(866, 91);
            buttonSintaxAnalyzer.Name = "buttonSintaxAnalyzer";
            buttonSintaxAnalyzer.Size = new Size(180, 70);
            buttonSintaxAnalyzer.TabIndex = 6;
            buttonSintaxAnalyzer.Text = "Análisis Sintáctico";
            buttonSintaxAnalyzer.UseVisualStyleBackColor = false;
            buttonSintaxAnalyzer.Click += buttonSintaxAnalyzer_Click;
            // 
            // buttonBlackBox
            // 
            buttonBlackBox.BackColor = Color.Black;
            buttonBlackBox.FlatStyle = FlatStyle.Popup;
            buttonBlackBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBlackBox.ForeColor = Color.White;
            buttonBlackBox.Location = new Point(73, 114);
            buttonBlackBox.Name = "buttonBlackBox";
            buttonBlackBox.Size = new Size(136, 43);
            buttonBlackBox.TabIndex = 7;
            buttonBlackBox.Text = "Caja Negra";
            buttonBlackBox.UseVisualStyleBackColor = false;
            buttonBlackBox.Visible = false;
            buttonBlackBox.Click += buttonBlackBox_Click;
            // 
            // buttonWhiteBox
            // 
            buttonWhiteBox.BackColor = Color.White;
            buttonWhiteBox.FlatStyle = FlatStyle.Popup;
            buttonWhiteBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWhiteBox.ForeColor = Color.Black;
            buttonWhiteBox.Location = new Point(385, 114);
            buttonWhiteBox.Name = "buttonWhiteBox";
            buttonWhiteBox.Size = new Size(136, 43);
            buttonWhiteBox.TabIndex = 8;
            buttonWhiteBox.Text = "Caja Blanca";
            buttonWhiteBox.UseVisualStyleBackColor = false;
            buttonWhiteBox.Visible = false;
            buttonWhiteBox.Click += buttonWhiteBox_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(681, 473);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 250);
            textBox1.TabIndex = 9;
            // 
            // buttonSemanticAnalyzer
            // 
            buttonSemanticAnalyzer.BackColor = Color.FromArgb(239, 71, 111);
            buttonSemanticAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonSemanticAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSemanticAnalyzer.Location = new Point(866, 397);
            buttonSemanticAnalyzer.Name = "buttonSemanticAnalyzer";
            buttonSemanticAnalyzer.Size = new Size(180, 70);
            buttonSemanticAnalyzer.TabIndex = 10;
            buttonSemanticAnalyzer.Text = "Análisis Semántico";
            buttonSemanticAnalyzer.UseVisualStyleBackColor = false;
            buttonSemanticAnalyzer.Click += buttonSemanticAnalyzer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 59, 76);
            ClientSize = new Size(1257, 735);
            Controls.Add(buttonSemanticAnalyzer);
            Controls.Add(textBox1);
            Controls.Add(buttonWhiteBox);
            Controls.Add(buttonBlackBox);
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
        private Button buttonBlackBox;
        private Button buttonWhiteBox;
        private TextBox textBox1;
        private Button buttonSemanticAnalyzer;
    }
}