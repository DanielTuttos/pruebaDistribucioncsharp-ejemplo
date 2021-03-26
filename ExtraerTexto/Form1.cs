using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tesseract;

namespace ExtraerTexto
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {

            
            if ( openFileDialog1.ShowDialog() == DialogResult.OK){
                String strfilename = openFileDialog1.FileName;

                Bitmap imagen = new Bitmap(strfilename);
                pictureBox1.Image = (System.Drawing.Image)imagen;
                String nombreImg = openFileDialog1.SafeFileName;

                var img = new Bitmap(openFileDialog1.FileName);
                var ocr = new TesseractEngine(@"D:\Daniel\aplicaciones\c#\ExtraerTexto\ExtraerTexto\tessdata", "eng",EngineMode.Default);
                var page = ocr.Process(img);
                textBox1.Text = page.GetText();
            }




        }


        private void convertir_Click(object sender, EventArgs e)
        {
            
            DateTimeOffset dateOffsetValue = DateTimeOffset.Parse(fecha_hola.Value.Date.ToString());
            MessageBox.Show("fecha long: " + dateOffsetValue.ToString("fffffff"));
        }
    }
}
