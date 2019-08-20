using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace capaPresentacionWF
{
    public partial class fRecursos : Form
    {
        LogicaNegociosRecursos logicaNR = new LogicaNegociosRecursos();

        public fRecursos()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text=="Guardar")
                {
                    Recursos objetoRecurso = new Recursos();
                    objetoRecurso.nombrer = textBoxNombrer.Text;
                    objetoRecurso.codigo = textBoxCodigo.Text;
                    objetoRecurso.descripcion = textBoxDescripcion.Text;

                    if (logicaNR.insertarRecursos(objetoRecurso) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewRecursos.DataSource = logicaNR.ListarRecursos();
                        textBoxNombrer.Text = "";
                        textBoxCodigo.Text = "";
                        textBoxDescripcion.Text = "";
                        tabRecursos.SelectedTab = tabPage2;
                    }
                    else
                    { MessageBox.Show("Error al agregar Recurso"); }
                }
            

                if (buttonGuardar.Text=="Actualizar")
                {
                    Recursos objetoRecurso=new Recursos();
                    objetoRecurso.idrecursos=Convert.ToInt32(textBoxId.Text);
                    objetoRecurso.nombrer=textBoxNombrer.Text;
                    objetoRecurso.codigo=textBoxCodigo.Text;
                    objetoRecurso.descripcion=textBoxDescripcion.Text;

                if (logicaNR.EditarRecursos(objetoRecurso)>0)
                {
		            MessageBox.Show("Actualizado con éxito");
                    dataGridViewRecursos.DataSource=logicaNR.ListarRecursos();
                    textBoxNombrer.Text = "";
                    textBoxDescripcion.Text = "";
                    textBoxCodigo.Text = "";
                    tabRecursos.SelectedTab=tabPage2;
	            }
                else
                {
                    MessageBox.Show("Error al actualizar Recurso");
                }
                buttonGuardar.Text = "Guardar";
            }
        }
        catch
        {
            MessageBox.Show("ERROR");
        }

        }

        private void fRecursos_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewRecursos.DataSource = logicaNR.ListarRecursos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewRecursos.CurrentRow.Cells["idrecursos"].Value.ToString();
            textBoxNombrer.Text = dataGridViewRecursos.CurrentRow.Cells["nombrer"].Value.ToString();
            textBoxCodigo.Text = dataGridViewRecursos.CurrentRow.Cells["codigo"].Value.ToString();
            textBoxDescripcion.Text = dataGridViewRecursos.CurrentRow.Cells["descripcion"].Value.ToString();

            tabRecursos.SelectedTab = tabPage1;
            buttonGuardar.Text = "actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigR = Convert.ToInt32(dataGridViewRecursos.CurrentRow.Cells["idrecursos"].Value.ToString());
            try
            {
                if (logicaNR.EliminarRecursos(codigR) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewRecursos.DataSource = logicaNR.ListarRecursos();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Recursos");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Recursos> listaRecursos = logicaNR.BuscarRecursos(TexBoxBuscar.Text);
            dataGridViewRecursos.DataSource = listaRecursos;
        }
    }
}
