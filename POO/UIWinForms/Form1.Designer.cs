namespace UIWinForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.textBoxImpulso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExibir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPneuDianteiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroEsquerdo = new System.Windows.Forms.TextBox();
            this.textBoxPneuTraseiroDireito = new System.Windows.Forms.TextBox();
            this.textBoxPneuDianteiroDireito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPneuDeEstepe = new System.Windows.Forms.TextBox();
            this.comboBoxPneu = new System.Windows.Forms.ComboBox();
            this.buttonTrocarPneu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Acelerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Frear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 144);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(94, 29);
            this.button.TabIndex = 2;
            this.button.Text = "Ligar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxImpulso
            // 
            this.textBoxImpulso.Location = new System.Drawing.Point(12, 111);
            this.textBoxImpulso.Name = "textBoxImpulso";
            this.textBoxImpulso.Size = new System.Drawing.Size(303, 27);
            this.textBoxImpulso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "MEU CARRO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Impulso:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxExibir
            // 
            this.textBoxExibir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxExibir.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxExibir.Location = new System.Drawing.Point(726, 111);
            this.textBoxExibir.Multiline = true;
            this.textBoxExibir.Name = "textBoxExibir";
            this.textBoxExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExibir.Size = new System.Drawing.Size(280, 536);
            this.textBoxExibir.TabIndex = 7;
            this.textBoxExibir.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(546, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "PneuDianteiroEsquerdo\r\n\r\n";
            this.label3.Click += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxPneuDianteiroEsquerdo
            // 
            this.textBoxPneuDianteiroEsquerdo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPneuDianteiroEsquerdo.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuDianteiroEsquerdo.Location = new System.Drawing.Point(583, 149);
            this.textBoxPneuDianteiroEsquerdo.Multiline = true;
            this.textBoxPneuDianteiroEsquerdo.Name = "textBoxPneuDianteiroEsquerdo";
            this.textBoxPneuDianteiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroEsquerdo.Size = new System.Drawing.Size(137, 167);
            this.textBoxPneuDianteiroEsquerdo.TabIndex = 9;
            // 
            // textBoxPneuTraseiroEsquerdo
            // 
            this.textBoxPneuTraseiroEsquerdo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPneuTraseiroEsquerdo.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuTraseiroEsquerdo.Location = new System.Drawing.Point(583, 429);
            this.textBoxPneuTraseiroEsquerdo.Multiline = true;
            this.textBoxPneuTraseiroEsquerdo.Name = "textBoxPneuTraseiroEsquerdo";
            this.textBoxPneuTraseiroEsquerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroEsquerdo.Size = new System.Drawing.Size(137, 167);
            this.textBoxPneuTraseiroEsquerdo.TabIndex = 10;
            // 
            // textBoxPneuTraseiroDireito
            // 
            this.textBoxPneuTraseiroDireito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPneuTraseiroDireito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuTraseiroDireito.Location = new System.Drawing.Point(1012, 429);
            this.textBoxPneuTraseiroDireito.Multiline = true;
            this.textBoxPneuTraseiroDireito.Name = "textBoxPneuTraseiroDireito";
            this.textBoxPneuTraseiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuTraseiroDireito.Size = new System.Drawing.Size(139, 167);
            this.textBoxPneuTraseiroDireito.TabIndex = 11;
            // 
            // textBoxPneuDianteiroDireito
            // 
            this.textBoxPneuDianteiroDireito.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPneuDianteiroDireito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuDianteiroDireito.Location = new System.Drawing.Point(1012, 149);
            this.textBoxPneuDianteiroDireito.Multiline = true;
            this.textBoxPneuDianteiroDireito.Name = "textBoxPneuDianteiroDireito";
            this.textBoxPneuDianteiroDireito.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDianteiroDireito.Size = new System.Drawing.Size(139, 167);
            this.textBoxPneuDianteiroDireito.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(555, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "PneuTraseiroEsquerdo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(726, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Detalhes do carro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1012, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "PneuTraseiroDireito";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(1012, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "PneuDianteiroDIreito";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(324, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estepe";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxPneuDeEstepe
            // 
            this.textBoxPneuDeEstepe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPneuDeEstepe.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxPneuDeEstepe.Location = new System.Drawing.Point(324, 429);
            this.textBoxPneuDeEstepe.Multiline = true;
            this.textBoxPneuDeEstepe.Name = "textBoxPneuDeEstepe";
            this.textBoxPneuDeEstepe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPneuDeEstepe.Size = new System.Drawing.Size(172, 167);
            this.textBoxPneuDeEstepe.TabIndex = 17;
            this.textBoxPneuDeEstepe.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // comboBoxPneu
            // 
            this.comboBoxPneu.FormattingEnabled = true;
            this.comboBoxPneu.Items.AddRange(new object[] {
            "Pneu Dianteiro Esquerdo",
            "Pneu Dianteiro Direito",
            "Pneu Traseiro Esquerdo",
            "Pneu Traseiro Direito"});
            this.comboBoxPneu.Location = new System.Drawing.Point(30, 230);
            this.comboBoxPneu.Name = "comboBoxPneu";
            this.comboBoxPneu.Size = new System.Drawing.Size(264, 28);
            this.comboBoxPneu.TabIndex = 20;
            // 
            // buttonTrocarPneu
            // 
            this.buttonTrocarPneu.Location = new System.Drawing.Point(87, 264);
            this.buttonTrocarPneu.Name = "buttonTrocarPneu";
            this.buttonTrocarPneu.Size = new System.Drawing.Size(128, 29);
            this.buttonTrocarPneu.TabIndex = 21;
            this.buttonTrocarPneu.Text = "Trocar de Pneu";
            this.buttonTrocarPneu.UseVisualStyleBackColor = true;
            this.buttonTrocarPneu.Click += new System.EventHandler(this.buttonTrocarPneu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.No;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(41, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Informe qual Pneu deseja trocar:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1341, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonTrocarPneu);
            this.Controls.Add(this.comboBoxPneu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPneuDeEstepe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPneuDianteiroDireito);
            this.Controls.Add(this.textBoxPneuTraseiroDireito);
            this.Controls.Add(this.textBoxPneuTraseiroEsquerdo);
            this.Controls.Add(this.textBoxPneuDianteiroEsquerdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExibir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImpulso);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button;
        private TextBox textBoxImpulso;
        private Label label1;
        private Label label2;
        private TextBox textBoxExibir;
        private Label label3;
        private TextBox textBoxPneuDianteiroEsquerdo;
        private TextBox textBoxPneuTraseiroEsquerdo;
        private TextBox textBoxPneuTraseiroDireito;
        private TextBox textBoxPneuDianteiroDireito;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxPneuDeEstepe;
        private ComboBox comboBoxPneu;
        private Button buttonTrocarPneu;
        private Label label9;
    }
}