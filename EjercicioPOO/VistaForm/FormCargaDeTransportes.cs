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

namespace VistaForm
{
    public partial class FormCargaDeTransportes : Form
    {
        private List<TransportePublico> listadoDeTransportes;
        public FormCargaDeTransportes()
        {
            InitializeComponent();
            this.listadoDeTransportes = new List<TransportePublico>();
        }

        private void btnMostrarInforme_Click(object sender, EventArgs e)
        {
            if (this.CargarListado())
            {
                FormInforme frmInforme = new FormInforme(this.GenerarReporte());
                frmInforme.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo mostrar el reporte. Verifique la correcta carga de los campos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.BorrarListadoDeTransportes();
        }

        private bool CargarListado()
        {
            bool resultadoCargaOmnibus = true;
            bool resultadoCargaTaxi = true;

            foreach (Control control in this.grpListaDeOmnibus.Controls)
            {
                if (control is TextBox)
                {
                    int cantidadDePasajeros= int.Parse(((TextBox)control).Text);
                    if (Validaciones.ValidarCantidad(cantidadDePasajeros, Omnibus.CapacidadMaximaOmnibus))
                    {
                        Omnibus omnibus = new Omnibus(cantidadDePasajeros);
                        this.listadoDeTransportes.Add(omnibus);
                    }
                    else
                    {
                        MessageBox.Show("Verifique la correcta carga de los Omnibus ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultadoCargaOmnibus = false;
                    }
                }
            }

            foreach (Control control in this.grpListaDeTaxis.Controls)
            {
                if (control is TextBox)
                {
                    int cantidadDePasajeros = int.Parse(((TextBox)control).Text);
                    if (Validaciones.ValidarCantidad(cantidadDePasajeros, Taxi.CapacidadMaximaTaxi))
                    {
                        Taxi taxi = new Taxi(cantidadDePasajeros);
                        this.listadoDeTransportes.Add(taxi);
                    }
                    else
                    {
                        MessageBox.Show("Verifique la correcta carga de los Taxis ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resultadoCargaTaxi = false;
                    }
                }
            }

            return resultadoCargaOmnibus && resultadoCargaTaxi;
        }

        private string GenerarReporte()
        {
            int contadorOmnibus = 0;
            int contadorTaxis = 0;
            StringBuilder mensaje = new StringBuilder();

            foreach (TransportePublico transportePublico in this.listadoDeTransportes)
            {
                mensaje.AppendFormat(transportePublico.GetType().Name + " ");
                if (transportePublico.GetType() == typeof(Omnibus))
                {
                    contadorOmnibus++;
                    mensaje = mensaje.AppendFormat(contadorOmnibus.ToString() + ": ");
                }
                else
                {
                    contadorTaxis++;
                    mensaje = mensaje.AppendFormat(contadorTaxis.ToString() + ": ");
                }

                mensaje.AppendLine(transportePublico.MostrarInformacion());
            }

            return mensaje.ToString();
        }

        private void BorrarListadoDeTransportes() 
        {
            this.listadoDeTransportes.Clear();
        }

        private void txtOmnibus1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtOmnibus2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtOmnibus3_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtOmnibus4_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtOmnibus5_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtTaxi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtTaxi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtTaxi3_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtTaxi4_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void txtTaxi5_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.ValidarIngresoNumeros(e);
        }

        private void ValidarIngresoNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden ingresar números", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
