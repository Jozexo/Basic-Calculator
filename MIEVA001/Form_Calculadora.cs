namespace MIEVA001
{
    public partial class Form_Calculadora : Form
    {
        public Form_Calculadora()
        {
            InitializeComponent();
        }

        private void Form_Calculadora_Load(object sender, EventArgs e)
        {
            txtOperador1.Enabled = false;
            txtOperador2.Enabled = false;
            txtResultado.Enabled = false;
            btnCalcular.Enabled = false;
            btnSuma.Enabled = false;
            btnResta.Enabled = false;
            btnDivision.Enabled = false;
            btnMultiplicacion.Enabled = false;
            button1.Enabled = false;
        }

        private void Form_Calculadora_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCIONE UN OPERADOR PARA COMENZAR (+, -, x, /).", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSuma.Enabled = true;
            btnResta.Enabled = true;
            btnDivision.Enabled = true;
            btnMultiplicacion.Enabled = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            labelOperador.Text = "+";

            /*btnResta.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;*/

            txtOperador1.Enabled = true;
            txtOperador2.Enabled = true;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            labelOperador.Text = "-";

            /*btnSuma.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;*/

            txtOperador1.Enabled = true;
            txtOperador2.Enabled = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            labelOperador.Text = "/";

            /*btnSuma.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnResta.Enabled = false;*/

            txtOperador1.Enabled = true;
            txtOperador2.Enabled = true;
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            labelOperador.Text = "x";

            /*btnSuma.Enabled = false;
            btnMultiplicacion.Enabled = false;
            btnDivision.Enabled = false;*/

            txtOperador1.Enabled = true;
            txtOperador2.Enabled = true;
        }

        private void txtOperador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8 && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == ',' && txtOperador1.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }
        private void txtOperador2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8 && e.KeyChar != ',')
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == ',' && txtOperador2.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtOperador1_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = txtOperador1.Text.Length > 0 && txtOperador2.Text.Length > 0;
            txtResultado.Enabled = txtOperador1.Text.Length > 0 && txtOperador2.Text.Length > 0;
        }

        private void txtOperador2_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = txtOperador1.Text.Length > 0 && txtOperador2.Text.Length > 0;
            txtResultado.Enabled = txtOperador1.Text.Length > 0 && txtOperador2.Text.Length > 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double operador1 = double.Parse(txtOperador1.Text);
            double operador2 = double.Parse(txtOperador2.Text);
            double resultado = 0;

            switch (labelOperador.Text)
            {
                case "+":
                    resultado = operador1 + operador2;
                    break;
                case "-":
                    resultado = operador1 - operador2;
                    break;
                case "x":
                    resultado = operador1 * operador2;
                    break;
                case "/":
                    if (operador2 != 0)
                    {
                        resultado = operador1 / operador2;
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUEDE DIVIDIR ENTRE CER/0");
                        return;
                    }
                    break;
            }

            txtResultado.Text = resultado.ToString();
        }
    }
}
