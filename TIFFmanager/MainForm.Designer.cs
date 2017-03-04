// COPYRIGHT (c) 2017 Roberto Ceccarelli - CASASOFT
// http://strawberryfield.altervista.org 
// 
// This file is part of CASASOFT TIFFmanager
// 
// CASASOFT TIFFmanager is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CASASOFT TIFFmanager is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CASASOFT TIFFmanager.  If not, see <http://www.gnu.org/licenses/>.

namespace TIFFmanager
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Immagine = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPixelY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPixelX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrigineY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrigineX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBit = new System.Windows.Forms.TextBox();
            this.Bit = new System.Windows.Forms.Label();
            this.txtCanali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLarghezza = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnElabora = new System.Windows.Forms.Button();
            this.btnAnalizza = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabTags = new System.Windows.Forms.TabPage();
            this.txtTags = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFormato = new System.Windows.Forms.TextBox();
            this.Immagine.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabTags.SuspendLayout();
            this.SuspendLayout();
            // 
            // Immagine
            // 
            this.Immagine.Controls.Add(this.tabMain);
            this.Immagine.Controls.Add(this.tabInfo);
            this.Immagine.Controls.Add(this.tabTags);
            this.Immagine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Immagine.Location = new System.Drawing.Point(0, 0);
            this.Immagine.Name = "Immagine";
            this.Immagine.SelectedIndex = 0;
            this.Immagine.Size = new System.Drawing.Size(488, 326);
            this.Immagine.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.label11);
            this.tabMain.Controls.Add(this.txtFormato);
            this.tabMain.Controls.Add(this.label9);
            this.tabMain.Controls.Add(this.txtMax);
            this.tabMain.Controls.Add(this.label10);
            this.tabMain.Controls.Add(this.txtMin);
            this.tabMain.Controls.Add(this.label7);
            this.tabMain.Controls.Add(this.txtPixelY);
            this.tabMain.Controls.Add(this.label8);
            this.tabMain.Controls.Add(this.txtPixelX);
            this.tabMain.Controls.Add(this.label6);
            this.tabMain.Controls.Add(this.txtOrigineY);
            this.tabMain.Controls.Add(this.label5);
            this.tabMain.Controls.Add(this.txtOrigineX);
            this.tabMain.Controls.Add(this.label4);
            this.tabMain.Controls.Add(this.txtBit);
            this.tabMain.Controls.Add(this.Bit);
            this.tabMain.Controls.Add(this.txtCanali);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.txtAltezza);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.txtLarghezza);
            this.tabMain.Controls.Add(this.btnSalva);
            this.tabMain.Controls.Add(this.btnElabora);
            this.tabMain.Controls.Add(this.btnAnalizza);
            this.tabMain.Controls.Add(this.btnOpenFile);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.txtFileName);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(480, 300);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Generale";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Max";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(88, 271);
            this.txtMax.Name = "txtMax";
            this.txtMax.ReadOnly = true;
            this.txtMax.Size = new System.Drawing.Size(60, 20);
            this.txtMax.TabIndex = 34;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(11, 271);
            this.txtMin.Name = "txtMin";
            this.txtMin.ReadOnly = true;
            this.txtMin.Size = new System.Drawing.Size(60, 20);
            this.txtMin.TabIndex = 32;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Dim. Pixel Y";
            // 
            // txtPixelY
            // 
            this.txtPixelY.Location = new System.Drawing.Point(351, 212);
            this.txtPixelY.Name = "txtPixelY";
            this.txtPixelY.ReadOnly = true;
            this.txtPixelY.Size = new System.Drawing.Size(95, 20);
            this.txtPixelY.TabIndex = 30;
            this.txtPixelY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Dim. Pixel X";
            // 
            // txtPixelX
            // 
            this.txtPixelX.Location = new System.Drawing.Point(237, 212);
            this.txtPixelX.Name = "txtPixelX";
            this.txtPixelX.ReadOnly = true;
            this.txtPixelX.Size = new System.Drawing.Size(95, 20);
            this.txtPixelX.TabIndex = 28;
            this.txtPixelX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Origine Y / Lat.";
            // 
            // txtOrigineY
            // 
            this.txtOrigineY.Location = new System.Drawing.Point(122, 212);
            this.txtOrigineY.Name = "txtOrigineY";
            this.txtOrigineY.ReadOnly = true;
            this.txtOrigineY.Size = new System.Drawing.Size(95, 20);
            this.txtOrigineY.TabIndex = 26;
            this.txtOrigineY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Origine X / Long.";
            // 
            // txtOrigineX
            // 
            this.txtOrigineX.Location = new System.Drawing.Point(8, 212);
            this.txtOrigineX.Name = "txtOrigineX";
            this.txtOrigineX.ReadOnly = true;
            this.txtOrigineX.Size = new System.Drawing.Size(95, 20);
            this.txtOrigineX.TabIndex = 24;
            this.txtOrigineX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Bit x canale";
            // 
            // txtBit
            // 
            this.txtBit.Location = new System.Drawing.Point(237, 143);
            this.txtBit.Name = "txtBit";
            this.txtBit.ReadOnly = true;
            this.txtBit.Size = new System.Drawing.Size(60, 20);
            this.txtBit.TabIndex = 22;
            this.txtBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bit
            // 
            this.Bit.AutoSize = true;
            this.Bit.Location = new System.Drawing.Point(163, 127);
            this.Bit.Name = "Bit";
            this.Bit.Size = new System.Drawing.Size(36, 13);
            this.Bit.TabIndex = 21;
            this.Bit.Text = "Canali";
            // 
            // txtCanali
            // 
            this.txtCanali.Location = new System.Drawing.Point(163, 143);
            this.txtCanali.Name = "txtCanali";
            this.txtCanali.ReadOnly = true;
            this.txtCanali.Size = new System.Drawing.Size(60, 20);
            this.txtCanali.TabIndex = 20;
            this.txtCanali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Altezza";
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(88, 143);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.ReadOnly = true;
            this.txtAltezza.Size = new System.Drawing.Size(60, 20);
            this.txtAltezza.TabIndex = 18;
            this.txtAltezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Larghezza";
            // 
            // txtLarghezza
            // 
            this.txtLarghezza.Location = new System.Drawing.Point(11, 143);
            this.txtLarghezza.Name = "txtLarghezza";
            this.txtLarghezza.ReadOnly = true;
            this.txtLarghezza.Size = new System.Drawing.Size(60, 20);
            this.txtLarghezza.TabIndex = 16;
            this.txtLarghezza.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalva
            // 
            this.btnSalva.Enabled = false;
            this.btnSalva.Location = new System.Drawing.Point(321, 68);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(140, 26);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnElabora
            // 
            this.btnElabora.Enabled = false;
            this.btnElabora.Location = new System.Drawing.Point(166, 68);
            this.btnElabora.Name = "btnElabora";
            this.btnElabora.Size = new System.Drawing.Size(140, 26);
            this.btnElabora.TabIndex = 5;
            this.btnElabora.Text = "Elabora";
            this.btnElabora.UseVisualStyleBackColor = true;
            this.btnElabora.Click += new System.EventHandler(this.btnElabora_Click);
            // 
            // btnAnalizza
            // 
            this.btnAnalizza.Enabled = false;
            this.btnAnalizza.Location = new System.Drawing.Point(11, 68);
            this.btnAnalizza.Name = "btnAnalizza";
            this.btnAnalizza.Size = new System.Drawing.Size(140, 26);
            this.btnAnalizza.TabIndex = 4;
            this.btnAnalizza.Text = "Analizza";
            this.btnAnalizza.UseVisualStyleBackColor = true;
            this.btnAnalizza.Click += new System.EventHandler(this.btnAnalizza_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Location = new System.Drawing.Point(427, 31);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(45, 20);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Apri";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File TIFF";
            // 
            // txtFileName
            // 
            this.txtFileName.AllowDrop = true;
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(11, 31);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(410, 20);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFileName_DragDrop);
            this.txtFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFileName_DragEnter);
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.pictureBox);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfo.Size = new System.Drawing.Size(480, 300);
            this.tabInfo.TabIndex = 1;
            this.tabInfo.Text = "Immagine";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(474, 294);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabTags
            // 
            this.tabTags.Controls.Add(this.txtTags);
            this.tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(480, 300);
            this.tabTags.TabIndex = 2;
            this.tabTags.Text = "Tags";
            this.tabTags.UseVisualStyleBackColor = true;
            // 
            // txtTags
            // 
            this.txtTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTags.Location = new System.Drawing.Point(3, 3);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(474, 294);
            this.txtTags.TabIndex = 0;
            this.txtTags.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "File TIFF|*.tif|Tutti i file|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "tif";
            this.saveFileDialog.Filter = "File TIFF|*.tif|Tutti i file|*.*";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Formato";
            // 
            // txtFormato
            // 
            this.txtFormato.Location = new System.Drawing.Point(318, 143);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.ReadOnly = true;
            this.txtFormato.Size = new System.Drawing.Size(60, 20);
            this.txtFormato.TabIndex = 36;
            this.txtFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 326);
            this.Controls.Add(this.Immagine);
            this.Name = "MainForm";
            this.Text = "TIFF manager";
            this.Immagine.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabTags.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Immagine;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnAnalizza;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnElabora;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPixelY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPixelX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrigineY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrigineX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBit;
        private System.Windows.Forms.Label Bit;
        private System.Windows.Forms.TextBox txtCanali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLarghezza;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TabPage tabTags;
        private System.Windows.Forms.RichTextBox txtTags;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFormato;
    }
}

