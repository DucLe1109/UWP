using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
{
    public enum Operation
    {
        None, Add, Substract, Multiply, Divide
    }
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class caculator : Page
    {
        private bool flag; // flag = true: da an phep tinh. flase: chua an phep tinh
        private bool flag2; // flag2 = true: da chuyen phep tinh, flase:chua chuyen phep tinh
        private bool add_firt;
        private bool sub_firt;
        private double currentNumber;
        private double finalNumber;
        private double result;
        private double result2;
        private bool secondNum;
        private Operation op;
        public caculator()
        {
            this.InitializeComponent();
            this.flag = false;
            this.currentNumber = 0;
            this.flag2 = false;
            this.result = 0;
            this.result2 = 1;
            this.secondNum = false;
            this.add_firt = true;
            this.sub_firt = true;
            this.op = Operation.None;
        }


        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "1";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "1";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;


        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "2";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "2";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;


        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "3";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "3";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;


        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "0";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "0";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }

            this.flag = false;

        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "4";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "4";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;


        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "5";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "5";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }

            this.flag = false;

        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "6";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "6";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }

            this.flag = false;

        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "7";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "7";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }

            this.flag = false;

        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "8";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "8";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbl_display.Text == "0")
            {
                this.lbl_display.Text = "";
            }
            if (flag == false)
            {
                this.lbl_display.Text += "9";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            else
            {
                this.lbl_display.Text = "9";
                this.currentNumber = Convert.ToDouble(this.lbl_display.Text);
            }
            this.flag = false;

        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if (this.add_firt == true)
            {
                this.result = this.result + this.currentNumber;
                this.lbl_display.Text = String.Format("{0}", this.result);
                this.flag = true;
                this.finalNumber = currentNumber;
                this.currentNumber = 0;
                this.secondNum = true;
                this.op = Operation.Add;
                
            }
            else
            {
                this.result = this.result + this.currentNumber;
                this.lbl_display.Text = String.Format("{0}", this.result);
                this.flag = true;
                this.secondNum = true;
                this.finalNumber = currentNumber;
                this.currentNumber = 0;
                this.op = Operation.Add;
               
            }
            this.add_firt = false;
        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {
            if (this.sub_firt == true)
            {
                this.currentNumber = 0;
                if (this.secondNum == false)
                {
                    this.result = this.currentNumber;
                }
                else
                {
                    this.result = this.result - this.currentNumber;
                }
                this.lbl_display.Text = String.Format("{0}", this.result);
                this.flag = true;
                this.finalNumber = currentNumber;
                this.currentNumber = 0;
                this.secondNum = true;
                this.op = Operation.Substract;
            }
            else
            {
                if (this.currentNumber == 1)
                {
                    this.currentNumber = 0;
                }
                if (this.secondNum == false)
                {
                    this.result = this.currentNumber;
                }
                else
                {
                    this.result = this.result - this.currentNumber;
                }
                this.lbl_display.Text = String.Format("{0}", this.result);
                this.flag = true;
                this.finalNumber = currentNumber;
                this.currentNumber = 0;
                this.secondNum = true;
                this.op = Operation.Substract;
            }
            this.sub_firt = false;
        }

        private void btn_mul_Click(object sender, RoutedEventArgs e)
        {
            
            this.currentNumber = 1;
            this.result = this.result * this.currentNumber;
            if (secondNum == true)
            {
                this.result = this.result * this.currentNumber;
            }
            this.lbl_display.Text = String.Format("{0}", this.result);
            this.flag = true;
            this.op = Operation.Multiply;
            this.secondNum = true;
        }
        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            if (this.op == Operation.Add)
            {
                this.result = this.result + currentNumber;
                this.currentNumber = 0;
            }
            else if (this.op == Operation.Substract)
            {
                this.result = this.result - this.currentNumber;
                this.currentNumber = 0;
            }
            else if (this.op == Operation.Multiply)
            {
                this.result = this.result * this.currentNumber;
                this.currentNumber = 1;
            }

            this.lbl_display.Text = String.Format("{0}", this.result);
            this.flag = true;
        }
    }
}
