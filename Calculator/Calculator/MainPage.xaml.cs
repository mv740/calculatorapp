using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Calculator.Resources;

namespace Calculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            TextBox.Text = "0";
           


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        string operation;
        double? num1, num2, result;

        /*
        //phone orientation
        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if (e.Orientation == PageOrientation.PortraitDown || e.Orientation == PageOrientation.PortraitUp)
            {
                
            }
            else
            {
               
            }
        }
        */




        //Button "0"
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "0";
        }
        //Button "1"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "1";
        }
        //Button "2"
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "2";
        }
        //Button "3"
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "3";
        }
        //Button "4"
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "4";
        }
        //Button "5"
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "5";
        }
        //Button "6"
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "6";
        }
        //Button "7"
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "7";
        }
        //Button "8"
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "8";
        }
        //Button "9"
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text + "9";
        }

        //operation
        private void Clear()
        {
            TextBox.Text = "0";
            //TextBox.Text = string.Empty;
        }

        //Button "*"
        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                operation = "*";
                Clear();
            }
        }
        //Button "/"
        private void Button_Click_Divide(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                operation = "/";
                Clear();
            }
        }
        //Button "-"
        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                operation = "-";
                Clear();
            }
        }
        //Button "+"
        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                operation = "+";
                Clear();
            }
        }
        //Button "."
        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            char[] textBoxCharacter = TextBox.Text.ToCharArray();
            bool TextBoxHasDot = false;
            //check if there is already a "." inside TextBox
            // if yes : button add a "." , if no, then it dones't do anything. 
            for (int i = 0; i < textBoxCharacter.Length; i++)
            {
                if (char.IsPunctuation(textBoxCharacter[i]))
                {
                    TextBoxHasDot = true;
                }
            }
            if (!TextBoxHasDot)
            {
                TextBox.Text = TextBox.Text + ".";
            }
               
          
        }
        //Button "="
        private void Button_Click_Equal(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num2 = double.Parse(TextBox.Text);
                switch (operation)
                {
                    case "+": result = num1 + num2;
                        break;
                    case "-": result = num1 - num2;
                        break;
                    case "/": result = num1 / num2;
                        break;
                    case "*": result = num1 * num2;
                        break;
                }
                Clear();
                TextBox.Text = TextBox.Text + result;
            }
        }
        //Button "C"
        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
           Clear();
           num1 = null;
           num2 = null;
        }
        //Button "DEL"
        private void Button_Click_Del(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
            else
            {
                TextBox.Text = TextBox.Text;
            }
        }
        //Button "+-"
        private void Button_Click_PlusMinus(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                double number = double.Parse(TextBox.Text);
                number = -1 * number;
                Clear();
                TextBox.Text = TextBox.Text + number;
            }
        }
        //Button "%"
        private void Button_Click_Percentage(object sender, RoutedEventArgs e)
        {

        }
        

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}