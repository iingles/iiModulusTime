using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iiModulusTime
{
    public partial class MainPage : ContentPage
    {
        // Create constant for seconds
        const int SECONDS = 60;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Convert seconds into minutes when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvert_Clicked(object sender, EventArgs e)
        {
            // Store user input, minutes, and seconds in variables
            int userSeconds, minutes, seconds;

            // Validate user input

            if (int.TryParse(SecondsEntry.Text, out userSeconds))
            {
                // Set minutes from user input
                minutes = userSeconds / SECONDS;

                // Set seconds from user input
                seconds = userSeconds % SECONDS;

                // Show the time

                if (minutes >= 10)
                {
                    if (seconds >= 10)
                    {
                        
                        LblTime.Text = $"{minutes}:{seconds}";
                    }
                    else
                    { 
                   
                        LblTime.Text = $"{minutes}:0{seconds}";
                    }
                }
                else 
                {
                    if (seconds >= 10)
                    {
                        LblTime.Text = $"0{minutes}:{seconds}";
                    }
                    else
                    {
                        LblTime.Text = $"0{minutes}:0{seconds}";
                    }
                }
            }
            else
            {
                // If the input wasn't valid, display an alert
                DisplayAlert("Invalid Input", "Please enter an integer for the seconds", "Close");
            }
        }
    }
}
