using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingEventsBetweenForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var frm2 = new Form2();
            frm2.Show();

            var frm3 = new Form3();
            frm3.Show();
        }
        
    }
}
