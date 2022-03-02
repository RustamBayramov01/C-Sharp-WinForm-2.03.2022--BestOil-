using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class BestOil : Form, IMainView
    {
        public BestOil()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> ComboboxIndex { get; set; }
        public EventHandler<EventArgs> CheckboxChecked { get; set; }
        public EventHandler<EventArgs> LoadDataSource { get; set; }
        public EventHandler<EventArgs> Txt_ChangeText_1 { get; set; }
        public EventHandler<EventArgs> Txt_ChangeText_2 { get; set; }
        public EventHandler<EventArgs> Select { get; set; }

        public EventHandler<EventArgs> Label_TextChange { get; set; }
       
        public List<Oil> Combobox { set => comboBox1.DataSource = value; }
        public EventHandler<EventArgs> Yanacaq { get; set; }
        public EventHandler<EventArgs> Kafe { get; set;  }
        public EventHandler<EventArgs> Ode { get; set; }


        public double Price { get => double.Parse(Txt_Deyer.Text); set => Txt_Deyer.Text = value.ToString(); }
        public string Oil_Total { get => Label_OdenisEvvel.Text; set => Label_OdenisEvvel.Text = value; }
        public string Cafe_Total { get => Label_Qiymet_Evvel.Text; set => Label_Qiymet_Evvel.Text = value; }
        public double Total { get => double.Parse(Label_Total.Text); set => Label_Total.Text = value.ToString(); }
        public bool Text_Litr { set => Txt_Litr.Enabled = value; }
        public bool Text_Manat { set => Txt_Manat.Enabled = value; }


        public bool Hotdo_Text { set {

                Check_Hot.Checked = value;
                Txt_Qiymet_Daxil_1.Enabled = value;

            } }

        public bool Hamburger_Text { set {

                Check_Hamburger.Checked = value;
                Txt_Qiymet_Daxil_2.Enabled = value;
            
            } }

        public bool Fri_Text { set {

                Check_Fri.Checked = value;
                Txt_Qiymet_Daxil_3.Enabled = value;

            } }

        public bool Coca_Cola_Text { set {

                Check_Cola.Checked = value;
                Txt_Qiymet_Daxil_4.Enabled = value;
            
            } }

        public double Hotdog_Select {

            get
            {
                if (Txt_Qiymet_Daxil_1.Text != "") return double.Parse(Txt_Qiymet_Daxil_1.Text);
                else return 0;
            }
            set => Txt_Qiymet_Daxil_1.Text = value.ToString();


        }
        public double Hamburger_Select
        {
            get
            {

                if (Txt_Qiymet_Daxil_2.Text != "") return double.Parse(Txt_Qiymet_Daxil_2.Text);
                else return 0;

            }
            set => Txt_Qiymet_Daxil_2.Text = value.ToString();

        }
        public double Fri_Select {

            get
            {

                if (Txt_Qiymet_Daxil_3.Text != "") return double.Parse(Txt_Qiymet_Daxil_3.Text);
                else return 0;

            }
            set => Txt_Qiymet_Daxil_3.Text = value.ToString();

        }
        public double Coca_Cola_Select {

            get
            {

                if (Txt_Qiymet_Daxil_4.Text != "") return double.Parse(Txt_Qiymet_Daxil_4.Text);
                else return 0;

            }
            set => Txt_Qiymet_Daxil_4.Text = value.ToString();

        }

        public string Litr { set => Txt_Litr.Text = value; }
        public string Manat { set => Txt_Manat.Text = value; }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxIndex.Invoke(sender, e);
        }

        private void Radio_Celdik_CheckedChanged(object sender, EventArgs e)
        {
            Select.Invoke(sender, e);
            Txt_Manat.Text = null;
        }

        private void Radio_Manat_CheckedChanged(object sender, EventArgs e)
        {
            Select.Invoke(sender, e);
            Txt_Litr.Text = null;
        }

        private void Txt_Litr_TextChanged(object sender, EventArgs e)
        {
            Txt_ChangeText_1.Invoke(sender, e);
        }

        private void Txt_Manat_TextChanged(object sender, EventArgs e)
        {
            Txt_ChangeText_2.Invoke(sender, e);
        }

        private void Check_Hot_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxChecked.Invoke(sender, e);
        }

        

        private void lbl_yanmeb_TextChanged(object sender, EventArgs e)
        {
            Yanacaq.Invoke(sender, e);
            Kafe.Invoke(sender, e);
        }

        private void Button_TotalQiymet_Ode_Click(object sender, EventArgs e)
        {

            if (Label_OdenisEvvel.Text != "0" || Label_Qiymet_Evvel.Text != "0") { Ode.Invoke(sender, e); }
            
        }

        private void BestOil_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Txt_Qiymet_Daxil_1.Enabled = false;
            Txt_Qiymet_Daxil_2.Enabled = false;
            Txt_Qiymet_Daxil_3.Enabled = false;
            Txt_Qiymet_Daxil_4.Enabled = false;
            Radio_Celdik.Checked = true;
            LoadDataSource.Invoke(sender, e);
        }

        private void Txt_Qiymet_Daxil_1_TextChanged_1(object sender, EventArgs e)
        {
            int result = int.Parse(Label_Qiymet_Evvel.Text);

            if(result == 0) Label_Qiymet_Evvel.Text = (int.Parse(Txt_Qiymet_Daxil_1.Text) * 4).ToString();
            else Label_Qiymet_Evvel.Text = ((int.Parse(Txt_Qiymet_Daxil_1.Text) * 4) + result).ToString();

        }

        private void Txt_Qiymet_Daxil_2_TextChanged(object sender, EventArgs e)
        {
            int result = int.Parse(Label_Qiymet_Evvel.Text);

            if (result == 0) Label_Qiymet_Evvel.Text = (int.Parse(Txt_Qiymet_Daxil_2.Text) * 5).ToString();
            else Label_Qiymet_Evvel.Text = ((int.Parse(Txt_Qiymet_Daxil_2.Text) * 5) + result).ToString();

        }


        private void Txt_Qiymet_Daxil_3_TextChanged_1(object sender, EventArgs e)
        {
            int result = int.Parse(Label_Qiymet_Evvel.Text);

            if (result == 0) Label_Qiymet_Evvel.Text = (int.Parse(Txt_Qiymet_Daxil_3.Text) * 7).ToString();
            else Label_Qiymet_Evvel.Text = ((int.Parse(Txt_Qiymet_Daxil_3.Text) * 7) + result).ToString();
        }

        private void Txt_Qiymet_Daxil_4_TextChanged(object sender, EventArgs e)
        {
            int result = int.Parse(Label_Qiymet_Evvel.Text);

            if (result == 0) Label_Qiymet_Evvel.Text = (int.Parse(Txt_Qiymet_Daxil_4.Text) * 4).ToString();
            else Label_Qiymet_Evvel.Text = ((int.Parse(Txt_Qiymet_Daxil_4.Text) * 4) + result).ToString();
        }
    }
}
