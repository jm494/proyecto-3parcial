using Punto_de_ventas.ModelsClass;
using Punto_de_ventas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_ventas
{
    public partial class Form1 : Form
    {
        
        Almacenes a = new Almacenes();
        private string accion = "insert", paginas = "12";
        public Form1()
        {
            InitializeComponent();
            new Connection.Conexion();
            /****************************
             *     Código del cliente   *
             ***************************/
            
        }
        #region

        private void CheckBox_Credito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button_Ventas_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Ventas");
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreU_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Nombre.Text == "")
            {

            }
            else
            {

            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (radioButton_IA.Checked)
            {
                guardarAlmacen();
            }
        }
        private void guardarAlmacen()
        {
            if (textBoxID.Text == "")
            {
                labelID.Text = "Ingrese el ID";
                textBoxID.Focus();
            }
            else
            {
                if (textBoxNombre.Text == "")
                {
                    labelNombre.Text = "Ingrese el Nombre";
                    textBoxNombre.Focus();
                }
                else
                {
                    if (textBoxDireccion.Text == "")
                    {
                        labelDireccion.Text = "Ingrese la Direccion";
                        textBoxDireccion.Focus();
                    }
                    else
                    {
                        if (textBox_Colonia.Text == "")
                        {
                            labelColonia.Text = "Ingrese la colonia";
                            textBox_Colonia.Focus();
                        }
                        else
                        {
                            if (textBox_CLVEstado.Text == "")
                            {
                                labelCLVEstado.Text = "Ingrese su CLV Estado";
                                textBox_CLVEstado.Focus();
                            }
                            else
                            {
                                string ID = textBox_Id.Text;
                                string Nombre = textBox_Nombre.Text;
                                string Direccion = textBox_Direccion.Text;
                                string Colonia = textBox_Colonia.Text;
                                string Clve = textBox_CLVEstado.Text;
                                if (accion == "insert")
                                {
                                    a.insertAlmacen(ID,Nombre, Direccion, Colonia, Clve);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clientes_Click(object sender, EventArgs e)
        {
            paginas = "1";
            accion = "insert";
            
            button_Clientes.Enabled = false;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_detproveedor.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button_Almacen_Click(object sender, EventArgs e)
        {
            paginas = "11";
            accion = "insert";
            tabControl1.SelectedIndex = 11;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = false;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_detproveedor.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void RadioButton_IA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label66_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
