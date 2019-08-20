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
    public partial class fSolicitud : Form
    {
        LogicaNegociosSolicitud logicaNS = new LogicaNegociosSolicitud();

        public fSolicitud()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonGuardar.Text == "Guardar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSoli.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.insertarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Agregado con exito");
                        dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSoli.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
                    }
                    else
                    { MessageBox.Show("Error al agregar Solicitud"); }
                }


                if (buttonGuardar.Text == "Actualizar")
                {
                    Solicitud objetoSolicitud = new Solicitud();
                    objetoSolicitud.aula = textBoxAula.Text;
                    objetoSolicitud.nivel = textBoxNivel.Text;
                    objetoSolicitud.fechasolicitud = Convert.ToDateTime(dateTimePickerFechaSoli.Text);
                    objetoSolicitud.fechauso = Convert.ToDateTime(dateTimePickerFechaUso.Text);
                    objetoSolicitud.horainicio = Convert.ToDateTime(dateTimePickerHoraInicio.Text);
                    objetoSolicitud.horafinal = Convert.ToDateTime(dateTimePickerHoraFinal.Text);
                    objetoSolicitud.carrera = textBoxCarrera.Text;
                    objetoSolicitud.asignatura = textBoxAsignatura.Text;

                    if (logicaNS.EditarSolicitud(objetoSolicitud) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito");
                        dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                        textBoxAula.Text = "";
                        textBoxNivel.Text = "";
                        dateTimePickerFechaSoli.Text = "";
                        dateTimePickerFechaUso.Text = "";
                        dateTimePickerHoraInicio.Text = "";
                        dateTimePickerHoraFinal.Text = "";
                        textBoxCarrera.Text = "";
                        textBoxAsignatura.Text = "";
                        tabSolicitud.SelectedTab = tabPage2;
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

        private void fSolicitud_Load(object sender, EventArgs e)
        {
            textBoxId.Visible = false;
            labelId.Visible = false;
            dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            textBoxId.Visible = true;
            textBoxId.Enabled = false;
            labelId.Visible = true;

            textBoxId.Text = dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString();
            textBoxAula.Text = dataGridViewSolicitud.CurrentRow.Cells["aula"].Value.ToString();
            textBoxNivel.Text = dataGridViewSolicitud.CurrentRow.Cells["nivel"].Value.ToString();
            dateTimePickerFechaSoli.Text = dataGridViewSolicitud.CurrentRow.Cells["fechasolicitud"].Value.ToString();
            dateTimePickerFechaUso.Text = dataGridViewSolicitud.CurrentRow.Cells["fechauso"].Value.ToString();
            dateTimePickerHoraInicio.Text = dataGridViewSolicitud.CurrentRow.Cells["horainicio"].Value.ToString();
            dateTimePickerHoraFinal.Text = dataGridViewSolicitud.CurrentRow.Cells["horafinal"].Value.ToString();
            textBoxCarrera.Text = dataGridViewSolicitud.CurrentRow.Cells["carrera"].Value.ToString();
            textBoxAsignatura.Text = dataGridViewSolicitud.CurrentRow.Cells["asignatura"].Value.ToString();
            comboBoxIdRecurso.Text = dataGridViewSolicitud.CurrentRow.Cells["idrecursos"].Value.ToString();
            comboBoxIdUsuario.Text = dataGridViewSolicitud.CurrentRow.Cells["idusuario"].Value.ToString();

            tabSolicitud.SelectedTab = tabPage1;
            buttonGuardar.Text = "actualizar";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int codigS = Convert.ToInt32(dataGridViewSolicitud.CurrentRow.Cells["idsolicitud"].Value.ToString());
            try
            {
                if (logicaNS.EliminarSolicitud(codigS) > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    dataGridViewSolicitud.DataSource = logicaNS.ListarSolicitud();
                }
            }
            catch
            {
                MessageBox.Show("ERROR al eliminar Solicitud");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            List<Solicitud> listaSolicitud = logicaNS.BuscarSolicitud(TexBoxBuscar.Text);
            dataGridViewSolicitud.DataSource = listaSolicitud;
        }
    }
}
