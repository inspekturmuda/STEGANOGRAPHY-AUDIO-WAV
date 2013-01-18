using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Steganography_Audio_Wav
{
    public partial class frmStegano : Form
    {
        private TabControl tabCtl;
        private TabPage tabSmbny;
        private TabPage tabTmplPsn;
        private Button btnHslSmbny;
        private TextBox txtHslSmbny;
        private Label label2;
        private TextBox txtSmbnyiFile;
        private RadioButton rdoSmbnyiFile;
        private Button btnSmbnyiFile;
        private Button btnSmbny;
        private TextBox txtPesan;
        private RadioButton rdoPesan;
        private ErrorProvider error;
        private IContainer components;
        private Button btnTmpl;
        private TextBox txtTmplPsn;
        private RadioButton rdoTmplPsn;
        private Button btnHslTmpl;
        private TextBox txtHslTmpl;
        private RadioButton rdoHslTmpl;
        private TabPage tabPage1;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnKunci;
        private TextBox txtKunci;
        private Label lblKunci;
        private Button btnFileWav;
        private TextBox txtFileWav;
        private Label label1;
        private Button btnKunci1;
        private TextBox txtKunci1;
        private Label labelkunci;
        private Button btnEnkrip;
        private TextBox txtEnkrip;
        private Label label9;
        private Label label4;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    
        public frmStegano()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStegano));
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
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCtl.SuspendLayout();
            this.tabSmbny.SuspendLayout();
            this.tabTmplPsn.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtl
            // 
            this.tabCtl.Controls.Add(this.tabSmbny);
            this.tabCtl.Controls.Add(this.tabTmplPsn);
            this.tabCtl.Controls.Add(this.tabPage1);
            resources.ApplyResources(this.tabCtl, "tabCtl");
            this.tabCtl.Name = "tabCtl";
            this.tabCtl.SelectedIndex = 0;
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
            resources.ApplyResources(this.tabSmbny, "tabSmbny");
            this.tabSmbny.Name = "tabSmbny";
            // 
            // btnKunci
            // 
            resources.ApplyResources(this.btnKunci, "btnKunci");
            this.btnKunci.Name = "btnKunci";
            this.btnKunci.UseVisualStyleBackColor = true;
            this.btnKunci.Click += new System.EventHandler(this.btnKunci_Click_1);
            // 
            // btnSmbny
            // 
            resources.ApplyResources(this.btnSmbny, "btnSmbny");
            this.btnSmbny.Name = "btnSmbny";
            this.btnSmbny.UseVisualStyleBackColor = true;
            this.btnSmbny.Click += new System.EventHandler(this.btnEnkrip_Click);
            // 
            // txtKunci
            // 
            this.error.SetIconAlignment(this.txtKunci, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKunci.IconAlignment"))));
            resources.ApplyResources(this.txtKunci, "txtKunci");
            this.txtKunci.Name = "txtKunci";
            this.txtKunci.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // txtPesan
            // 
            this.error.SetIconAlignment(this.txtPesan, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPesan.IconAlignment"))));
            resources.ApplyResources(this.txtPesan, "txtPesan");
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtPesan.Enter += new System.EventHandler(this.txtHslTmpl_Enter);
            // 
            // lblKunci
            // 
            resources.ApplyResources(this.lblKunci, "lblKunci");
            this.lblKunci.Name = "lblKunci";
            // 
            // rdoPesan
            // 
            resources.ApplyResources(this.rdoPesan, "rdoPesan");
            this.rdoPesan.Checked = true;
            this.rdoPesan.Name = "rdoPesan";
            this.rdoPesan.TabStop = true;
            this.rdoPesan.UseVisualStyleBackColor = true;
            this.rdoPesan.CheckedChanged += new System.EventHandler(this.rdoContent_CheckedChanged);
            // 
            // btnFileWav
            // 
            resources.ApplyResources(this.btnFileWav, "btnFileWav");
            this.btnFileWav.Name = "btnFileWav";
            this.btnFileWav.UseVisualStyleBackColor = true;
            this.btnFileWav.Click += new System.EventHandler(this.btnFileWav_Click_1);
            // 
            // btnSmbnyiFile
            // 
            resources.ApplyResources(this.btnSmbnyiFile, "btnSmbnyiFile");
            this.btnSmbnyiFile.Name = "btnSmbnyiFile";
            this.btnSmbnyiFile.UseVisualStyleBackColor = true;
            this.btnSmbnyiFile.Click += new System.EventHandler(this.btnSmbnyiFile_Click);
            // 
            // txtFileWav
            // 
            this.error.SetIconAlignment(this.txtFileWav, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtFileWav.IconAlignment"))));
            resources.ApplyResources(this.txtFileWav, "txtFileWav");
            this.txtFileWav.Name = "txtFileWav";
            this.txtFileWav.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtSmbnyiFile
            // 
            this.error.SetIconAlignment(this.txtSmbnyiFile, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtSmbnyiFile.IconAlignment"))));
            resources.ApplyResources(this.txtSmbnyiFile, "txtSmbnyiFile");
            this.txtSmbnyiFile.Name = "txtSmbnyiFile";
            this.txtSmbnyiFile.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtSmbnyiFile.Enter += new System.EventHandler(this.txtSmbnyiFile_Enter);
            // 
            // rdoSmbnyiFile
            // 
            resources.ApplyResources(this.rdoSmbnyiFile, "rdoSmbnyiFile");
            this.rdoSmbnyiFile.Name = "rdoSmbnyiFile";
            this.rdoSmbnyiFile.UseVisualStyleBackColor = true;
            this.rdoSmbnyiFile.CheckedChanged += new System.EventHandler(this.rdoContent_CheckedChanged);
            // 
            // btnHslSmbny
            // 
            resources.ApplyResources(this.btnHslSmbny, "btnHslSmbny");
            this.btnHslSmbny.Name = "btnHslSmbny";
            this.btnHslSmbny.UseVisualStyleBackColor = true;
            this.btnHslSmbny.Click += new System.EventHandler(this.btnHslEnkrip_Click);
            // 
            // txtHslSmbny
            // 
            resources.ApplyResources(this.txtHslSmbny, "txtHslSmbny");
            this.txtHslSmbny.Name = "txtHslSmbny";
            this.txtHslSmbny.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            resources.ApplyResources(this.tabTmplPsn, "tabTmplPsn");
            this.tabTmplPsn.Name = "tabTmplPsn";
            // 
            // btnKunci1
            // 
            resources.ApplyResources(this.btnKunci1, "btnKunci1");
            this.btnKunci1.Name = "btnKunci1";
            this.btnKunci1.UseVisualStyleBackColor = true;
            this.btnKunci1.Click += new System.EventHandler(this.btnKunci1_Click);
            // 
            // txtKunci1
            // 
            this.error.SetIconAlignment(this.txtKunci1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtKunci1.IconAlignment"))));
            resources.ApplyResources(this.txtKunci1, "txtKunci1");
            this.txtKunci1.Name = "txtKunci1";
            // 
            // labelkunci
            // 
            resources.ApplyResources(this.labelkunci, "labelkunci");
            this.labelkunci.Name = "labelkunci";
            // 
            // btnEnkrip
            // 
            resources.ApplyResources(this.btnEnkrip, "btnEnkrip");
            this.btnEnkrip.Name = "btnEnkrip";
            this.btnEnkrip.UseVisualStyleBackColor = true;
            this.btnEnkrip.Click += new System.EventHandler(this.btnEnkrip_Click_1);
            // 
            // txtEnkrip
            // 
            this.error.SetIconAlignment(this.txtEnkrip, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEnkrip.IconAlignment"))));
            resources.ApplyResources(this.txtEnkrip, "txtEnkrip");
            this.txtEnkrip.Name = "txtEnkrip";
            this.txtEnkrip.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnTmpl
            // 
            resources.ApplyResources(this.btnTmpl, "btnTmpl");
            this.btnTmpl.Name = "btnTmpl";
            this.btnTmpl.UseVisualStyleBackColor = true;
            this.btnTmpl.Click += new System.EventHandler(this.btnTmpl_Click);
            // 
            // txtTmplPsn
            // 
            this.error.SetIconAlignment(this.txtTmplPsn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTmplPsn.IconAlignment"))));
            resources.ApplyResources(this.txtTmplPsn, "txtTmplPsn");
            this.txtTmplPsn.Name = "txtTmplPsn";
            this.txtTmplPsn.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.txtTmplPsn.Enter += new System.EventHandler(this.txtTmplPsn_Enter);
            // 
            // rdoTmplPsn
            // 
            resources.ApplyResources(this.rdoTmplPsn, "rdoTmplPsn");
            this.rdoTmplPsn.Name = "rdoTmplPsn";
            this.rdoTmplPsn.UseVisualStyleBackColor = true;
            // 
            // btnHslTmpl
            // 
            resources.ApplyResources(this.btnHslTmpl, "btnHslTmpl");
            this.btnHslTmpl.Name = "btnHslTmpl";
            this.btnHslTmpl.UseVisualStyleBackColor = true;
            this.btnHslTmpl.Click += new System.EventHandler(this.btnHslTmpl_Click);
            // 
            // txtHslTmpl
            // 
            resources.ApplyResources(this.txtHslTmpl, "txtHslTmpl");
            this.txtHslTmpl.Name = "txtHslTmpl";
            this.txtHslTmpl.TextChanged += new System.EventHandler(this.textField_TextChanged);
            // 
            // rdoHslTmpl
            // 
            resources.ApplyResources(this.rdoHslTmpl, "rdoHslTmpl");
            this.rdoHslTmpl.Checked = true;
            this.rdoHslTmpl.Name = "rdoHslTmpl";
            this.rdoHslTmpl.TabStop = true;
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
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmStegano
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tabCtl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmStegano";
            this.tabCtl.ResumeLayout(false);
            this.tabSmbny.ResumeLayout(false);
            this.tabSmbny.PerformLayout();
            this.tabTmplPsn.ResumeLayout(false);
            this.tabTmplPsn.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }






        private void AmbilFile(FileDialog dialog, TextBox control, bool useFilter)
        {
            if(useFilter){ dialog.Filter = "Wave Audio (*.wav)|*.wav"; }
            if (dialog.ShowDialog(this) == DialogResult.OK)
            
                control.Text = dialog.FileName;
            
        }



        private void btnEnkrip_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtEnkrip, true);
        }

        private void btnKunci1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtKunci1, false);
        }


        private void btnFileWav_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtFileWav, true);
        }

        private void btnKunci_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtKunci, false);

        }

        private void btnHslEnkrip_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            AmbilFile(dlg,txtHslSmbny, true);
        }

       

        private void btnSmbnyiFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            AmbilFile(dlg, txtSmbnyiFile, false);
            rdoSmbnyiFile.Checked = true;
        }


        private void btnHslTmpl_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
           AmbilFile(dlg, txtHslTmpl, false);
            rdoHslTmpl.Checked = true;
        }





        private void btnEnkrip_Click(object sender, EventArgs e)
        {
            if  (txtFileWav.Text.Length==0)
            {
                error.SetError(txtFileWav, "Anda harus memasukkan file wav");
            }
            else if (txtKunci.Text.Length == 0)
            {
                error.SetError(txtKunci, "Kunci tidak boleh kosong!");
            }
            else if (txtHslSmbny.Text.Length==0)
            {
                error.SetError(txtHslSmbny, "Hasil enkripsi tidak boleh kosong!.");
            }
            else if (rdoSmbnyiFile.Checked && (txtSmbnyiFile.Text.Length == 0))
            {
                error.SetError(txtSmbnyiFile, "File yang di sembunyikan tidak boleh kosong!");
            }
            else if (rdoPesan.Checked && (txtPesan.Text.Length == 0))
            {
                error.SetError(txtPesan, "Pesan yang di sembunyika tidak boleh kosong!");
            }
            else
            {
                MessageBox.Show("File/Pesan sudah di sembunyikan");
                Stream sourceStream = null;
                FileStream destinationStream = null;
                WaveStream audioStream = null;

                
                Stream messageStream = GetMessageStream();
               
                Stream keyStream = new FileStream(txtKunci.Text, FileMode.Open);

                try
                {

                 
                    long countSamplesRequired = WaveUtility.CheckKeyForMessage(keyStream, messageStream.Length);

                    if (countSamplesRequired > Int32.MaxValue)
                    {
                        throw new Exception("Pesan terlalu panjang atau kunci tidak cocok, Kombinasi pesan/kunci membutuhkan" + countSamplesRequired + " Sampel hanya " + Int32.MaxValue + " yang diperbolehkan.");
                    }

                  
                  
                        sourceStream = new FileStream(txtFileWav.Text, FileMode.Open);
                    
                   
                    this.Cursor = Cursors.WaitCursor;

                   
                    destinationStream = new FileStream(txtHslSmbny.Text, FileMode.Create);

                  
                    audioStream = new WaveStream(sourceStream, destinationStream);
                    if (audioStream.Length <= 0)
                    {
                        throw new Exception("File wav gagal");
                    }

                   
                    if (countSamplesRequired > audioStream.CountSamples)
                    {
                        String errorReport = "File terlalu kecil untuk pesan dan kunci\r\n"
                            + "Sampel yang tersedia: " + audioStream.CountSamples + "\r\n"
                            + "Sampel yang dibutuhkan: " + countSamplesRequired;
                        throw new Exception(errorReport);
                    }

                   
                    WaveUtility utility = new WaveUtility(audioStream, destinationStream);
                    utility.Hide(messageStream, keyStream);
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (keyStream != null) { keyStream.Close(); }
                    if (messageStream != null) { messageStream.Close(); }
                    if (audioStream != null) { audioStream.Close(); }
                    if (sourceStream != null) { sourceStream.Close(); }
                    if (destinationStream != null) { destinationStream.Close(); }
                    this.Cursor = Cursors.Default;
                }
            }
        }



        private void btnTmpl_Click(object sender, EventArgs e)
        {
            
            if (txtEnkrip.Text.Length == 0)
            {
                error.SetError(txtFileWav, "File Wav Enkrip tidak boleh kososng!");
            }
            else if (txtKunci1.Text.Length == 0)
            {
                error.SetError(txtKunci, "Kunci Tidak Boleh Kosong!");
            }
            else
            {
               
                this.Cursor = Cursors.WaitCursor;

                FileStream sourceStream = null;
                WaveStream audioStream = null;
                MemoryStream messageStream = new MemoryStream();
                Stream keyStream = new FileStream(txtKunci1.Text, FileMode.Open);

                try
                {
                    
                
                    sourceStream = new FileStream(txtEnkrip.Text, FileMode.Open);
                    audioStream = new WaveStream(sourceStream);
                    WaveUtility utility = new WaveUtility(audioStream);

                   
                    utility.Extract(messageStream, keyStream);

                    messageStream.Seek(0, SeekOrigin.Begin);
                    if (rdoHslTmpl.Checked)
                    { 
                        MessageBox.Show("Pesan Sudah disimpan");
                        FileStream fs = new FileStream(txtHslTmpl.Text, FileMode.Create);

                        byte[] buffer = new byte[messageStream.Length];
                        messageStream.Read(buffer, 0, buffer.Length);
                        fs.Write(buffer, 0, buffer.Length);
                        fs.Close();
                    }
                    else
                    { 
                        MessageBox.Show("Pesan Akan ditampilkan");
                        txtTmplPsn.Text = new StreamReader(messageStream).ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (keyStream != null) { keyStream.Close(); }
                    if (messageStream != null) { messageStream.Close(); }
                    if (audioStream != null) { audioStream.Close(); }
                    if (sourceStream != null) { sourceStream.Close(); }
                    this.Cursor = Cursors.Default;
                }
            }

        }




        private Stream GetMessageStream()
        {
            BinaryWriter messageWriter = new BinaryWriter(new MemoryStream());
            if (rdoSmbnyiFile.Checked)
            {
                FileStream fs = new FileStream(txtSmbnyiFile.Text, FileMode.Open);
                int fileLength = (int)fs.Length;
                messageWriter.Write(fileLength);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, fileLength);
                messageWriter.Write(buffer);
                fs.Close();
            }
            else
            {
                messageWriter.Write(txtPesan.Text.Length);
                messageWriter.Write(Encoding.ASCII.GetBytes(txtPesan.Text));
            }
            messageWriter.Seek(0, SeekOrigin.Begin);
            return messageWriter.BaseStream;
        }


        private void textField_TextChanged(object sender, System.EventArgs e)
        {
            error.SetError((Control)sender, String.Empty);
        }

        private void rdoContent_CheckedChanged(object sender, System.EventArgs e)
        {
            txtSmbnyiFile.Enabled = btnSmbnyiFile.Enabled = rdoSmbnyiFile.Checked;
            txtPesan.Enabled = rdoPesan.Checked;
        }

        private void txtSmbnyiFile_Enter(object sender, System.EventArgs e)
        {
            rdoSmbnyiFile.Checked = true;
        }

        private void txtPesan_Enter(object sender, System.EventArgs e)
        {
            rdoPesan.Checked = true;
        }

        private void txtPesan_TextChanged(object sender, System.EventArgs e)
        {
            error.SetError((Control)sender, String.Empty);
        }

        private void txtSmbnyiFile_TextChanged(object sender, System.EventArgs e)
        {
            error.SetError((Control)sender, String.Empty);
        }

        private void txtFileWav_TextChanged(object sender, EventArgs e)
        {
            error.SetError((Control)sender, String.Empty);
        }

        private void txtHslTmpl_Enter(object sender, System.EventArgs e)
        {
            rdoHslTmpl.Checked = true;
        }

        private void txtTmplPsn_Enter(object sender, System.EventArgs e)
        {
            rdoTmplPsn.Checked = true;
        }

       

       
   

       
    }
}
