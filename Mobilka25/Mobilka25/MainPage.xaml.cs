using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobilka25
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pralkaBtn_Clicked(object sender, EventArgs e)
        {
            int value = Int32.Parse(pralkaEntry.Text);
            if (value >= 1 && value <= 12)
            {
                pralkaLbl.Text = $"Numer prania: {value.ToString()}";
            }
        }

        private void odkurzaczBtn_Clicked(object sender, EventArgs e)
        {
            if (odkurzaczBtn.Text == "Włącz")
            {
                odkurzaczBtn.Text = "Wyłącz";
                stanLbl.Text = "Odkurzacz włączony";
            }
            else if (odkurzaczBtn.Text == "Wyłącz")
            {
                odkurzaczBtn.Text = "Włącz";
                stanLbl.Text = "Odkurzacz wyłączony";
            }
        }
    }
}
