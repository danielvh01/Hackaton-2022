namespace Hackaton
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVerif = new System.Windows.Forms.Button();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScr2 = new System.Windows.Forms.TextBox();
            this.txtScr1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnJustificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rich2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rich1 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnVerif1 = new System.Windows.Forms.Button();
            this.lblResC = new System.Windows.Forms.Label();
            this.txtCS2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCS1 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblAbuela = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(33, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnVerif);
            this.tabPage1.Controls.Add(this.lblResult1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtScr2);
            this.tabPage1.Controls.Add(this.txtScr1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scramble";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVerif
            // 
            this.btnVerif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerif.Location = new System.Drawing.Point(424, 61);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(75, 23);
            this.btnVerif.TabIndex = 5;
            this.btnVerif.Text = "Verificar";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Location = new System.Drawing.Point(268, 155);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(68, 15);
            this.lblResult1.TabIndex = 4;
            this.lblResult1.Text = "Resultado : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadena 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadena 1";
            // 
            // txtScr2
            // 
            this.txtScr2.Location = new System.Drawing.Point(215, 61);
            this.txtScr2.Name = "txtScr2";
            this.txtScr2.Size = new System.Drawing.Size(100, 23);
            this.txtScr2.TabIndex = 1;
            // 
            // txtScr1
            // 
            this.txtScr1.Location = new System.Drawing.Point(49, 61);
            this.txtScr1.Name = "txtScr1";
            this.txtScr1.Size = new System.Drawing.Size(100, 23);
            this.txtScr1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnJustificar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.rich2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rich1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Justificador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnJustificar
            // 
            this.btnJustificar.Location = new System.Drawing.Point(260, 205);
            this.btnJustificar.Name = "btnJustificar";
            this.btnJustificar.Size = new System.Drawing.Size(75, 23);
            this.btnJustificar.TabIndex = 4;
            this.btnJustificar.Text = "Justificar";
            this.btnJustificar.UseVisualStyleBackColor = true;
            this.btnJustificar.Click += new System.EventHandler(this.btnJustificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salida / Resultado";
            // 
            // rich2
            // 
            this.rich2.Location = new System.Drawing.Point(320, 55);
            this.rich2.Name = "rich2";
            this.rich2.ReadOnly = true;
            this.rich2.Size = new System.Drawing.Size(217, 107);
            this.rich2.TabIndex = 2;
            this.rich2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Entrada";
            // 
            // rich1
            // 
            this.rich1.Location = new System.Drawing.Point(26, 55);
            this.rich1.Name = "rich1";
            this.rich1.Size = new System.Drawing.Size(217, 107);
            this.rich1.TabIndex = 0;
            this.rich1.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnVerif1);
            this.tabPage3.Controls.Add(this.lblResC);
            this.tabPage3.Controls.Add(this.txtCS2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.txtCS1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(608, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadena Subsecuentes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnVerif1
            // 
            this.btnVerif1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerif1.Location = new System.Drawing.Point(454, 96);
            this.btnVerif1.Name = "btnVerif1";
            this.btnVerif1.Size = new System.Drawing.Size(75, 23);
            this.btnVerif1.TabIndex = 11;
            this.btnVerif1.Text = "Verificar";
            this.btnVerif1.UseVisualStyleBackColor = true;
            // 
            // lblResC
            // 
            this.lblResC.AutoSize = true;
            this.lblResC.Location = new System.Drawing.Point(298, 190);
            this.lblResC.Name = "lblResC";
            this.lblResC.Size = new System.Drawing.Size(68, 15);
            this.lblResC.TabIndex = 10;
            this.lblResC.Text = "Resultado : ";
            // 
            // txtCS2
            // 
            this.txtCS2.AutoSize = true;
            this.txtCS2.Location = new System.Drawing.Point(276, 65);
            this.txtCS2.Name = "txtCS2";
            this.txtCS2.Size = new System.Drawing.Size(56, 15);
            this.txtCS2.TabIndex = 9;
            this.txtCS2.Text = "Cadena 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cadena 1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(245, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // txtCS1
            // 
            this.txtCS1.Location = new System.Drawing.Point(79, 96);
            this.txtCS1.Name = "txtCS1";
            this.txtCS1.Size = new System.Drawing.Size(100, 23);
            this.txtCS1.TabIndex = 6;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblAbuela);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(608, 270);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Abuela Binaria";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblAbuela
            // 
            this.lblAbuela.AutoSize = true;
            this.lblAbuela.Location = new System.Drawing.Point(240, 151);
            this.lblAbuela.Name = "lblAbuela";
            this.lblAbuela.Size = new System.Drawing.Size(59, 15);
            this.lblAbuela.TabIndex = 17;
            this.lblAbuela.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sumando 2 (binario)";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(57, 197);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(54, 23);
            this.textBox6.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sumando 1 (binario)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(57, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 23);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(55, 52);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 23);
            this.textBox5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 362);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnVerif;
        private Label lblResult1;
        private Label label2;
        private Label label1;
        private TextBox txtScr2;
        private TextBox txtScr1;
        private TabPage tabPage2;
        private Button btnJustificar;
        private Label label4;
        private RichTextBox rich2;
        private Label label3;
        private RichTextBox rich1;
        private TabPage tabPage3;
        private Button btnVerif1;
        private Label lblResC;
        private Label txtCS2;
        private Label label7;
        private TextBox textBox3;
        private TextBox txtCS1;
        private TabPage tabPage4;
        private Label lblAbuela;
        private Button button1;
        private Label label8;
        private TextBox textBox6;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}