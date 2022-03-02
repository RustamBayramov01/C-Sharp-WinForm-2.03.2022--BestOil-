using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenter
{

    public class MainPresenters
    {

        private readonly IMainView mainView;

        public MainPresenters(IMainView view)
        {
            mainView = view;
            mainView.Select += Select;
            mainView.Txt_ChangeText_1 += Textbox1;
            mainView.Txt_ChangeText_2 += Textbox2;
            mainView.ComboboxIndex += ComboBoxchange;


            mainView.Ode += Odee_;
            mainView.Kafe += Yanacaq_Text_;
            mainView.Yanacaq += Yanacaq_Text_;
            mainView.LoadDataSource += LoadDaraSource_;
            mainView.CheckboxChecked += CheckboxChecked_;

        }

        

        private void Select(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Name == "Radio_Celdik" && (sender as RadioButton).Checked)
            {
                mainView.Text_Litr = true;
                mainView.Text_Manat = false;
            }
            else if ((sender as RadioButton).Name == "Radio_Manat" && (sender as RadioButton).Checked)
            {
                mainView.Text_Litr = false;
                mainView.Text_Manat = true;
            }
        }



        public void ComboBoxchange(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0) { mainView.Price = ((sender as ComboBox).SelectedItem as Oil).price; }
            else if ((sender as ComboBox).SelectedIndex == 1) { mainView.Price = ((sender as ComboBox).SelectedItem as Oil).price; }
            else if ((sender as ComboBox).SelectedIndex == 2) { mainView.Price = ((sender as ComboBox).SelectedItem as Oil).price; }
            else if ((sender as ComboBox).SelectedIndex == 3) { mainView.Price = ((sender as ComboBox).SelectedItem as Oil).price; }
        }


        public void Textbox1(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "") { mainView.Oil_Total = (double.Parse((sender as TextBox).Text) * mainView.Price).ToString(); }
            else mainView.Oil_Total = "0";
        }


        private void Textbox2(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "") { mainView.Oil_Total = (double.Parse((sender as TextBox).Text) * mainView.Price).ToString(); }
            else { mainView.Oil_Total = "0"; }
        }



        private void CheckboxChecked_(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Name == "Check_Hot" && (sender as CheckBox).Checked) { mainView.Hotdo_Text = true; }
            else if ((sender as CheckBox).Name == "Check_Hamburger" && (sender as CheckBox).Checked) { mainView.Hamburger_Text = true; }
            else if ((sender as CheckBox).Name == "Check_Fri" && (sender as CheckBox).Checked) { mainView.Fri_Text = true; }
            else if ((sender as CheckBox).Name == "Check_Cola" && (sender as CheckBox).Checked) { mainView.Coca_Cola_Text = true; }

            if ((sender as CheckBox).Name == "Check_Hot" && (sender as CheckBox).Checked == false)
            {
                mainView.Hotdo_Text = false;
            }
            else if ((sender as CheckBox).Name == "Check_Hamburger" && (sender as CheckBox).Checked == false)
            {
                mainView.Hamburger_Text = false;
            }
            else if ((sender as CheckBox).Name == "Check_Fri" && (sender as CheckBox).Checked == false)
            {
                mainView.Fri_Text = false;
            }
            else if ((sender as CheckBox).Name == "Check_Cola" && (sender as CheckBox).Checked == false)
            {
                mainView.Coca_Cola_Text = false;
            }
        }



        private void Odee_(object sender, EventArgs e)
        {

            MessageBox.Show($"Success : {double.Parse(mainView.Cafe_Total) + double.Parse(mainView.Oil_Total)} $", "INFO");

            mainView.Total = 0;
            mainView.Litr = "";
            mainView.Manat = "";
            mainView.Cafe_Total = "0";
            mainView.Oil_Total = "0";
            mainView.Fri_Text = false;
            mainView.Text_Litr = false;
            mainView.Hotdo_Text = false;
            mainView.Coca_Cola_Text = false;
            mainView.Hamburger_Text = false;
            mainView.Text_Manat = false;

        }


        
        private void Yanacaq_Text_(object sender, EventArgs e) { mainView.Total = (double.Parse(mainView.Oil_Total) + double.Parse(mainView.Cafe_Total)); }


        private void LoadDaraSource_(object sender, EventArgs e)
        {
            Oil num1 = new Oil() { Name = "A-76", price = 5.00 };
            Oil num2 = new Oil() { Name = "Ai-92", price = 3.0 };
            Oil num3 = new Oil() { Name = "Ai-95", price = 1.00 };
            List<Oil> oil = new List<Oil>() { num1, num2, num3 };
            mainView.Combobox = oil;
        }
    }
}
