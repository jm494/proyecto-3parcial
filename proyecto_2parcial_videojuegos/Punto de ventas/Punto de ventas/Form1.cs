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
        DetalleVentas dv = new DetalleVentas();
        Usuarios u = new Usuarios();
        Consolas con = new Consolas();
        Proveedores p = new Proveedores();
        Categorias cat = new Categorias();
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
            paginas = "0";
            accion = "insert";
            tabControl1.SelectedIndex = 0;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = false;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
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
            if (textBox_NombreCli.Text == "")
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
                                string ID = textBoxID.Text;
                                string Nombre = textBoxNombre.Text;
                                string Direccion = textBoxDireccion.Text;
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
            paginas = "2";
            accion = "insert";
            tabControl1.SelectedIndex = 1;
            button_Clientes.Enabled = false;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button_Almacen_Click(object sender, EventArgs e)
        {
            paginas = "11";
            accion = "insert";
            tabControl1.SelectedIndex = 10;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = false;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void RadioButton_IA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Colonia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_dv_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radioButton_IA.Checked)
            {
                guardarDetalleVenta();
            }*/
        }

        /*private void guardarDetalleVenta()
        {
            if (textBox_IVDV.Text == "")
            {
                label_IVDV.Text = "Ingrese el ID de la venta";
                textBox_IViDV.Focus();
            }
            else
            {
                if (textBox_IViDV.Text == "")
                {
                    label_IViDV.Text = "Ingrese el ID del Videojuego";
                    textBox_IViDV.Focus();
                }
                else
                {
                    if (textBox_IADV.Text == "")
                    {
                        label_IADV.Text = "Ingrese el ID del detalle de venta";
                        textBox_IADV.Focus();
                    }
                    else
                        if (textBox_cantidaddv.Text == "")
                    {
                        label_cantidaddv.Text = "Ingrese cantidad";
                        textBox_CLVEstado.Focus();
                    }
                    else
                    {
                        int Venta_id = textBox_IVDV.Text;
                        string Videjuego_id = textBox_IViDV.Text;
                        string  Almacen_id= textBox_IADV.Text;
                        string Cantidad = textBox_cantidaddv.Text;
                        if (accion == "insert")
                        {
                            dv.insertarDetalleVenta(Venta_id, Videjuego_id, Almacen_id, Cantidad);
                        }
                    }
                }
            }
        }*/

        private void Button_Usuario_Click(object sender, EventArgs e)
        {
            paginas = "12";
            accion = "insert";
            tabControl1.SelectedIndex = 11;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = false;
        }

        private void Button_GU_Click(object sender, EventArgs e)
        {
            if (radioButton_IU.Checked)
            {
                guardarUsuario();
            }
        }

        private void guardarUsuario()
        {
            if (textBox_NombreU.Text == "")
            {
                label_NombreU.Text = "Ingrese el nombre";
                textBox_NombreU.Focus();
            }
            else
            {
                if (textBox_ApellidoU.Text == "")
                {
                    label_ApellidoU.Text = "Ingrese el apellido";
                    textBox_ApellidoU.Focus();
                }
                else
                {
                    if (textBox_PasswordU.Text == "")
                    {
                        label_PasswordU.Text = "Ingrese el password";
                        textBox_PasswordU.Focus();
                    }
                    else
                    {
                        if (accion == "insert")
                        {
                            string Nombre = textBox_NombreU.Text;
                            string Apellido = textBox_ApellidoU.Text;
                            string Password = textBox_PasswordU.Text;
                            u.insertUsuario(Nombre, Apellido, Password);
                        }
                    }
                }
            }
        }

        private void Button_GCon_Click(object sender, EventArgs e)
        {
            if (radioButton_ICon.Checked)
            {
                guardarConsola();
            }
        }

        private void guardarConsola()
        {
            if (textBox_ConsolaC.Text == "")
            {
                label_ConsolaC.Text = "Ingrese el nombre de consola";
                textBox_ConsolaC.Focus();
            }
            else
            {
                if (accion == "insert")
                {
                    string Nombre = textBox_ConsolaC.Text;
                    con.insertConsola(Nombre);
                }
            }
        }

        private void Button_consola_Click(object sender, EventArgs e)
        {
            paginas = "7";
            accion = "insert";
            tabControl1.SelectedIndex = 6;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = false;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button_proveedor_Click(object sender, EventArgs e)
        {
            paginas = "9";
            accion = "insert";
            tabControl1.SelectedIndex = 8;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = false;
            button_Usuario.Enabled = true;
        }

        private void Button_GP_Click(object sender, EventArgs e)
        {
            if (radioButton_INP.Checked)
            {
                guardarProveedor();
            }
        }

        private void guardarProveedor()
        {
            if (textBox_IP.Text == "")
            {
                label_IP.Text = "Ingrese la nueva ID";
                textBox_IP.Focus();
            }
            else
            {
                if (textBox_rsP.Text == "")
                {
                    label_rsP.Text = "Ingrese la razon social";
                    textBox_rsP.Focus();
                }
                else
                {
                    if (textBox_rfcP.Text == "")
                    {
                        label_rfcP.Text = "Ingrese el RFC";
                        textBox_rfcP.Focus();
                    }
                    else
                    {
                        if (accion == "insert")
                        {
                            string ID = textBox_IP.Text;
                            string RS = textBox_rsP.Text;
                            string RFCP = textBox_rfcP.Text;
                            p.insertProveedor(ID, RS, RFCP);
                        }
                    }
                }
            }
        }

        private void Button_categorias_Click(object sender, EventArgs e)
        {
            paginas = "4";
            accion = "insert";
            tabControl1.SelectedIndex = 3;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = false;
            button_consola.Enabled = true;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button_GCat_Click(object sender, EventArgs e)
        {
            if (radioButton_CNC.Checked)
            {
                guardarCategoria();
            }
        }
        private void guardarCategoria()
        {
            if (textBox_Cat.Text == "")
            {
                label_Cat.Text = "Ingrese el nombre de la categoria";
                textBox_Cat.Focus();
            }
            else
            {
                if (textBox_ClCa.Text == "")
                {
                    label_ClCa.Text = "Ingrese la clave de la consola";
                    textBox_ClCa.Focus();
                }
                else
                {
                    if (accion == "insert")
                    {
                        string Categoria = textBox_Cat.Text;
                        string Clave = textBox_ClCa.Text;
                        cat.insertCategoria(Categoria, Clave);
                    }
                }
            }
        }

        private void Button_GCli_Click(object sender, EventArgs e)
        {
            if (radioButton_IngresarCliente.Checked)
            {
                guardarCliente();
            }
        }

        private void guardarCliente()
        {
            if (textBox_ICli.Text == "")
            {
                label_ICli.Text = "Ingrese el ID del nuevo cliente";
                textBox_ICli.Focus();
            }
            else
            {
                if (textBox_NombreCli.Text == "")
                {
                    label_NombreCli.Text = "Ingrese el nombre del cliente";
                    textBox_NombreCli.Focus();
                }
                else
                {
                    if (textBox_ApeCli.Text == "")
                    {
                        label_ApeCli.Text = "Ingrese el apellido";
                        textBox_ApeCli.Focus();
                    }
                    else
                    {
                        if (textBox_DirCli.Text == "")
                        {
                            label_DirCli.Text = "Ingrese la direccion";
                            textBox_DirCli.Focus();
                        }
                        else
                        {
                            if (textBox_TelCli.Text == "")
                            {
                                label_TelCli.Text = "Ingrese el telefono";
                                textBox_TelCli.Focus();
                            }
                            else
                            {
                                if (accion == "insert")
                                {
                                    string ID = textBox_ICli.Text;
                                    string Nombre = textBox_NombreCli.Text;
                                    string Apellido = textBox_ApeCli.Text;
                                    string Direccion = textBox_DirCli.Text;
                                    string Telefono = textBox_TelCli.Text;
                                    con.insertConsola(Nombre);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Button_consola_Click_1(object sender, EventArgs e)
        {
            paginas = "7";
            accion = "insert";
            tabControl1.SelectedIndex = 6;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = false;
            button_det_ven.Enabled = true;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button_detproveedor_Click(object sender, EventArgs e)
        {
            paginas = "10";
            accion = "insert";
            tabControl1.SelectedIndex = 9;
            button_Clientes.Enabled = true;
            button_Ventas.Enabled = true;
            button_videojuegos.Enabled = true;
            button_Almacen.Enabled = true;
            button_categorias.Enabled = true;
            button_consola.Enabled = true;
            button_det_ven.Enabled = false;
            button_inventario.Enabled = true;
            button_proveedor.Enabled = true;
            button_Usuario.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label66_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
