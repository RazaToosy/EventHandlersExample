using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingEventsBetweenForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Negotiator.GetInstance().TitleChanged +=  new EventHandler<ChangeTitleEventArgs>(titleChange);
        }

        private void titleChange(object sender, ChangeTitleEventArgs e)
        {
            this.groupBox1.Text = e.TitleName;
        }

    }
}
