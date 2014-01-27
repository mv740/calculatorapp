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
    public partial class normalPage : PhoneApplicationPage
    {
        // Constructor
        public normalPage()
        {
            InitializeComponent();
           // TextBox.Text = "0";
            


            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        


        string operation;
        double? num1, num2, result;
        List<string> userInput = new List<string>();

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

        //PRINT ON screen your equation while you add stuff
        private void showExpression()
        {
            string expression = string.Join("",userInput.ToArray());
            TextBoxExpression.Text = expression;
        }
        private void calculateExpression()
        {
            
        }

        //number button 0-9
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox.Text +="5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox.Text +="7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox.Text  += "8";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        //operation
        private void Clear()
        {
             TextBox.Text = string.Empty;
        }

        //Button "*"
        private void Button_Click_Multiply(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                num1 = double.Parse(TextBox.Text);
                operation = "*";
                string var = ""+ num1;
                userInput.Add(var); //add num1 in list
                userInput.Add(operation); // add * in list
                showExpression();
                calculateExpression();
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
                string var = "" + num1;
                userInput.Add(var);
                userInput.Add(operation);
                showExpression();
                calculateExpression();             
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
                string var = "" + num1;
                userInput.Add(var);
                userInput.Add(operation);
                showExpression();
                calculateExpression();
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
                string var = "" + num1;
                userInput.Add(var);
                userInput.Add(operation);
                showExpression();
                calculateExpression();
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

                /*num1 = double.Parse(TextBox.Text);
                string var = "" + num1;
                userInput.Add(var);
                showExpression();
                */
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
            userInput.Clear(); //delete everything from list
            TextBoxExpression.Text = string.Empty;
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