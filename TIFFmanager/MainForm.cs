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

using System;
using System.Globalization;
using System.Windows.Forms;
using Casasoft.TIFFimage;

namespace TIFFmanager
{
    /// <summary>
    /// Main window class
    /// </summary>
    public partial class MainForm : Form
    {
        private TIFFimage image;

        #region costruttori
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filename">Tiff file to manage</param>
        public MainForm(string filename)
        {
            InitializeComponent();
            image = new TIFFimage(filename);
            if (!String.IsNullOrWhiteSpace(image.Error))
            {
                MessageBox.Show(image.Error);
            }
            else
            {
                getImageInfo();
            }
        }
        #endregion

        #region filename
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtFileName.Text = openFileDialog.FileName;
                setButtonsForFile();
            }
        }

        private void txtFileName_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtFileName.Text = files[0];
                setButtonsForFile();
            }
        }

        private void txtFileName_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// Enable disable buttons
        /// </summary>
        private void setButtonsForFile()
        {
            btnAnalizza.Enabled = true;
            btnElabora.Enabled = false;
            btnSalva.Enabled = false;
        }
        #endregion

        /// <summary>
        /// Puts tiff data in the text boxes
        /// </summary>
        private void getImageInfo()
        {
            txtLarghezza.Text = image.Width.ToString();
            txtAltezza.Text = image.Height.ToString();
            txtCanali.Text = image.SamplesPerPixel.ToString();
            txtBit.Text = image.BitsPerSample.ToString();
            txtFormato.Text = image.FormatString;

            txtPixelX.Text = image.PixelSizeX.ToString(CultureInfo.CurrentCulture);
            txtPixelY.Text = image.PixelSizeY.ToString(CultureInfo.CurrentCulture);

            txtOrigineX.Text = image.OriginX.ToString(CultureInfo.CurrentCulture);
            txtOrigineY.Text = image.OriginY.ToString(CultureInfo.CurrentCulture);

            getMinMax();
            txtTags.Text = image.AllTags;

            btnAnalizza.Enabled = false;
            if (image.SamplesPerPixel == 1 && image.BitsPerSample == 32)
            {
                btnElabora.Enabled = true;
            }

            if (image.SamplesPerPixel == 1)
            {
                pictureBox.Image = image.GetBitmap();
            }
        }

        /// <summary>
        /// Get min and max values of the samples
        /// </summary>
        private void getMinMax()
        {
            int minVal, maxVal;
            image.getMinMax(out minVal, out maxVal);
            txtMin.Text = minVal.ToString();
            txtMax.Text = maxVal.ToString();
        }

        #region eventi controlli
        private void btnAnalizza_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            if (String.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("File non specificato.");
                return;
            }

            image = new TIFFimage(fileName);
            getImageInfo();            
        }

 
        private void btnElabora_Click(object sender, EventArgs e)
        {
            image.Normalize();
            pictureBox.Image = image.GetBitmap();
            getMinMax();
            btnSalva.Enabled = true;
            btnElabora.Enabled = false;
        }

        #endregion

        #region salvataggio
        private void btnSalva_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            image.Save(saveFileDialog.FileName);
        }
        #endregion
    }
}
