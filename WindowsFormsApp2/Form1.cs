﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            //pictureBox1.Image = barcode.Draw(textBox1.Text, 50);

            if (textBox1.Text != "")
            {
                BarcodeSymbology s = BarcodeSymbology.Code128;
                BarcodeDraw drawObject = BarcodeDrawFactory.GetSymbology(s);
                var metrics = drawObject.GetDefaultMetrics(60);
                metrics.Scale = 2;
                pictureBox1.Image = drawObject.Draw(textBox1.Text, metrics);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                printDialog1.ShowDialog();
            else
                MessageBox.Show("Сгенерируйте код");
        }
    }
}
