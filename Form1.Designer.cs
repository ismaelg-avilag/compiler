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
            buttonLexicalAnalyzer = new Button();
            label1 = new Label();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonLexicalAnalyzer
            // 
            buttonLexicalAnalyzer.BackColor = Color.FromArgb(103, 137, 131);
            buttonLexicalAnalyzer.Cursor = Cursors.Hand;
            buttonLexicalAnalyzer.FlatStyle = FlatStyle.Popup;
            buttonLexicalAnalyzer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLexicalAnalyzer.ForeColor = Color.White;
            buttonLexicalAnalyzer.Location = new Point(579, 206);
            buttonLexicalAnalyzer.Name = "buttonLexicalAnalyzer";
            buttonLexicalAnalyzer.Size = new Size(180, 70);
            buttonLexicalAnalyzer.TabIndex = 0;
            buttonLexicalAnalyzer.Text = "Analizador Léxico";
            buttonLexicalAnalyzer.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 221, 196);
            label1.Location = new Point(540, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 60);
            label1.TabIndex = 1;
            label1.Text = "Compilador";
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxInput.Location = new Point(12, 57);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.PlaceholderText = "Ingresa el código a analizar:";
            textBoxInput.Size = new Size(350, 350);
            textBoxInput.TabIndex = 2;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Cursor = Cursors.No;
            textBoxOutput.Font = new Font("Fira Code", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOutput.Location = new Point(920, 57);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(350, 350);
            textBoxOutput.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 447);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(1258, 394);
            dataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 29, 49);
            ClientSize = new Size(1282, 853);
            Controls.Add(dataGridView);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Controls.Add(buttonLexicalAnalyzer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLexicalAnalyzer;
        private Label label1;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
        private DataGridView dataGridView;
    }
}