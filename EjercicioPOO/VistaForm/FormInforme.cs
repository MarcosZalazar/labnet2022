using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FormInforme : Form
    {
        public FormInforme(string informacion)
        {
            InitializeComponent();
            this.rtbInformeDePasajeros.Text = informacion;
        }
    }
}
