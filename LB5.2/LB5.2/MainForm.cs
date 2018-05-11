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
    public partial class MainForm : Form
    {
        private Gift _gift;
        public MainForm(Gift gift)
        {
            InitializeComponent();
            _gift = gift;
            PaintElements();
        }

        //Перерисовка элементов формы
        public void PaintElements()
        {
            var package = _gift.Package;
            PackageBox.Text = package.KindofPackage;

            var printer = new ListBoxWriter();
            printer.Print(_gift);
            var sweets = _gift.Sweets;
            var sweetsList = new List<Sweetness>();
            sweetsList.AddRange(sweets.Keys);
            SweetnessBox.DataSource = sweetsList;
            SweetnessBox.DisplayMember = "Info";

            GiftWeightLabel.Text = _gift.CalcWeight().ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InfoPackageButton_Click(object sender, EventArgs e)
        {
            var form = new EditPackageForm(_gift.Package);
            form.ShowDialog();

        }

        private void EditPackageButton_Click(object sender, EventArgs e)
        {
            var form = new EditPackageForm(this, _gift, _gift.Package);
            form.ShowDialog();
        }

        private void AddSweetsButton_Click(object sender, EventArgs e)
        {
            var form = new EditSweetnessForm(this, _gift.Sweets);
            form.ShowDialog();

        }

        private void EditSweetsButton_Click(object sender, EventArgs e)
        {
            var sweet = (Sweetness)SweetnessBox.SelectedItem;
            var count = _gift.Sweets[sweet];

            var form = new EditSweetnessForm(this, _gift.Sweets,sweet,count);
            form.ShowDialog();

        }

        private void RemoveSweetsButton_Click(object sender, EventArgs e)
        {
            var sweet = (Sweetness)SweetnessBox.SelectedItem;
            _gift.Sweets.Remove(sweet);
            PaintElements();
        }

        private void InfoSweetnessButton_Click(object sender, EventArgs e)
        {
            var sweet = (Sweetness)SweetnessBox.SelectedItem;
            var count = _gift.Sweets[sweet];

            var form = new EditSweetnessForm(sweet, count);
            form.ShowDialog();
        }

        private void SweetnessBox_DataSourceChanged(object sender, EventArgs e)
        {

        }
    }
}
