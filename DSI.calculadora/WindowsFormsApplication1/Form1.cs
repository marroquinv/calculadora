using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        double a;
        double b;
        string operacion;
        double resultado;
        string borrar;
        bool detectar = true;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "1";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {


            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "2";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "2";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "3";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "4";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "5";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "6";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "7";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "8";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (detectar == true)
            {
                pantalla.Text = "";
                pantalla.Text = "9";
                detectar = false;
            }
            else
            {
                pantalla.Text = pantalla.Text + "9";
            }
        }

        private void butnn0_Click(object sender, EventArgs e)
        {
           if(pantalla.Text == "0")
            {
                return;
        
            }
            else
            {
                pantalla.Text = pantalla.Text + "0";
            }

        }

       

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }


       
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            n2.Clear();
        }

        private void btnmas_Click(object sender, EventArgs e)
        {
           
            operacion = "+";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();



        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            
            operacion = "-";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();


        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            
            operacion = "/";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();




        }

        private void btnmultip_Click(object sender, EventArgs e)
        {
            

            operacion = "*";
            a = double.Parse(pantalla.Text);
            pantalla.Clear();


        }

        private void igual_Click(object sender, EventArgs e)
        {
            b = double.Parse(pantalla.Text);

          switch(operacion)
            {
                case "+":
                    
                    resultado = a + b;
                    n2.Text = resultado.ToString();
                    break;

                case "-":

                    resultado = a - b;
                    n2.Text = resultado.ToString();
                    break;

                case "/":

                    resultado = a / b;
                    n2.Text = resultado.ToString();
                    break;

                case "*":

                    resultado = a * b;
                    n2.Text = resultado.ToString();
                    break;

            }

        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            operacion = "raiz";
            a = double.Parse(pantalla.Text);
            resultado = a;
            n2.Text = Math.Sqrt(a).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrar = pantalla.Text;
            x = borrar.Length - 1;
            borrar = borrar.Substring(0,x);
            pantalla.Text = borrar;
            
           if(pantalla.Text =="")
            {
                pantalla.Text = "0";
                detectar = true;

            }
            if (pantalla.Text == "-")
            {
               pantalla.Text = "0";
               detectar = true;

            }
        }

        }
    }

