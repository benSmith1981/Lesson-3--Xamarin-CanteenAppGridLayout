using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CanteenAppGridLayout
{
    public partial class MainPage : ContentPage
    {
        int totalPrice = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        public void AddToKart(object sender, EventArgs args)
        {
            var button = (Button)sender;
            var classId = button.ClassId;
            if(classId == "Fries")
            {
                totalPrice += 1;
                total.Text = "£"+totalPrice;
            }
        }
    }
}
