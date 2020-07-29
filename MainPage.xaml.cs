using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calci
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        string res="";
        
        public MainPage()
        {
            InitializeComponent();
        }
        
        void OnSelectNum(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string p = b.Text;
            this.input1.Text += p;
            
            res += p;
            
            
            }

            

            
            



        
        
            void OnSelectOperator(object sender,EventArgs e)
        {
            Button b = (Button)sender;
            string p = b.Text;
            ;
            switch (p)
                {

                case "+":
                    this.input1.Text += p;
                    //res += '+';
                    break;
                case "-":
                    this.input1.Text += p;
                    //res += '-';
                    break;
                case "*":
                    this.input1.Text += p;
                    //res += '*';
                    break;
                case "/":
                    this.input1.Text += p;
                     break;
                case "%":
                    this.input1.Text += p;
                    //res += '%';
                    break;
            }
            

        }
        void Ondel(object sender,EventArgs e)
        {
            if(this.input1.Text!= String.Empty)
            {
                int l;
                l = this.input1.Text.Length;
                if(l!=1)
                {
                    this.input1.Text = this.input1.Text.Remove(l - 1);
                    //res = res.Remove(l - 1);

                }
                else
                {
                    this.input1.Text = "";
                    //res = "";
                }

            }
        }

        void Onclear(object sender,EventArgs e)
        {
            
            
            this.result.Text = " ";
            this.input1.Text = " ";
            //res = " ";
            
        }
        void OnCalculate(object sender,EventArgs e)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(this.input1.Text, "");
            string a = " =";
            this.result.Text = a + v.ToString();

            
        }
    }
}
