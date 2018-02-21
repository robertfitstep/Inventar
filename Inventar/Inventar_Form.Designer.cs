namespace Inventar
{
    partial class Inventar_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNazov = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVaha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPocet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTyp = new System.Windows.Forms.ComboBox();
            this.btPridat = new System.Windows.Forms.Button();
            this.btVymazat = new System.Windows.Forms.Button();
            this.lbInventar = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Názov";
            // 
            // tbNazov
            // 
            this.tbNazov.Location = new System.Drawing.Point(75, 27);
            this.tbNazov.Name = "tbNazov";
            this.tbNazov.Size = new System.Drawing.Size(181, 22);
            this.tbNazov.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cena";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(75, 55);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(181, 22);
            this.tbCena.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Váha";
            // 
            // tbVaha
            // 
            this.tbVaha.Location = new System.Drawing.Point(75, 83);
            this.tbVaha.Name = "tbVaha";
            this.tbVaha.Size = new System.Drawing.Size(181, 22);
            this.tbVaha.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Počet";
            // 
            // tbPocet
            // 
            this.tbPocet.Location = new System.Drawing.Point(75, 111);
            this.tbPocet.Name = "tbPocet";
            this.tbPocet.Size = new System.Drawing.Size(181, 22);
            this.tbPocet.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Typ";
            // 
            // cbTyp
            // 
            this.cbTyp.FormattingEnabled = true;
            this.cbTyp.Location = new System.Drawing.Point(75, 139);
            this.cbTyp.Name = "cbTyp";
            this.cbTyp.Size = new System.Drawing.Size(181, 24);
            this.cbTyp.TabIndex = 3;
            // 
            // btPridat
            // 
            this.btPridat.Location = new System.Drawing.Point(17, 169);
            this.btPridat.Name = "btPridat";
            this.btPridat.Size = new System.Drawing.Size(239, 32);
            this.btPridat.TabIndex = 4;
            this.btPridat.Text = "Pridať";
            this.btPridat.UseVisualStyleBackColor = true;
            this.btPridat.Click += new System.EventHandler(this.btPridaj_Click);
            // 
            // btVymazat
            // 
            this.btVymazat.Location = new System.Drawing.Point(273, 169);
            this.btVymazat.Name = "btVymazat";
            this.btVymazat.Size = new System.Drawing.Size(239, 32);
            this.btVymazat.TabIndex = 4;
            this.btVymazat.Text = "Vymazať";
            this.btVymazat.UseVisualStyleBackColor = true;
            this.btVymazat.Click += new System.EventHandler(this.btVymaz_Click);
            // 
            // lbInventar
            // 
            this.lbInventar.FormattingEnabled = true;
            this.lbInventar.Location = new System.Drawing.Point(273, 27);
            this.lbInventar.Name = "lbInventar";
            this.lbInventar.Size = new System.Drawing.Size(239, 123);
            this.lbInventar.TabIndex = 5;
            // 
            // Inventar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 217);
            this.Controls.Add(this.lbInventar);
            this.Controls.Add(this.btVymazat);
            this.Controls.Add(this.btPridat);
            this.Controls.Add(this.cbTyp);
            this.Controls.Add(this.tbPocet);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVaha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNazov);
            this.Controls.Add(this.label1);
            this.Name = "Inventar_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNazov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVaha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPocet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTyp;
        private System.Windows.Forms.Button btPridat;
        private System.Windows.Forms.Button btVymazat;
        private System.Windows.Forms.CheckedListBox lbInventar;
    }
}

