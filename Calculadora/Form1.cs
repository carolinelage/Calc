using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
  public partial class Form1 : Form
  {
    int v1, v2;
    int soma;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnC_Click(object sender, EventArgs e)
    {
      lblResultado.Text = "";
      lblInicial.Visible = false;
      lblFinal.Visible = false;
      lblSinal.Visible = false;
    }

    private void btn1_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 1;
    }

    private void btn2_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 2;
    }

    private void btn3_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 3;
    }

    private void btn4_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 4;
    }

    private void btn5_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 5;
    }

    private void btn6_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 6;
    }

    private void btn7_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 7;
    }

    private void btn8_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 8;
    }

    private void btn9_Click(object sender, EventArgs e)
    {

      var res = lblResultado.Text;
      lblResultado.Text = res + 9;
    }

    private void btn0_Click(object sender, EventArgs e)
    {
      var res = lblResultado.Text;
      lblResultado.Text = res + 0;
    }

    
    private void btnCalcular_Click(object sender, EventArgs e)
    {
      if(lblSinal.Text == "+")
      {
        v2 = Convert.ToInt32(lblResultado.Text);
        lblFinal.Visible = true;
        lblFinal.Text = v2.ToString();

        soma = v1 + v2;
        lblResultado.Text = soma.ToString();
      }else if(lblSinal.Text == "-")
      {
        v2 = Convert.ToInt32(lblResultado.Text);
        lblFinal.Visible = true;
        lblFinal.Text = v2.ToString();

        soma = v1 - v2;
        lblResultado.Text = soma.ToString();
      }
      else if(lblFinal.Text == "*")
      {
        v2 = Convert.ToInt32(lblResultado.Text);
        lblFinal.Visible = true;
        lblFinal.Text = v2.ToString();

        soma = v1 * v2;
        lblResultado.Text = soma.ToString();
      }
      else if(lblFinal.Text == "/")
      {
        v2 = Convert.ToInt32(lblResultado.Text);
        lblFinal.Visible = true;
        lblFinal.Text = v2.ToString();

        soma = v1 / v2;
        lblResultado.Text = soma.ToString();
      }
    }
    private void btnSoma_Click(object sender, EventArgs e)
    {
      v1 = Convert.ToInt32(lblResultado.Text);
      lblResultado.Text = "";
      lblSinal.Visible = true;
      lblSinal.Text = "+";
      lblInicial.Visible = true;
      lblInicial.Text = v1.ToString();
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
      v1 = Convert.ToInt32(lblResultado.Text);
      lblResultado.Text = "";
      lblSinal.Visible = true;
      lblSinal.Text = "-";
      lblInicial.Visible = true;
      lblInicial.Text = v1.ToString();
    }

    private void btnMulti_Click(object sender, EventArgs e)
    {
      v1 = Convert.ToInt32(lblResultado.Text);
      lblResultado.Text = "";
      lblSinal.Visible = true;
      lblSinal.Text = "*";
      lblInicial.Visible = true;
      lblInicial.Text = v1.ToString();
    }

    private void btnDivisao_Click(object sender, EventArgs e)
    {
      v1 = Convert.ToInt32(lblResultado.Text);
      lblResultado.Text = "";
      lblSinal.Visible = true;
      lblSinal.Text = "/";
      lblInicial.Visible = true;
      lblInicial.Text = v1.ToString();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      lblResultado.Text = "";
      lblInicial.Visible = false;
      lblFinal.Visible = false; 
      lblSinal.Visible = false;
    }

  }
}
