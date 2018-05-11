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
    internal enum Case
    {
        ДОБАВИТЬ,
        ПРОСМОТРЕТЬ,
        РЕДАКТИРОВАТЬ
    }

    public partial class EditSweetnessForm : Form
    {
        private Case _case;
        private Dictionary<Sweetness, int> _sweets;
        private Sweetness _sweetness;
        private MainForm _form;

        //Конструктор для просмотра
        public EditSweetnessForm(Sweetness sweetness, int count)
        {
            InitializeComponent();
            CompleteFilds(sweetness, count);
            DisableAll();
            _case = Case.ПРОСМОТРЕТЬ;
        }

        //конструктор для редактирования
        public EditSweetnessForm(MainForm form, Dictionary<Sweetness, int> sweets ,Sweetness sweetness, int count)
        {
            InitializeComponent();
            CompleteFilds(sweetness, count);
            _case = Case.РЕДАКТИРОВАТЬ;
            _sweets = sweets;
            _sweetness = sweetness;
            _form = form;
            SetDataSources();

            SweethessKindBox.SelectedIndexChanged += ChangeType;
        }

        //Конструктор для добавления
        public EditSweetnessForm(MainForm form, Dictionary<Sweetness, int> sweets)
        {
            InitializeComponent();

            SweethessKindBox.SelectedIndexChanged += ChangeType;

            _case = Case.ДОБАВИТЬ;
            _sweets = sweets;
            _form = form;
            SetDataSources();

            
        }

        public void ChangeType(object sender, EventArgs e)
        {
            var typeName = SweethessKindBox.Text;

            switch (typeName)
            {
                case ("Карамель"):
                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Enabled = true;
                    CaramelKindBox.Enabled = true;
                    TasteBox.Enabled = true;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Enabled = true;
                    break;

                case ("Шоколадка"):
                    ChocolateKindBox.Enabled = true;
                    ShellKindBox.Enabled = false;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = false;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Enabled = false;
                    break;

                case ("Шоколадная конфета"):
                    ChocolateKindBox.Enabled = true;
                    ShellKindBox.Enabled = false;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = false;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Enabled = true;
                    break;

                case ("Желе"):
                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Enabled = true;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = true;
                    JellyConsistencyBox.Enabled = true;
                    CandyShapeBox.Enabled = true;
                    break;

                case ("Нуга"):
                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Enabled = true;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = true;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Enabled = true;
                    break;
            }
        }

        public void CompleteFilds(Sweetness sweetness, int count)
        {
            var sweetnessType = sweetness.GetType().ToString();
            switch(sweetnessType)
            {
                case ("GiftLibrary.Caramel"):
                    SweethessKindBox.Text = "Карамель";

                    var item1 = (Caramel)sweetness;

                    FillingTypeBox.Text = item1.Filling == null ? "" : item1.Filling.Kind;
                    FillingWeightBox.Text = item1.FilingWeight.ToString();
                    SweetnesNameBox.Text = item1.Name;
                    CompanyNameBox.Text = item1.CompanyName;
                    SweetnessWeightBox.Text = item1.CalcWeight().ToString();
                    SweetsCountBox.Text = count.ToString();

                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Text = item1.Shell.ToString();
                    CaramelKindBox.Text = item1.Kind.ToString();
                    TasteBox.Text = item1.Taste.ToString();
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Text = item1.Shape.ToString();

                    break;
                case ("GiftLibrary.Chocolate"):
                    SweethessKindBox.Text = "Шоколадка";

                    var item2 = (Chocolate)sweetness;

                    FillingTypeBox.Text = item2.Filling == null? "" : item2.Filling.Kind;
                    FillingWeightBox.Text = item2.FilingWeight.ToString();
                    SweetnesNameBox.Text = item2.Name;
                    CompanyNameBox.Text = item2.CompanyName;
                    SweetnessWeightBox.Text = item2.CalcWeight().ToString();
                    SweetsCountBox.Text = count.ToString();

                    ChocolateKindBox.Text = item2.ChocolateKind.ToString();
                    ShellKindBox.Enabled = false;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = false;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Enabled = false;

                    break;

                case ("GiftLibrary.ChocolateCandy"):
                    SweethessKindBox.Text = "Шоколадная конфета";

                    var item3 = (ChocolateCandy)sweetness;

                    FillingTypeBox.Text = item3.Filling == null ? "" : item3.Filling.Kind;
                    FillingWeightBox.Text = item3.FilingWeight.ToString();
                    SweetnesNameBox.Text = item3.Name;
                    CompanyNameBox.Text = item3.CompanyName;
                    SweetnessWeightBox.Text = item3.CalcWeight().ToString();
                    SweetsCountBox.Text = count.ToString();

                    ChocolateKindBox.Text = item3.ChocolateKind.ToString();
                    ShellKindBox.Enabled = false;
                    CaramelKindBox.Enabled = false;
                    TasteBox.Enabled = false;
                    JellyConsistencyBox.Enabled = false;
                    CandyShapeBox.Text = item3.Shape.ToString();

                    break;

                case ("GiftLibrary.Jelly"):
                    SweethessKindBox.Text = "Желе";

                    var item4 = (Jelly)sweetness;

                    FillingTypeBox.Text = item4.Filling == null ? "" : item4.Filling.Kind;
                    FillingWeightBox.Text = item4.FilingWeight.ToString();
                    SweetnesNameBox.Text = item4.Name;
                    CompanyNameBox.Text = item4.CompanyName;
                    SweetnessWeightBox.Text = item4.CalcWeight().ToString();
                    SweetsCountBox.Text = count.ToString();

                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Text = item4.Shell.ToString();
                    CaramelKindBox.Enabled = false;
                    TasteBox.Text = item4.Taste.ToString();
                    JellyConsistencyBox.Text = item4.Consistency.ToString();
                    CandyShapeBox.Text = item4.Shape.ToString();

                    break;

                case ("GiftLibrary.Nougat"):
                    SweethessKindBox.Text = "Нуга";

                    var item5 = (Nougat)sweetness;

                    FillingTypeBox.Text = item5.Filling == null ? "" : item5.Filling.Kind;
                    FillingWeightBox.Text = item5.FilingWeight.ToString();
                    SweetnesNameBox.Text = item5.Name;
                    CompanyNameBox.Text = item5.CompanyName;
                    SweetnessWeightBox.Text = item5.CalcWeight().ToString();
                    SweetsCountBox.Text = count.ToString();

                    ChocolateKindBox.Enabled = false;
                    ShellKindBox.Text = item5.Shell.ToString();
                    CaramelKindBox.Enabled = false;
                    TasteBox.Text = item5.Taste.ToString();
                    JellyConsistencyBox.Enabled = false; 
                    CandyShapeBox.Text = item5.Shape.ToString();

                    break;
            }

        }

        //Устанавливает списки для combobox
        public void SetDataSources()
        {
            SweethessKindBox.DataSource = EnumHelper.SweetnessDict.Keys.ToList();

            ChocolateKindBox.DataSource = EnumHelper.ChocolateDict.Keys.ToList();
            ShellKindBox.DataSource = EnumHelper.ShellDict.Keys.ToList();
            CaramelKindBox.DataSource = EnumHelper.CaramelKindDict.Keys.ToList();
            TasteBox.DataSource = EnumHelper.TasteDict.Keys.ToList();
            JellyConsistencyBox.DataSource = EnumHelper.ConsistencyDict.Keys.ToList();
            CandyShapeBox.DataSource = EnumHelper.ShapeDict.Keys.ToList();
        }

        //Создание сладости в соответствии с полями
        public Sweetness CreateSweetness()
        {
            var sweetness = EnumHelper.SweetnessDict[SweethessKindBox.Text.ToString()].Create();

            sweetness.CompanyName = CompanyNameBox.Text;
            sweetness.Filling = new Filling { Kind = FillingTypeBox.Text };
            sweetness.Name = SweetnesNameBox.Text;

            try
            {
                if (double.Parse(FillingWeightBox.Text) <= 0) throw new FormatException("Неверный формат");
                if (double.Parse(SweetnessWeightBox.Text) <= 0) throw new FormatException("Неверный формат");

                sweetness.FilingWeight = double.Parse(FillingWeightBox.Text);
                sweetness.SelfWeight = double.Parse(SweetnessWeightBox.Text);
            }
            catch (Exception)
            {

                throw;
            }

            var sweetnessType = sweetness.GetType().ToString();
            switch (sweetnessType)
            {
                case ("GiftLibrary.Caramel"):
                    ((Caramel)sweetness).Shell = EnumHelper.ShellDict[ShellKindBox.Text];
                    ((Caramel)sweetness).Kind = EnumHelper.CaramelKindDict[CaramelKindBox.Text];
                    ((Caramel)sweetness).Taste = EnumHelper.TasteDict[TasteBox.Text];
                    ((Caramel)sweetness).Shape = EnumHelper.ShapeDict[CandyShapeBox.Text];

                    break;
                case ("GiftLibrary.Chocolate"):
                    ((Chocolate)sweetness).ChocolateKind = EnumHelper.ChocolateDict[ChocolateKindBox.Text];

                    break;

                case ("GiftLibrary.ChocolateCandy"):
                    ((ChocolateCandy)sweetness).ChocolateKind = EnumHelper.ChocolateDict[ChocolateKindBox.Text];
                    ((ChocolateCandy)sweetness).Shape = EnumHelper.ShapeDict[CandyShapeBox.Text];

                    break;

                case ("GiftLibrary.Jelly"):
                    ((Jelly)sweetness).Shell = EnumHelper.ShellDict[ShellKindBox.Text];
                    ((Jelly)sweetness).Taste = EnumHelper.TasteDict[TasteBox.Text];
                    ((Jelly)sweetness).Consistency = EnumHelper.ConsistencyDict[JellyConsistencyBox.Text];
                    ((Jelly)sweetness).Shape = EnumHelper.ShapeDict[CandyShapeBox.Text];

                    break;

                case ("GiftLibrary.Nougat"):
                    ((Nougat)sweetness).Shell = EnumHelper.ShellDict[ShellKindBox.Text];
                    ((Nougat)sweetness).Taste = EnumHelper.TasteDict[TasteBox.Text];
                    ((Nougat)sweetness).Shape = EnumHelper.ShapeDict[CandyShapeBox.Text];

                    break;
            }

            return sweetness;
        }

        //Создание числа сладостей
        public int CreateCount()
        {
            try
            {
                var count = int.Parse(SweetsCountBox.Text);
                if (count <= 0) throw new FormatException("Неверный формат");
                return count;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //лизэйбл всех элементов формы
        public void DisableAll()
        {
            SweethessKindBox.Enabled = false;

            FillingTypeBox.Enabled = false;
            FillingWeightBox.Enabled = false;
            SweetnesNameBox.Enabled = false;
            CompanyNameBox.Enabled = false;
            SweetnessWeightBox.Enabled = false;
            SweetsCountBox.Enabled = false;

            ChocolateKindBox.Enabled = false;
            ShellKindBox.Enabled = false;
            CaramelKindBox.Enabled = false;
            TasteBox.Enabled = false;
            JellyConsistencyBox.Enabled = false;
            CandyShapeBox.Enabled = false;

            CancButton.Enabled = false;
            OkButton.Enabled = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sweetness = CreateSweetness();
                var count = CreateCount();

                if (_case == Case.ДОБАВИТЬ)
                {
                    _sweets.Add(sweetness, count);
                }
                else if (_case == Case.РЕДАКТИРОВАТЬ)
                {
                    _sweets.Remove(_sweetness);
                    _sweets.Add(sweetness, count);
                }
                //Перерисовка формы подарка
                _form.PaintElements();
                this.Close();
            }
            catch (Exception)
            {

                this.Close();
            }
        }

        private void CancButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
