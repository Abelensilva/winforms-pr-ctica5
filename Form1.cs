using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónWindow2
{
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        // AGREGAR UN COMENTARIO
        private void txtBoxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57) 
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBoxApellido.Text == "")

                txtBoxApellido.BackColor = Color.Red;

            else
            {
                txtBoxApellido.BackColor = System.Drawing.SystemColors.Control;
                txtResultado.Text = txtBoxApellido.Text;
            }

            if (txtBoxNombre.Text == "")
                txtBoxNombre.BackColor = Color.Red;
            else
            {
                txtBoxNombre.BackColor = System.Drawing.SystemColors.Control;
                txtResultado.Text = txtBoxNombre.Text;
            }

            if (txtBoxEdad.Text == "")
                txtBoxEdad.BackColor = Color.Red;
            else
            {
                txtBoxEdad.BackColor = System.Drawing.SystemColors.Control;
                txtResultado.Text = txtBoxEdad.Text;
            }

            if (txtBoxDireccion.Text == "")
                txtBoxDireccion.BackColor = Color.Red;
            else
            {
                txtBoxDireccion.BackColor = System.Drawing.SystemColors.Control;
                txtResultado.Text = txtBoxDireccion.Text;
            }

            Persona p1 = new Persona();

            p1.Nombre = txtBoxApellido.Text;

            p1.Apellido = txtBoxNombre.Text;

            p1.Edad = txtBoxEdad.Text;

            p1.Direccion = txtBoxNombre.Text;

            txtResultado.Text = "Apellido y nombre: " + txtBoxApellido.Text + txtBoxNombre.Text + Environment.NewLine +
                "Edad: " + txtBoxEdad.Text + Environment.NewLine + "Dirección: " + txtBoxDireccion.Text;

            
            

        }

          




        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
