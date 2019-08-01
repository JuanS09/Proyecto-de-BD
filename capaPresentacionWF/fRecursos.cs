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
    }
}
