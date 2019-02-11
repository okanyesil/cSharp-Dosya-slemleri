using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetinBelgesiOlusturma
{
    public partial class frm_kaydet : Form
    {
        public frm_kaydet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Filter = "Metin Dosyası|*.txt";
            saveFileDialog1.Title = "Metin Belgesi Kayıt";
            saveFileDialog1.ShowDialog();
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("kayıt olusturuldu", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_ana frm = new frm_ana();
            frm.Show();
            this.Hide();
        }
    }
}
