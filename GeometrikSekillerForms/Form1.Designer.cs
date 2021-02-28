
namespace GeometrikSekillerForms
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
            this.components = new System.ComponentModel.Container();
            this.lGiris = new System.Windows.Forms.Label();
            this.rbKare = new System.Windows.Forms.RadioButton();
            this.rbDikdortgen = new System.Windows.Forms.RadioButton();
            this.rbEskenarUcgen = new System.Windows.Forms.RadioButton();
            this.rbDikUcgen = new System.Windows.Forms.RadioButton();
            this.rbDaire = new System.Windows.Forms.RadioButton();
            this.lUzunKenar = new System.Windows.Forms.Label();
            this.lKısaKenar = new System.Windows.Forms.Label();
            this.tbUzunKenar = new System.Windows.Forms.TextBox();
            this.tbKısaKenar = new System.Windows.Forms.TextBox();
            this.lDikKenar1 = new System.Windows.Forms.Label();
            this.lDikKenar2 = new System.Windows.Forms.Label();
            this.tbDik1 = new System.Windows.Forms.TextBox();
            this.tbDik2 = new System.Windows.Forms.TextBox();
            this.lYariCap = new System.Windows.Forms.Label();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.gbUcgen = new System.Windows.Forms.GroupBox();
            this.gbDaire = new System.Windows.Forms.GroupBox();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.bAlanHesapla = new System.Windows.Forms.Button();
            this.gbKareDikdortgen = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.gbUcgen.SuspendLayout();
            this.gbDaire.SuspendLayout();
            this.gbKareDikdortgen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lGiris
            // 
            this.lGiris.AutoSize = true;
            this.lGiris.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lGiris.ForeColor = System.Drawing.Color.Transparent;
            this.lGiris.Location = new System.Drawing.Point(13, 13);
            this.lGiris.Name = "lGiris";
            this.lGiris.Size = new System.Drawing.Size(314, 32);
            this.lGiris.TabIndex = 0;
            this.lGiris.Text = "Geometrik şekil seçiniz:";
            // 
            // rbKare
            // 
            this.rbKare.AutoSize = true;
            this.rbKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKare.Location = new System.Drawing.Point(18, 80);
            this.rbKare.Name = "rbKare";
            this.rbKare.Size = new System.Drawing.Size(69, 24);
            this.rbKare.TabIndex = 1;
            this.rbKare.Text = "Kare";
            this.rbKare.UseVisualStyleBackColor = true;
            this.rbKare.CheckedChanged += new System.EventHandler(this.rbKare_CheckedChanged);
            // 
            // rbDikdortgen
            // 
            this.rbDikdortgen.AutoSize = true;
            this.rbDikdortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDikdortgen.Location = new System.Drawing.Point(176, 80);
            this.rbDikdortgen.Name = "rbDikdortgen";
            this.rbDikdortgen.Size = new System.Drawing.Size(121, 24);
            this.rbDikdortgen.TabIndex = 1;
            this.rbDikdortgen.Text = "Dikdörtgen";
            this.rbDikdortgen.UseVisualStyleBackColor = true;
            this.rbDikdortgen.CheckedChanged += new System.EventHandler(this.rbDikdortgen_CheckedChanged);
            // 
            // rbEskenarUcgen
            // 
            this.rbEskenarUcgen.AutoSize = true;
            this.rbEskenarUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbEskenarUcgen.Location = new System.Drawing.Point(396, 80);
            this.rbEskenarUcgen.Name = "rbEskenarUcgen";
            this.rbEskenarUcgen.Size = new System.Drawing.Size(157, 24);
            this.rbEskenarUcgen.TabIndex = 1;
            this.rbEskenarUcgen.Text = "Eşkenar Üçgen";
            this.rbEskenarUcgen.UseVisualStyleBackColor = true;
            this.rbEskenarUcgen.CheckedChanged += new System.EventHandler(this.rbEskenarUcgen_CheckedChanged);
            // 
            // rbDikUcgen
            // 
            this.rbDikUcgen.AutoSize = true;
            this.rbDikUcgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDikUcgen.Location = new System.Drawing.Point(653, 80);
            this.rbDikUcgen.Name = "rbDikUcgen";
            this.rbDikUcgen.Size = new System.Drawing.Size(117, 24);
            this.rbDikUcgen.TabIndex = 1;
            this.rbDikUcgen.Text = "Dik Üçgen";
            this.rbDikUcgen.UseVisualStyleBackColor = true;
            this.rbDikUcgen.CheckedChanged += new System.EventHandler(this.rbDikUcgen_CheckedChanged);
            // 
            // rbDaire
            // 
            this.rbDaire.AutoSize = true;
            this.rbDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbDaire.Location = new System.Drawing.Point(853, 80);
            this.rbDaire.Name = "rbDaire";
            this.rbDaire.Size = new System.Drawing.Size(76, 24);
            this.rbDaire.TabIndex = 1;
            this.rbDaire.Text = "Daire";
            this.rbDaire.UseVisualStyleBackColor = true;
            this.rbDaire.CheckedChanged += new System.EventHandler(this.rbDaire_CheckedChanged);
            // 
            // lUzunKenar
            // 
            this.lUzunKenar.AutoSize = true;
            this.lUzunKenar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lUzunKenar.Location = new System.Drawing.Point(6, 32);
            this.lUzunKenar.Name = "lUzunKenar";
            this.lUzunKenar.Size = new System.Drawing.Size(74, 23);
            this.lUzunKenar.TabIndex = 2;
            this.lUzunKenar.Text = "1.Kenar:";
            // 
            // lKısaKenar
            // 
            this.lKısaKenar.AutoSize = true;
            this.lKısaKenar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lKısaKenar.Location = new System.Drawing.Point(6, 83);
            this.lKısaKenar.Name = "lKısaKenar";
            this.lKısaKenar.Size = new System.Drawing.Size(74, 23);
            this.lKısaKenar.TabIndex = 3;
            this.lKısaKenar.Text = "2.Kenar:";
            // 
            // tbUzunKenar
            // 
            this.tbUzunKenar.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbUzunKenar.ForeColor = System.Drawing.Color.Transparent;
            this.tbUzunKenar.Location = new System.Drawing.Point(131, 79);
            this.tbUzunKenar.Name = "tbUzunKenar";
            this.tbUzunKenar.Size = new System.Drawing.Size(100, 27);
            this.tbUzunKenar.TabIndex = 5;
            // 
            // tbKısaKenar
            // 
            this.tbKısaKenar.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbKısaKenar.ForeColor = System.Drawing.Color.Transparent;
            this.tbKısaKenar.Location = new System.Drawing.Point(131, 26);
            this.tbKısaKenar.Name = "tbKısaKenar";
            this.tbKısaKenar.Size = new System.Drawing.Size(100, 27);
            this.tbKısaKenar.TabIndex = 6;
            // 
            // lDikKenar1
            // 
            this.lDikKenar1.AutoSize = true;
            this.lDikKenar1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDikKenar1.Location = new System.Drawing.Point(6, 32);
            this.lDikKenar1.Name = "lDikKenar1";
            this.lDikKenar1.Size = new System.Drawing.Size(75, 23);
            this.lDikKenar1.TabIndex = 7;
            this.lDikKenar1.Text = "1. Kenar";
            // 
            // lDikKenar2
            // 
            this.lDikKenar2.AutoSize = true;
            this.lDikKenar2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lDikKenar2.Location = new System.Drawing.Point(6, 83);
            this.lDikKenar2.Name = "lDikKenar2";
            this.lDikKenar2.Size = new System.Drawing.Size(70, 23);
            this.lDikKenar2.TabIndex = 7;
            this.lDikKenar2.Text = "2.Kenar";
            // 
            // tbDik1
            // 
            this.tbDik1.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbDik1.ForeColor = System.Drawing.Color.Transparent;
            this.tbDik1.Location = new System.Drawing.Point(176, 28);
            this.tbDik1.Name = "tbDik1";
            this.tbDik1.Size = new System.Drawing.Size(100, 27);
            this.tbDik1.TabIndex = 8;
            // 
            // tbDik2
            // 
            this.tbDik2.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbDik2.ForeColor = System.Drawing.Color.Transparent;
            this.tbDik2.Location = new System.Drawing.Point(176, 79);
            this.tbDik2.Name = "tbDik2";
            this.tbDik2.Size = new System.Drawing.Size(100, 27);
            this.tbDik2.TabIndex = 8;
            // 
            // lYariCap
            // 
            this.lYariCap.AutoSize = true;
            this.lYariCap.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lYariCap.Location = new System.Drawing.Point(6, 30);
            this.lYariCap.Name = "lYariCap";
            this.lYariCap.Size = new System.Drawing.Size(85, 23);
            this.lYariCap.TabIndex = 9;
            this.lYariCap.Text = "Yarı Çapı:";
            // 
            // tbYariCap
            // 
            this.tbYariCap.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbYariCap.ForeColor = System.Drawing.Color.Transparent;
            this.tbYariCap.Location = new System.Drawing.Point(118, 26);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(117, 27);
            this.tbYariCap.TabIndex = 10;
            // 
            // gbUcgen
            // 
            this.gbUcgen.Controls.Add(this.lDikKenar1);
            this.gbUcgen.Controls.Add(this.tbDik1);
            this.gbUcgen.Controls.Add(this.lDikKenar2);
            this.gbUcgen.Controls.Add(this.tbDik2);
            this.gbUcgen.Location = new System.Drawing.Point(357, 140);
            this.gbUcgen.Name = "gbUcgen";
            this.gbUcgen.Size = new System.Drawing.Size(282, 128);
            this.gbUcgen.TabIndex = 12;
            this.gbUcgen.TabStop = false;
            this.gbUcgen.Visible = false;
            // 
            // gbDaire
            // 
            this.gbDaire.Controls.Add(this.lYariCap);
            this.gbDaire.Controls.Add(this.tbYariCap);
            this.gbDaire.Location = new System.Drawing.Point(718, 140);
            this.gbDaire.Name = "gbDaire";
            this.gbDaire.Size = new System.Drawing.Size(241, 81);
            this.gbDaire.TabIndex = 13;
            this.gbDaire.TabStop = false;
            this.gbDaire.Visible = false;
            // 
            // bTemizle
            // 
            this.bTemizle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.ForeColor = System.Drawing.Color.Transparent;
            this.bTemizle.Location = new System.Drawing.Point(749, 448);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(210, 65);
            this.bTemizle.TabIndex = 14;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = false;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lSonuc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSonuc.ForeColor = System.Drawing.Color.Transparent;
            this.lSonuc.Location = new System.Drawing.Point(298, 349);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(400, 164);
            this.lSonuc.TabIndex = 15;
            this.lSonuc.Text = "Sonuç";
            this.lSonuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bAlanHesapla
            // 
            this.bAlanHesapla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bAlanHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAlanHesapla.ForeColor = System.Drawing.Color.Transparent;
            this.bAlanHesapla.Location = new System.Drawing.Point(24, 448);
            this.bAlanHesapla.Name = "bAlanHesapla";
            this.bAlanHesapla.Size = new System.Drawing.Size(210, 65);
            this.bAlanHesapla.TabIndex = 14;
            this.bAlanHesapla.Text = "Alan ve Çevre Hesapla";
            this.bAlanHesapla.UseVisualStyleBackColor = false;
            this.bAlanHesapla.Click += new System.EventHandler(this.bAlanHesapla_Click);
            // 
            // gbKareDikdortgen
            // 
            this.gbKareDikdortgen.Controls.Add(this.tbKısaKenar);
            this.gbKareDikdortgen.Controls.Add(this.lUzunKenar);
            this.gbKareDikdortgen.Controls.Add(this.lKısaKenar);
            this.gbKareDikdortgen.Controls.Add(this.tbUzunKenar);
            this.gbKareDikdortgen.Location = new System.Drawing.Point(24, 140);
            this.gbKareDikdortgen.Name = "gbKareDikdortgen";
            this.gbKareDikdortgen.Size = new System.Drawing.Size(273, 128);
            this.gbKareDikdortgen.TabIndex = 16;
            this.gbKareDikdortgen.TabStop = false;
            this.gbKareDikdortgen.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.gbKareDikdortgen);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bAlanHesapla);
            this.Controls.Add(this.gbDaire);
            this.Controls.Add(this.gbUcgen);
            this.Controls.Add(this.rbDaire);
            this.Controls.Add(this.rbDikUcgen);
            this.Controls.Add(this.rbEskenarUcgen);
            this.Controls.Add(this.rbDikdortgen);
            this.Controls.Add(this.rbKare);
            this.Controls.Add(this.lGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Geometrik Şekiller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUcgen.ResumeLayout(false);
            this.gbUcgen.PerformLayout();
            this.gbDaire.ResumeLayout(false);
            this.gbDaire.PerformLayout();
            this.gbKareDikdortgen.ResumeLayout(false);
            this.gbKareDikdortgen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lGiris;
        private System.Windows.Forms.RadioButton rbKare;
        private System.Windows.Forms.RadioButton rbDikdortgen;
        private System.Windows.Forms.RadioButton rbEskenarUcgen;
        private System.Windows.Forms.RadioButton rbDikUcgen;
        private System.Windows.Forms.RadioButton rbDaire;
        private System.Windows.Forms.Label lUzunKenar;
        private System.Windows.Forms.Label lKısaKenar;
        private System.Windows.Forms.TextBox tbUzunKenar;
        private System.Windows.Forms.TextBox tbKısaKenar;
        private System.Windows.Forms.Label lDikKenar1;
        private System.Windows.Forms.Label lDikKenar2;
        private System.Windows.Forms.TextBox tbDik1;
        private System.Windows.Forms.TextBox tbDik2;
        private System.Windows.Forms.Label lYariCap;
        private System.Windows.Forms.TextBox tbYariCap;
        private System.Windows.Forms.GroupBox gbUcgen;
        private System.Windows.Forms.GroupBox gbDaire;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Button bAlanHesapla;
        private System.Windows.Forms.GroupBox gbKareDikdortgen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

