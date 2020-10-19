using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test.Class;
using Test.Model;

namespace Test
{
    public partial class wf_cliente : System.Web.UI.Page
    {
        private bd_cliente bd_cliente;
        private cls_Cliente cls_cliente;
        private Boolean retorna = false;

        public void nuevo()
        {
            lblMensaje.Visible = false;
            lblError.Visible = false;

            try
            {
                bd_cliente = new bd_cliente();

                txtId.Text = bd_cliente.obtenerId().ToString();
                txtCedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                cmbGenero.SelectedIndex = 0;
                cmbEstado.SelectedIndex = 0;
                txtEdad.Text = "";
            }
            catch (Exception ex)
            {
                lblError.Text = "Error en nuevo. Error: " + ex.Message;
                lblError.Visible = true;
            }
        }
        public Boolean ingresarInformacion()
        {
            try
            {
                cls_cliente = new cls_Cliente();
                cls_cliente.ID = int.Parse(txtId.Text);
                cls_cliente.CEDULA = txtCedula.Text;
                cls_cliente.NOMBRES = txtNombre.Text;
                cls_cliente.APELLIDOS = txtApellido.Text;
                cls_cliente.GENERO = (cmbGenero.SelectedIndex == 0) ? 'H' : 'M';
                cls_cliente.ESTADO = (cmbEstado.SelectedIndex == 0) ? 'A' : 'I';
                cls_cliente.EDAD = int.Parse(txtEdad.Text);

                bd_cliente = new bd_cliente();
                retorna = bd_cliente.distribuye(cls_cliente);

                if (retorna)
                {
                    lblMensaje.Text = "Se registró con exito la información.";
                    lblMensaje.Visible = true;
                }
                else
                {
                    lblError.Text = "No se Registró la información.";
                    lblError.Visible = true;
                }

            }
            catch (Exception ex)
            {
                lblError.Text = "Error al ingresar información. Error:" + ex.Message;
                lblError.Visible = true;
            }

            return retorna;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    nuevo();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Error en nuevo. Error: " + ex.Message;
                lblError.Visible = true;
            }
        }
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }
        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            ingresarInformacion();
        }
    }
}