namespace Wortzähler
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
            TxtAnalyse = new TextBox();
            CmdAnalysieren = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // TxtAnalyse
            // 
            TxtAnalyse.Location = new Point(110, 135);
            TxtAnalyse.Multiline = true;
            TxtAnalyse.Name = "TxtAnalyse";
            TxtAnalyse.Size = new Size(809, 231);
            TxtAnalyse.TabIndex = 0;
            // 
            // CmdAnalysieren
            // 
            CmdAnalysieren.Location = new Point(422, 445);
            CmdAnalysieren.Name = "CmdAnalysieren";
            CmdAnalysieren.Size = new Size(185, 63);
            CmdAnalysieren.TabIndex = 1;
            CmdAnalysieren.Text = "Analysieren";
            CmdAnalysieren.UseVisualStyleBackColor = true;
            CmdAnalysieren.Click += button1_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(110, 569);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(0, 25);
            LblAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 876);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnalysieren);
            Controls.Add(TxtAnalyse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAnalyse;
        private Button CmdAnalysieren;
        private Label LblAusgabe;
    }
}
