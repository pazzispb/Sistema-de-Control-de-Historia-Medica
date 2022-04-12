﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Control_de_Historia_Medica
{
    public partial class frmAnaliticas : Form
    {
        string vIDUsuario = frmMenuPrincipal.vIdUsuario; //Id del usuario con la sesion abierta
        clsBaseDatos bd = new clsBaseDatos();
        bool vBorrar = false;
        public frmAnaliticas()
        {
            InitializeComponent();
        }
        private void frmAnaliticas_Load(object sender, EventArgs e)
        {
            CargarAnaliticas();
            pdfVisualizador.src = "";
        }
        private void btnRegistrarAnalitica_Click(object sender, EventArgs e)
        {
            if (!EstaAbierto()) //Valida si hay formularios abiertos aparte del Menu Principal y el de Analiticas
            {
                frmRegistrarAnalitica frm = new frmRegistrarAnalitica();
                frm.MdiParent = this.MdiParent; //Para mantenerlos dentro del Area del Menu Principal
                frm.frmAnaliticas = this; //Le pasamos este formulario para poder actualizar el datagrid view con los Padecimientos
                frm.StartPosition = FormStartPosition.CenterScreen;//Para que el formulario se centre en el area del menu principal
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ya tiene la funcionalidad abierta", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        static public bool EstaAbierto() //Valida si hay formularios abiertos aparte del Menu Principal y el de Analiticas
        {
            if (Application.OpenForms.Count > 3) return true; 
            else return false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarAnaliticas();
        }
        public void CargarAnaliticas()
        {
            DataSet ds = bd.ConsultarInfomacion("SELECT idAnalitica as 'ID', fecha as 'Fecha', proposito as 'Propósito', observaciones as 'Observaciones'" +
                $"FROM Analiticas WHERE idUsuario = {vIDUsuario}");//Carga los registros correspondientes a las analiticas de los usuarios
            dgvAnaliticas.DataSource = ds.Tables[0];//Carga la tabla con los resultados de la consulta
        }
        private void dgvAnaliticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Si la fila seleccionada no es un header del datagridview
            {
                lblID.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[0].Value.ToString();
                dtpFecha.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPropositoAnalitica.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtObservaciones.Text = dgvAnaliticas.Rows[e.RowIndex].Cells[2].Value.ToString();
                string direccion = Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf('\\'));//Obtener la direccion del programa en ejecucion
                direccion = direccion.Substring(0, direccion.LastIndexOf('\\'));
                direccion = direccion.Substring(0, direccion.LastIndexOf('\\'));
                MessageBox.Show(direccion);
                pdfVisualizador.LoadFile($"{direccion}\\Analiticas\\{lblID.Text}.pdf");
                vBorrar = true;
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (vBorrar)
            {
                if (MessageBox.Show("¿Realmente desea eliminar esta analítica?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string vConsulta = $"DELETE FROM Analiticas WHERE idAnalitica = {lblID.Text}";

                    if (bd.EjecutarComando(vConsulta))
                    {
                        File.Delete($"../../Analiticas/{lblID.Text}.pdf");
                        LimpiarCampos();
                        CargarAnaliticas();
                    }
                }
                else MessageBox.Show("Hubo un error al eliminar la analítica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show("Seleccione una analítica para eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        void LimpiarCampos()
        {
            foreach (Control c in pnContenedor.Controls) //Recorremos cada elemento del formulario
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }
            lblID.Text = "00";
            pdfVisualizador.LoadFile("Empty"); //Limpia el visor de pdf
        }
    }
}
