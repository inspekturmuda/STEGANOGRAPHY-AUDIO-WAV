namespace STEGANOGRAPHY_WAV
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
<<<<<<< HEAD
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(502, 387);
            this.tabControl1.TabIndex = 0;
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCtl = new System.Windows.Forms.TabControl();
            this.tabSmbny = new System.Windows.Forms.TabPage();
            this.btnKunci = new System.Windows.Forms.Button();
            this.btnSmbny = new System.Windows.Forms.Button();
            this.txtKunci = new System.Windows.Forms.TextBox();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.lblKunci = new System.Windows.Forms.Label();
            this.rdoPesan = new System.Windows.Forms.RadioButton();
            this.btnFileWav = new System.Windows.Forms.Button();
            this.btnSmbnyiFile = new System.Windows.Forms.Button();
            this.txtFileWav = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSmbnyiFile = new System.Windows.Forms.TextBox();
            this.rdoSmbnyiFile = new System.Windows.Forms.RadioButton();
            this.btnHslSmbny = new System.Windows.Forms.Button();
            this.txtHslSmbny = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTmplPsn = new System.Windows.Forms.TabPage();
            this.btnKunci1 = new System.Windows.Forms.Button();
            this.txtKunci1 = new System.Windows.Forms.TextBox();
            this.labelkunci = new System.Windows.Forms.Label();
            this.btnEnkrip = new System.Windows.Forms.Button();
            this.txtEnkrip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTmpl = new System.Windows.Forms.Button();
            this.txtTmplPsn = new System.Windows.Forms.TextBox();
            this.rdoTmplPsn = new System.Windows.Forms.RadioButton();
            this.btnHslTmpl = new System.Windows.Forms.Button();
            this.txtHslTmpl = new System.Windows.Forms.TextBox();
            this.rdoHslTmpl = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCtl.SuspendLayout();
            this.tabSmbny.SuspendLayout();
            this.tabTmplPsn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabSmbny);
            this.tabCtl.Controls.Add(this.tabTmplPsn);
            this.tabCtl.Controls.Add(this.tabPage1);
            this.tabCtl.Location = new System.Drawing.Point(12, 2);
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
            this.tabCtl.Size = new System.Drawing.Size(470, 546);
            this.tabCtl.TabIndex = 7;
            // 
            // tabSmbny
            // 
            this.tabSmbny.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabSmbny.Controls.Add(this.btnKunci);
            this.tabSmbny.Controls.Add(this.btnSmbny);
            this.tabSmbny.Controls.Add(this.txtKunci);
            this.tabSmbny.Controls.Add(this.txtPesan);
            this.tabSmbny.Controls.Add(this.lblKunci);
            this.tabSmbny.Controls.Add(this.rdoPesan);
            this.tabSmbny.Controls.Add(this.btnFileWav);
            this.tabSmbny.Controls.Add(this.btnSmbnyiFile);
            this.tabSmbny.Controls.Add(this.txtFileWav);
            this.tabSmbny.Controls.Add(this.label1);
            this.tabSmbny.Controls.Add(this.txtSmbnyiFile);
            this.tabSmbny.Controls.Add(this.rdoSmbnyiFile);
            this.tabSmbny.Controls.Add(this.btnHslSmbny);
            this.tabSmbny.Controls.Add(this.txtHslSmbny);
            this.tabSmbny.Controls.Add(this.label2);
            this.tabSmbny.Location = new System.Drawing.Point(4, 22);
            this.tabSmbny.Name = "tabSmbny";
            this.tabSmbny.Padding = new System.Windows.Forms.Padding(3);
            this.tabSmbny.Size = new System.Drawing.Size(462, 520);
            this.tabSmbny.TabIndex = 0;
            this.tabSmbny.Text = "Sembunyi Pesan";
            // 
            // btnKunci
            // 
            this.btnKunci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKunci.Location = new System.Drawing.Point(347, 68);
            this.btnKunci.Name = "btnKunci";
            this.btnKunci.Size = new System.Drawing.Size(75, 23);
            this.btnKunci.TabIndex = 17;
            this.btnKunci.Text = "Browse";
            this.btnKunci.UseVisualStyleBackColor = true;
            // 
            // btnSmbny
            // 
            this.btnSmbny.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSmbny.Location = new System.Drawing.Point(195, 446);
            this.btnSmbny.Name = "btnSmbny";
            this.btnSmbny.Size = new System.Drawing.Size(95, 23);
            this.btnSmbny.TabIndex = 8;
            this.btnSmbny.Text = "Sembunyikan";
            this.btnSmbny.UseVisualStyleBackColor = true;
            // 
            // txtKunci
            // 
            this.txtKunci.Location = new System.Drawing.Point(122, 70);
            this.txtKunci.Name = "txtKunci";
            this.txtKunci.Size = new System.Drawing.Size(192, 20);
            this.txtKunci.TabIndex = 16;
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(120, 262);
            this.txtPesan.Multiline = true;
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(265, 133);
            this.txtPesan.TabIndex = 7;
            // 
            // lblKunci
            // 
            this.lblKunci.AutoSize = true;
            this.lblKunci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblKunci.Location = new System.Drawing.Point(59, 73);
            this.lblKunci.Name = "lblKunci";
            this.lblKunci.Size = new System.Drawing.Size(34, 13);
            this.lblKunci.TabIndex = 15;
            this.lblKunci.Text = "Kunci";
            // 
            // rdoPesan
            // 
            this.rdoPesan.AutoSize = true;
            this.rdoPesan.Checked = true;
            this.rdoPesan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoPesan.Location = new System.Drawing.Point(23, 251);
            this.rdoPesan.Name = "rdoPesan";
            this.rdoPesan.Size = new System.Drawing.Size(55, 17);
            this.rdoPesan.TabIndex = 6;
            this.rdoPesan.TabStop = true;
            this.rdoPesan.Text = "Pesan";
            this.rdoPesan.UseVisualStyleBackColor = true;
            // 
            // btnFileWav
            // 
            this.btnFileWav.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFileWav.Location = new System.Drawing.Point(341, 14);
            this.btnFileWav.Name = "btnFileWav";
            this.btnFileWav.Size = new System.Drawing.Size(75, 23);
            this.btnFileWav.TabIndex = 14;
            this.btnFileWav.Text = "Browse";
            this.btnFileWav.UseVisualStyleBackColor = true;
            // 
            // btnSmbnyiFile
            // 
            this.btnSmbnyiFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSmbnyiFile.Location = new System.Drawing.Point(358, 197);
            this.btnSmbnyiFile.Name = "btnSmbnyiFile";
            this.btnSmbnyiFile.Size = new System.Drawing.Size(75, 23);
            this.btnSmbnyiFile.TabIndex = 5;
            this.btnSmbnyiFile.Text = "Browse";
            this.btnSmbnyiFile.UseVisualStyleBackColor = true;
            // 
            // txtFileWav
            // 
            this.txtFileWav.Location = new System.Drawing.Point(120, 18);
            this.txtFileWav.Name = "txtFileWav";
            this.txtFileWav.Size = new System.Drawing.Size(194, 20);
            this.txtFileWav.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(56, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "File Wav";
            // 
            // txtSmbnyiFile
            // 
            this.txtSmbnyiFile.Location = new System.Drawing.Point(145, 197);
            this.txtSmbnyiFile.Name = "txtSmbnyiFile";
            this.txtSmbnyiFile.Size = new System.Drawing.Size(195, 20);
            this.txtSmbnyiFile.TabIndex = 4;
            // 
            // rdoSmbnyiFile
            // 
            this.rdoSmbnyiFile.AutoSize = true;
            this.rdoSmbnyiFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoSmbnyiFile.Location = new System.Drawing.Point(22, 197);
            this.rdoSmbnyiFile.Name = "rdoSmbnyiFile";
            this.rdoSmbnyiFile.Size = new System.Drawing.Size(108, 17);
            this.rdoSmbnyiFile.TabIndex = 3;
            this.rdoSmbnyiFile.Text = "Sembunyikan File";
            this.rdoSmbnyiFile.UseVisualStyleBackColor = true;
            // 
            // btnHslSmbny
            // 
            this.btnHslSmbny.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHslSmbny.Location = new System.Drawing.Point(356, 145);
            this.btnHslSmbny.Name = "btnHslSmbny";
            this.btnHslSmbny.Size = new System.Drawing.Size(75, 23);
            this.btnHslSmbny.TabIndex = 2;
            this.btnHslSmbny.Text = "Borwse";
            this.btnHslSmbny.UseVisualStyleBackColor = true;
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5
            // 
            // txtHslSmbny
            // 
<<<<<<< HEAD
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sembunyi Pesan";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tampilkan Pesan";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(494, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tentang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Wav";
=======
            this.txtHslSmbny.Location = new System.Drawing.Point(139, 146);
            this.txtHslSmbny.Name = "txtHslSmbny";
            this.txtHslSmbny.Size = new System.Drawing.Size(201, 20);
            this.txtHslSmbny.TabIndex = 1;
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kunci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simpan Hasil";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 20);
            this.textBox2.TabIndex = 4;
=======
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Simpan Hasil ";
            // 
            // tabTmplPsn
            // 
            this.tabTmplPsn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabTmplPsn.Controls.Add(this.btnKunci1);
            this.tabTmplPsn.Controls.Add(this.txtKunci1);
            this.tabTmplPsn.Controls.Add(this.labelkunci);
            this.tabTmplPsn.Controls.Add(this.btnEnkrip);
            this.tabTmplPsn.Controls.Add(this.txtEnkrip);
            this.tabTmplPsn.Controls.Add(this.label9);
            this.tabTmplPsn.Controls.Add(this.btnTmpl);
            this.tabTmplPsn.Controls.Add(this.txtTmplPsn);
            this.tabTmplPsn.Controls.Add(this.rdoTmplPsn);
            this.tabTmplPsn.Controls.Add(this.btnHslTmpl);
            this.tabTmplPsn.Controls.Add(this.txtHslTmpl);
            this.tabTmplPsn.Controls.Add(this.rdoHslTmpl);
            this.tabTmplPsn.Location = new System.Drawing.Point(4, 22);
            this.tabTmplPsn.Name = "tabTmplPsn";
            this.tabTmplPsn.Padding = new System.Windows.Forms.Padding(3);
            this.tabTmplPsn.Size = new System.Drawing.Size(462, 520);
            this.tabTmplPsn.TabIndex = 1;
            this.tabTmplPsn.Text = "Tampilkan Pesan";
            // 
            // btnKunci1
            // 
            this.btnKunci1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKunci1.Location = new System.Drawing.Point(358, 58);
            this.btnKunci1.Name = "btnKunci1";
            this.btnKunci1.Size = new System.Drawing.Size(75, 23);
            this.btnKunci1.TabIndex = 11;
            this.btnKunci1.Text = "Browse";
            this.btnKunci1.UseVisualStyleBackColor = true;
            // 
            // txtKunci1
            // 
            this.txtKunci1.Location = new System.Drawing.Point(146, 58);
            this.txtKunci1.Name = "txtKunci1";
            this.txtKunci1.Size = new System.Drawing.Size(204, 20);
            this.txtKunci1.TabIndex = 10;
            // 
            // labelkunci
            // 
            this.labelkunci.AutoSize = true;
            this.labelkunci.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelkunci.Location = new System.Drawing.Point(22, 65);
            this.labelkunci.Name = "labelkunci";
            this.labelkunci.Size = new System.Drawing.Size(34, 13);
            this.labelkunci.TabIndex = 9;
            this.labelkunci.Text = "Kunci";
            // 
            // btnEnkrip
            // 
            this.btnEnkrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnkrip.Location = new System.Drawing.Point(357, 16);
            this.btnEnkrip.Name = "btnEnkrip";
            this.btnEnkrip.Size = new System.Drawing.Size(75, 23);
            this.btnEnkrip.TabIndex = 8;
            this.btnEnkrip.Text = "Browse";
            this.btnEnkrip.UseVisualStyleBackColor = true;
            // 
            // txtEnkrip
            // 
            this.txtEnkrip.Location = new System.Drawing.Point(146, 18);
            this.txtEnkrip.Name = "txtEnkrip";
            this.txtEnkrip.Size = new System.Drawing.Size(204, 20);
            this.txtEnkrip.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(19, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "File wav enkrip:";
            // 
            // btnTmpl
            // 
            this.btnTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTmpl.Location = new System.Drawing.Point(195, 434);
            this.btnTmpl.Name = "btnTmpl";
            this.btnTmpl.Size = new System.Drawing.Size(75, 23);
            this.btnTmpl.TabIndex = 5;
            this.btnTmpl.Text = "Tampilkan";
            this.btnTmpl.UseVisualStyleBackColor = true;
            // 
            // txtTmplPsn
            // 
            this.txtTmplPsn.Location = new System.Drawing.Point(146, 252);
            this.txtTmplPsn.Multiline = true;
            this.txtTmplPsn.Name = "txtTmplPsn";
            this.txtTmplPsn.Size = new System.Drawing.Size(286, 129);
            this.txtTmplPsn.TabIndex = 4;
            // 
            // rdoTmplPsn
            // 
            this.rdoTmplPsn.AutoSize = true;
            this.rdoTmplPsn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoTmplPsn.Location = new System.Drawing.Point(15, 243);
            this.rdoTmplPsn.Name = "rdoTmplPsn";
            this.rdoTmplPsn.Size = new System.Drawing.Size(107, 17);
            this.rdoTmplPsn.TabIndex = 3;
            this.rdoTmplPsn.Text = "Tampilkan Pesan";
            this.rdoTmplPsn.UseVisualStyleBackColor = true;
            // 
            // btnHslTmpl
            // 
            this.btnHslTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHslTmpl.Location = new System.Drawing.Point(357, 188);
            this.btnHslTmpl.Name = "btnHslTmpl";
            this.btnHslTmpl.Size = new System.Drawing.Size(75, 23);
            this.btnHslTmpl.TabIndex = 2;
            this.btnHslTmpl.Text = "Browse";
            this.btnHslTmpl.UseVisualStyleBackColor = true;
            // 
            // txtHslTmpl
            // 
            this.txtHslTmpl.Location = new System.Drawing.Point(148, 191);
            this.txtHslTmpl.Name = "txtHslTmpl";
            this.txtHslTmpl.Size = new System.Drawing.Size(175, 20);
            this.txtHslTmpl.TabIndex = 1;
            // 
            // rdoHslTmpl
            // 
            this.rdoHslTmpl.AutoSize = true;
            this.rdoHslTmpl.Checked = true;
            this.rdoHslTmpl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoHslTmpl.Location = new System.Drawing.Point(17, 192);
            this.rdoHslTmpl.Name = "rdoHslTmpl";
            this.rdoHslTmpl.Size = new System.Drawing.Size(89, 17);
            this.rdoHslTmpl.TabIndex = 0;
            this.rdoHslTmpl.TabStop = true;
            this.rdoHslTmpl.Text = "Simpan Hasil ";
            this.rdoHslTmpl.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(462, 520);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Tentang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(171, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kelas: IF_9 \r\nMatkul:Sistem Multimedia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(294, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 52);
            this.label7.TabIndex = 4;
            this.label7.Text = "Firdaus Musyafi\r\nRahmat Syahputra Siahaan\r\nCandi Nursadi\r\nRaju Riyanda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(35, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 52);
            this.label6.TabIndex = 3;
            this.label6.Text = "10109366\r\n10109386\r\n10109397\r\n10109399";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(297, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(37, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NIM";
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5
            // 
            // textBox3
            // 
<<<<<<< HEAD
            this.textBox3.Location = new System.Drawing.Point(151, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 20);
            this.textBox4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sembunyikan File";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 183);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pesan";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 182);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(296, 118);
            this.textBox5.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Sembunyikan";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "File Wav Enkrip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kunci";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 126);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Simpan Hasil";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 163);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(107, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tampilkan Pesan";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 20);
            this.textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(152, 54);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(203, 20);
            this.textBox7.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(152, 125);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(203, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(152, 162);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(295, 128);
            this.textBox9.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(372, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = " Browse";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(372, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Browse";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(372, 123);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Browse";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(152, 307);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Tampilkan";
            this.button9.UseVisualStyleBackColor = true;
=======
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Steganography Audio File Wav (Penyembunyian Pesan File Wav)";
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(526, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Steganography WAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
=======
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(500, 594);
            this.Controls.Add(this.tabCtl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Steganography WAV";
            this.tabCtl.ResumeLayout(false);
            this.tabSmbny.ResumeLayout(false);
            this.tabSmbny.PerformLayout();
            this.tabTmplPsn.ResumeLayout(false);
            this.tabTmplPsn.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
=======
        private System.Windows.Forms.TabControl tabCtl;
        private System.Windows.Forms.TabPage tabSmbny;
        private System.Windows.Forms.Button btnKunci;
        private System.Windows.Forms.Button btnSmbny;
        private System.Windows.Forms.TextBox txtKunci;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.Label lblKunci;
        private System.Windows.Forms.RadioButton rdoPesan;
        private System.Windows.Forms.Button btnFileWav;
        private System.Windows.Forms.Button btnSmbnyiFile;
        private System.Windows.Forms.TextBox txtFileWav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSmbnyiFile;
        private System.Windows.Forms.RadioButton rdoSmbnyiFile;
        private System.Windows.Forms.Button btnHslSmbny;
        private System.Windows.Forms.TextBox txtHslSmbny;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabTmplPsn;
        private System.Windows.Forms.Button btnKunci1;
        private System.Windows.Forms.TextBox txtKunci1;
        private System.Windows.Forms.Label labelkunci;
        private System.Windows.Forms.Button btnEnkrip;
        private System.Windows.Forms.TextBox txtEnkrip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTmpl;
        private System.Windows.Forms.TextBox txtTmplPsn;
        private System.Windows.Forms.RadioButton rdoTmplPsn;
        private System.Windows.Forms.Button btnHslTmpl;
        private System.Windows.Forms.TextBox txtHslTmpl;
        private System.Windows.Forms.RadioButton rdoHslTmpl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
>>>>>>> e4fe4452f9ddc227b3109943059df272a28bf8f5

    }
}

