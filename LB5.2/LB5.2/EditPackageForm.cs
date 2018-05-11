using GiftLibrary;
using LB5._2.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB5._2
{
    public partial class EditPackageForm : Form
    {
        private Gift _gift;
        private MainForm _form;
        private Package _package;

        //Конструктор редактирования
        public EditPackageForm(MainForm form, Gift gift, Package package)
        {
            InitializeComponent();

            _gift = gift;
            _form = form;
            _package = package;

            SetDataSources();
            CopleteFields();

            PackageTypeBox.SelectedIndexChanged += TypeChanged;
        }

        //Конструктор для просмотра
        public EditPackageForm(Package package)
        {
            InitializeComponent();

            _package = package;

            PackageTypeBox.Enabled = false;
            SizeBox.Enabled = false;
            ColorBox.Enabled = false;
            VarietyBox.Enabled = false;

            OkButton.Enabled = false;
            CancButton.Enabled = false;

            CopleteFields();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypeChanged(object sender, EventArgs e)
        {
            switch (PackageTypeBox.SelectedItem.ToString())
            {
                case ("Банка"):
                    label3.Text = "Тип замка";
                    VarietyBox.DataSource = EnumHelper.SnapDict.Keys.ToList();
                    break;
                case ("Коробка"):
                    label3.Text = "Удаляемая крышка";
                    VarietyBox.DataSource = EnumHelper.RemovableLidDict.Keys.ToList();
                    break;
                case ("Пакет"):
                    label3.Text = "Тип ленты";
                    VarietyBox.DataSource = EnumHelper.TapeDict.Keys.ToList();
                    break;
            }
        }

        public void SetDataSources()
        {
            PackageTypeBox.DataSource = EnumHelper.PackageDict.Keys.ToList();

            SizeBox.DataSource = EnumHelper.SizeDict.Keys.ToList();
            ColorBox.DataSource = EnumHelper.ColorDict.Keys.ToList();

            switch (_package.KindofPackage)
            {
                case ("Банка"):
                    VarietyBox.DataSource = EnumHelper.SnapDict.Keys.ToList();
                    break;
                case ("Коробка"):
                    VarietyBox.DataSource = EnumHelper.RemovableLidDict.Keys.ToList();
                    break;
                case ("Пакет"):
                    VarietyBox.DataSource = EnumHelper.TapeDict.Keys.ToList();
                    break;
            }
        }

        public void CopleteFields()
        {
            PackageTypeBox.Text = _package.KindofPackage;

            SizeBox.Text = _package.Size.ToString();

            ColorBox.Text = _package.Color.ToString();

            switch (_package.KindofPackage)
            {
                case ("Банка"):
                    label3.Text = "Тип замка";
                    VarietyBox.Text = ((Can)_package).SnapKind.ToString();
                    break;
                case ("Коробка"):
                    label3.Text = "Удаляемая крышка";
                    VarietyBox.Text = ((Box)_package).RemovableLid.ToString().ToUpper();
                    break;
                case ("Пакет"):
                    label3.Text = "Тип ленты";
                    VarietyBox.Text = ((Pack)_package).Tape.ToString();
                    break;

            }
        }

        public Package CreatePackage()
        {
            var package = EnumHelper.PackageDict[PackageTypeBox.Text];
            package.Color = EnumHelper.ColorDict[ColorBox.Text];
            package.Size = EnumHelper.SizeDict[SizeBox.Text];

            switch (package.KindofPackage)
            {
                case ("Банка"):
                    ((Can)package).SnapKind = EnumHelper.SnapDict[VarietyBox.Text];
                    break;
                case ("Коробка"):
                    ((Box)package).RemovableLid = EnumHelper.RemovableLidDict[VarietyBox.Text];
                    break;
                case ("Пакет"):
                    ((Pack)package).Tape = EnumHelper.TapeDict[VarietyBox.Text];
                    break;

            }

            return package;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            var package = CreatePackage();
            _gift.Package = package;

            //Перерисовка формы подарка
            _form.PaintElements();

            this.Close();
        }

        private void CancButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
