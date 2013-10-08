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

        string button00Value ="0", button01Value ="0";
        string binaryNumber;
        int decimalNumber;
 

        public void ConvertDecimal()
        {
            binaryNumber = button00Value + button01Value;
            decimalNumber = int.Parse(binaryNumber);
                //Int64.Parse(binaryNumber);
            //decimalNumber = Convert.ToInt64((binaryNumber);
            TextBox.Text = binaryNumber;
        }


        private void Button_Click_00(object sender, RoutedEventArgs e)
        {
            switch(Button00.Content.ToString())
            {
                case "0": Button00.Content = "1";
                    break;
                case "1": Button00.Content = "0";
                    break;
            }
            button00Value = Button00.Content.ToString();
            ConvertDecimal();
        }

        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            switch (Button01.Content.ToString())
            {
                case "0": Button01.Content = "1";
                    break;
                case "1": Button01.Content = "0";
                    break;
            }
            button01Value = Button01.Content.ToString();
            ConvertDecimal();
        }
    }
}//end namespace