using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicioUno_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDivisor.Text == "0")
                {
                    throw new DivideByZeroException();
                }
                else 
                {
                    this.rtbResultado.Text = Logic.Dividir(decimal.Parse(this.txtDividendo.Text), decimal.Parse(this.txtDivisor.Text)).ToString();
                }
            }
            catch (DivideByZeroException dex)
            {
                MessageBox.Show(dex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Operación finalizada");
            }
        }

        private void btnEjercicioDos_Click(object sender, EventArgs e)
        {
            try
            {
                this.rtbResultado.Text = Logic.Dividir(decimal.Parse(this.txtDividendo.Text), decimal.Parse(this.txtDivisor.Text)).ToString();
            }
            catch (DivideByZeroException dex)
            {
                MessageBox.Show($"Solo Chuck Norris divide por cero!{Environment.NewLine}" + dex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Operación finalizada");
            }
        }

        private void btnEjercicioTres_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.EmisorExcepcion();
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show($"Tipo de excepción: {aex.GetType()}{Environment.NewLine}Mensaje: {aex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tipo de excepción: {ex.GetType()}{Environment.NewLine}Mensaje: {ex.Message}");
            }
            finally
            {
                MessageBox.Show("Operación finalizada");
            }
        }

        private void btnEjercicioCuatro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtDividendo.Text) && !string.IsNullOrEmpty(this.txtDivisor.Text))
                {
                    throw new ParametroVacioException("El campo del dividendo está vacío");
                }
                else if (string.IsNullOrEmpty(this.txtDivisor.Text) && !string.IsNullOrEmpty(this.txtDividendo.Text))
                {
                    throw new ParametroVacioException("El campo del divisor está vacío");
                }
                else if (string.IsNullOrEmpty(this.txtDivisor.Text) && string.IsNullOrEmpty(this.txtDividendo.Text)) 
                {
                    throw new ParametroVacioException("Ambos campos están vacíos");
                }
                else
                {
                    this.rtbResultado.Text = Logic.Dividir(decimal.Parse(this.txtDividendo.Text), decimal.Parse(this.txtDivisor.Text)).ToString();
                }
            }
            catch (ParametroVacioException pex)
            {
                MessageBox.Show(pex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Operación finalizada");
            }
        }
    }
}
