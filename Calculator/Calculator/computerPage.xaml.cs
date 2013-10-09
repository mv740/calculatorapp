using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Calculator
{
    public partial class computerPage : PhoneApplicationPage
    {
        public computerPage()
        {
            InitializeComponent();
        }

        string buttonA1Value = "0", buttonA2Value = "0", buttonA3Value = "0", buttonA4Value = "0", buttonA5Value = "0", buttonA6Value = "0", buttonA7Value = "0", buttonA8Value = "0";
        string binaryNumber;
        Int64 decimalNumber;
        string hexNumber;
 
        /*Convert binary to decimal
         *
         */
        public void ConvertDecimal()
        {
            binaryNumber = buttonA1Value + buttonA2Value + buttonA3Value + buttonA4Value + buttonA5Value + buttonA6Value + buttonA7Value + buttonA8Value;
            decimalNumber = Convert.ToInt64(binaryNumber,2);
            binaryNumber = null;
            binaryNumber = binaryNumber+decimalNumber;
            TextBox.Text = binaryNumber;
        }

        public void ConvertHex()
        {
            binaryNumber = buttonA1Value + buttonA2Value + buttonA3Value + buttonA4Value + buttonA5Value + buttonA6Value + buttonA7Value + buttonA8Value;
            hexNumber = Convert.ToInt32(binaryNumber, 2).ToString("X");
            TextBoxHex.Text = hexNumber ;
        }

        private void Button_Click_A1(object sender, RoutedEventArgs e)
        {
            switch (ButtonA1.Content.ToString())
            {
                case "0": ButtonA1.Content = "1";
                    break;
                case "1": ButtonA1.Content = "0";
                    break;
            }
            buttonA1Value = ButtonA1.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A2(object sender, RoutedEventArgs e)
        {
            switch (ButtonA2.Content.ToString())
            {
                case "0": ButtonA2.Content = "1";
                    break;
                case "1": ButtonA2.Content = "0";
                    break;
            }
            buttonA2Value = ButtonA2.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A3(object sender, RoutedEventArgs e)
        {
            switch (ButtonA3.Content.ToString())
            {
                case "0": ButtonA3.Content = "1";
                    break;
                case "1": ButtonA3.Content = "0";
                    break;
            }
            buttonA3Value = ButtonA3.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A4(object sender, RoutedEventArgs e)
        {
            switch (ButtonA4.Content.ToString())
            {
                case "0": ButtonA4.Content = "1";
                    break;
                case "1": ButtonA4.Content = "0";
                    break;
            }
            buttonA4Value = ButtonA4.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A5(object sender, RoutedEventArgs e)
        {
            switch (ButtonA5.Content.ToString())
            {
                case "0": ButtonA5.Content = "1";
                    break;
                case "1": ButtonA5.Content = "0";
                    break;
            }
            buttonA5Value = ButtonA5.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A6(object sender, RoutedEventArgs e)
        {
            switch (ButtonA6.Content.ToString())
            {
                case "0": ButtonA6.Content = "1";
                    break;
                case "1": ButtonA6.Content = "0";
                    break;
            }
            buttonA6Value = ButtonA6.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A7(object sender, RoutedEventArgs e)
        {
            switch (ButtonA7.Content.ToString())
            {
                case "0": ButtonA7.Content = "1";
                    break;
                case "1": ButtonA7.Content = "0";
                    break;
            }
            buttonA7Value = ButtonA7.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
        private void Button_Click_A8(object sender, RoutedEventArgs e)
        {
            switch (ButtonA8.Content.ToString())
            {
                case "0": ButtonA8.Content = "1";
                    break;
                case "1": ButtonA8.Content = "0";
                    break;
            }
            buttonA8Value = ButtonA8.Content.ToString();
            ConvertHex();
            ConvertDecimal();
        }
    }
}//end namespace