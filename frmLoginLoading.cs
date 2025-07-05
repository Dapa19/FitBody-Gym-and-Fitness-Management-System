using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBody
{
    public partial class frmLoginLoading : Form
    {
        public frmLoginLoading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //panel2.Width += 3; // Menambah lebar panel
            //if (panel2.Width >= 597) // Jika loading selesai
            //{
            //    timer1.Stop(); // Hentikan timer
            //    this.Close(); // Tutup splash screen (bukan Application.Exit)
            //}
            panel2.Width += 3; // Menambah lebar panel
            if (panel2.Width >= 400 && panel2.Width <= 597) // Jika loading selesai
            {
                panel2.Width += 5;
            }
            else if (panel2.Width > 597)
            {
                timer1.Stop(); // Hentikan timer
                this.Close(); // Tutup splash screen (bukan Application.Exit)

            }
            
        }

        private void frmLoginLoading_Load(object sender, EventArgs e)
        {
            panel2.Width = 0; // Atur lebar awal panel
            timer1.Interval = 10; // Atur interval timer
            timer1.Start(); // Mulai timer
        }
    }
}
