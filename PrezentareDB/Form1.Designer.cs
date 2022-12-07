namespace PrezentareDB
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NrTel = new System.Windows.Forms.TextBox();
            this.Inserare = new System.Windows.Forms.Button();
            this.AflaNume = new System.Windows.Forms.Button();
            this.AflaPrenume = new System.Windows.Forms.Button();
            this.Stergere = new System.Windows.Forms.Button();
            this.AflaNumar = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.ModifNume = new System.Windows.Forms.Button();
            this.DBView = new System.Windows.Forms.DataGridView();
            this.CautaId = new System.Windows.Forms.Button();
            this.CautaNume = new System.Windows.Forms.Button();
            this.CautaPrenume = new System.Windows.Forms.Button();
            this.CautaTel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdCauta = new System.Windows.Forms.TextBox();
            this.NumeCauta = new System.Windows.Forms.TextBox();
            this.PrenumeCauta = new System.Windows.Forms.TextBox();
            this.TelCauta = new System.Windows.Forms.TextBox();
            this.CautaTot = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 491);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ModifNume);
            this.tabPage1.Controls.Add(this.Id);
            this.tabPage1.Controls.Add(this.d);
            this.tabPage1.Controls.Add(this.AflaNumar);
            this.tabPage1.Controls.Add(this.Stergere);
            this.tabPage1.Controls.Add(this.AflaPrenume);
            this.tabPage1.Controls.Add(this.AflaNume);
            this.tabPage1.Controls.Add(this.Inserare);
            this.tabPage1.Controls.Add(this.NrTel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Prenume);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Nume);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comenzi generale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CautaTot);
            this.tabPage2.Controls.Add(this.TelCauta);
            this.tabPage2.Controls.Add(this.PrenumeCauta);
            this.tabPage2.Controls.Add(this.NumeCauta);
            this.tabPage2.Controls.Add(this.IdCauta);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.CautaTel);
            this.tabPage2.Controls.Add(this.CautaPrenume);
            this.tabPage2.Controls.Add(this.CautaNume);
            this.tabPage2.Controls.Add(this.CautaId);
            this.tabPage2.Controls.Add(this.DBView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataGridView";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // Nume
            // 
            this.Nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume.Location = new System.Drawing.Point(364, 77);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(140, 31);
            this.Nume.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // Prenume
            // 
            this.Prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenume.Location = new System.Drawing.Point(364, 125);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(140, 31);
            this.Prenume.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numar telefon";
            // 
            // NrTel
            // 
            this.NrTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NrTel.Location = new System.Drawing.Point(364, 177);
            this.NrTel.Name = "NrTel";
            this.NrTel.Size = new System.Drawing.Size(140, 31);
            this.NrTel.TabIndex = 7;
            // 
            // Inserare
            // 
            this.Inserare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inserare.Location = new System.Drawing.Point(91, 248);
            this.Inserare.Name = "Inserare";
            this.Inserare.Size = new System.Drawing.Size(99, 44);
            this.Inserare.TabIndex = 8;
            this.Inserare.Text = "Inserare";
            this.Inserare.UseVisualStyleBackColor = true;
            this.Inserare.Click += new System.EventHandler(this.button1_Click);
            // 
            // AflaNume
            // 
            this.AflaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AflaNume.Location = new System.Drawing.Point(196, 248);
            this.AflaNume.Name = "AflaNume";
            this.AflaNume.Size = new System.Drawing.Size(117, 44);
            this.AflaNume.TabIndex = 9;
            this.AflaNume.Text = "Afla nume";
            this.AflaNume.UseVisualStyleBackColor = true;
            this.AflaNume.Click += new System.EventHandler(this.AflaNume_Click);
            // 
            // AflaPrenume
            // 
            this.AflaPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AflaPrenume.Location = new System.Drawing.Point(319, 248);
            this.AflaPrenume.Name = "AflaPrenume";
            this.AflaPrenume.Size = new System.Drawing.Size(148, 44);
            this.AflaPrenume.TabIndex = 10;
            this.AflaPrenume.Text = "Afla prenume";
            this.AflaPrenume.UseVisualStyleBackColor = true;
            this.AflaPrenume.Click += new System.EventHandler(this.AflaPrenume_Click);
            // 
            // Stergere
            // 
            this.Stergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stergere.Location = new System.Drawing.Point(612, 249);
            this.Stergere.Name = "Stergere";
            this.Stergere.Size = new System.Drawing.Size(105, 42);
            this.Stergere.TabIndex = 12;
            this.Stergere.Text = "Stergere";
            this.Stergere.UseVisualStyleBackColor = true;
            this.Stergere.Click += new System.EventHandler(this.Stergere_Click);
            // 
            // AflaNumar
            // 
            this.AflaNumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AflaNumar.Location = new System.Drawing.Point(478, 249);
            this.AflaNumar.Name = "AflaNumar";
            this.AflaNumar.Size = new System.Drawing.Size(128, 41);
            this.AflaNumar.TabIndex = 13;
            this.AflaNumar.Text = "Afla numar";
            this.AflaNumar.UseVisualStyleBackColor = true;
            this.AflaNumar.Click += new System.EventHandler(this.AflaNumar_Click);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d.Location = new System.Drawing.Point(194, 31);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(33, 29);
            this.d.TabIndex = 14;
            this.d.Text = "Id";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(364, 29);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(140, 31);
            this.Id.TabIndex = 15;
            // 
            // ModifNume
            // 
            this.ModifNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifNume.Location = new System.Drawing.Point(307, 311);
            this.ModifNume.Name = "ModifNume";
            this.ModifNume.Size = new System.Drawing.Size(177, 37);
            this.ModifNume.TabIndex = 16;
            this.ModifNume.Text = "Modifica Nume";
            this.ModifNume.UseVisualStyleBackColor = true;
            this.ModifNume.Click += new System.EventHandler(this.ModifNume_Click);
            // 
            // DBView
            // 
            this.DBView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DBView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBView.Location = new System.Drawing.Point(6, 120);
            this.DBView.Name = "DBView";
            this.DBView.Size = new System.Drawing.Size(891, 339);
            this.DBView.TabIndex = 0;
            // 
            // CautaId
            // 
            this.CautaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaId.Location = new System.Drawing.Point(41, 51);
            this.CautaId.Name = "CautaId";
            this.CautaId.Size = new System.Drawing.Size(89, 29);
            this.CautaId.TabIndex = 1;
            this.CautaId.Text = "Cauta";
            this.CautaId.UseVisualStyleBackColor = true;
            this.CautaId.Click += new System.EventHandler(this.CautaId_Click);
            // 
            // CautaNume
            // 
            this.CautaNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaNume.Location = new System.Drawing.Point(244, 51);
            this.CautaNume.Name = "CautaNume";
            this.CautaNume.Size = new System.Drawing.Size(75, 29);
            this.CautaNume.TabIndex = 2;
            this.CautaNume.Text = "Cauta";
            this.CautaNume.UseVisualStyleBackColor = true;
            this.CautaNume.Click += new System.EventHandler(this.CautaNume_Click);
            // 
            // CautaPrenume
            // 
            this.CautaPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaPrenume.Location = new System.Drawing.Point(471, 51);
            this.CautaPrenume.Name = "CautaPrenume";
            this.CautaPrenume.Size = new System.Drawing.Size(75, 29);
            this.CautaPrenume.TabIndex = 3;
            this.CautaPrenume.Text = "Cauta";
            this.CautaPrenume.UseVisualStyleBackColor = true;
            this.CautaPrenume.Click += new System.EventHandler(this.CautaPrenume_Click);
            // 
            // CautaTel
            // 
            this.CautaTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaTel.Location = new System.Drawing.Point(666, 51);
            this.CautaTel.Name = "CautaTel";
            this.CautaTel.Size = new System.Drawing.Size(75, 29);
            this.CautaTel.TabIndex = 4;
            this.CautaTel.Text = "Cauta";
            this.CautaTel.UseVisualStyleBackColor = true;
            this.CautaTel.Click += new System.EventHandler(this.CautaTel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prenume";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(596, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "NrTel";
            // 
            // IdCauta
            // 
            this.IdCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCauta.Location = new System.Drawing.Point(41, 14);
            this.IdCauta.Name = "IdCauta";
            this.IdCauta.Size = new System.Drawing.Size(100, 31);
            this.IdCauta.TabIndex = 9;
            // 
            // NumeCauta
            // 
            this.NumeCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeCauta.Location = new System.Drawing.Point(244, 14);
            this.NumeCauta.Name = "NumeCauta";
            this.NumeCauta.Size = new System.Drawing.Size(100, 31);
            this.NumeCauta.TabIndex = 10;
            // 
            // PrenumeCauta
            // 
            this.PrenumeCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenumeCauta.Location = new System.Drawing.Point(471, 14);
            this.PrenumeCauta.Name = "PrenumeCauta";
            this.PrenumeCauta.Size = new System.Drawing.Size(100, 31);
            this.PrenumeCauta.TabIndex = 11;
            // 
            // TelCauta
            // 
            this.TelCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelCauta.Location = new System.Drawing.Point(666, 14);
            this.TelCauta.Name = "TelCauta";
            this.TelCauta.Size = new System.Drawing.Size(115, 31);
            this.TelCauta.TabIndex = 12;
            // 
            // CautaTot
            // 
            this.CautaTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CautaTot.Location = new System.Drawing.Point(787, 14);
            this.CautaTot.Name = "CautaTot";
            this.CautaTot.Size = new System.Drawing.Size(110, 87);
            this.CautaTot.TabIndex = 13;
            this.CautaTot.Text = "Selecteaza tot";
            this.CautaTot.UseVisualStyleBackColor = true;
            this.CautaTot.Click += new System.EventHandler(this.CautaTot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DBView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Stergere;
        private System.Windows.Forms.Button AflaPrenume;
        private System.Windows.Forms.Button AflaNume;
        private System.Windows.Forms.Button Inserare;
        private System.Windows.Forms.TextBox NrTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AflaNumar;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Button ModifNume;
        private System.Windows.Forms.TextBox TelCauta;
        private System.Windows.Forms.TextBox PrenumeCauta;
        private System.Windows.Forms.TextBox NumeCauta;
        private System.Windows.Forms.TextBox IdCauta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CautaTel;
        private System.Windows.Forms.Button CautaPrenume;
        private System.Windows.Forms.Button CautaNume;
        private System.Windows.Forms.Button CautaId;
        private System.Windows.Forms.DataGridView DBView;
        private System.Windows.Forms.Button CautaTot;
    }
}

