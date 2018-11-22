using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            B1.Clicked += B1ClickedEvent;
        }

        private void B1ClickedEvent(object sender, EventArgs e)
        {
            float height = float.Parse(S1.Text);
            float weight = float.Parse(T1.Text);
            if (height <=40)
                K1.Text = "" + (weight / (height * height));
            else
            {
                K1.Text = "" + (weight /( (height/100) * (height/100)));
            }
        }

        private void A1ClickedEvent(object sender, EventArgs e)
        {

            float height = float.Parse(S1.Text);
            float weight = float.Parse(T1.Text);
            if (height <= 40)
            {
                float K1 = (weight / (height * height));
                Navigation.PushAsync(new Page1(K1));
            }
            else
            {
                float K1 = (weight / ((height / 100) * (height / 100)));
                Navigation.PushAsync(new Page1(K1));
            }
        }
    } 
}
