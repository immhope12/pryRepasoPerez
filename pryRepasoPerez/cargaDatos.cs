using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryRepasoPerez
{
    public partial class cargaDatos : Form
    {
        string dato;

        public cargaDatos()
        {
            InitializeComponent();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCajaCodigo.Text))
            {
                MessageBox.Show("El código no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dato = txtCajaCodigo.Text;
            MessageBox.Show("Registraste: " + dato);
            

        }

        private void txtCajaCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
