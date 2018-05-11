using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GiftLibrary;

namespace LB5._2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void CreateGift_Click(object sender, EventArgs e)
        {
            var builder = new GiftBuilder();
            var gift = builder.CreateGift(7);
            var form = new MainForm(gift);
            form.Show();
            this.Hide();
        }
    }
}
