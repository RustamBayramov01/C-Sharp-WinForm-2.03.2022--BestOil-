using System;
using System.Collections.Generic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public interface IMainView
    {

        EventHandler<EventArgs> ComboboxIndex { get; set; }
        EventHandler<EventArgs> CheckboxChecked { get; set; }
        EventHandler<EventArgs> Txt_ChangeText_1 { get; set; }
        EventHandler<EventArgs> Txt_ChangeText_2 { get; set; }
        EventHandler<EventArgs> Select { get; set; }
        EventHandler<EventArgs> Label_TextChange { get; set; }
        EventHandler<EventArgs> LoadDataSource { get; set; }
        EventHandler<EventArgs> Yanacaq { get; set; }
        EventHandler<EventArgs> Kafe { get; set; }
        EventHandler<EventArgs> Ode { get; set; }
        List<Oil> Combobox { set; }


        string Name { get; set; }
        double Price { get; set; }
        bool Hotdo_Text { set; }
        bool Hamburger_Text { set; }
        bool Fri_Text { set; }
        bool Coca_Cola_Text { set; }


        string Oil_Total { get; set; }
        string Cafe_Total { get; set; }
        double Total { get; set; }


        bool Text_Litr { set; }
        bool Text_Manat { set; }


        double Hotdog_Select { get; set; }
        double Hamburger_Select { get; set; }
        double Fri_Select { get; set; }
        double Coca_Cola_Select { get; set; }


        string Litr { set; }
        string Manat { set; }

        

    }
}
