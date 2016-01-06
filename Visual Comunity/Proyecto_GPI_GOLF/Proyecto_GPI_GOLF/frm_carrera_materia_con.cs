using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario_logica;

namespace Proyecto_GPI_GOLF
{
    public partial class frm_carrera_materia_con : Form
    {
        private String usuario, nombre, promocion;
        StringBuilder errorMessages = new StringBuilder();
        Carrera ca = new Carrera();

        public frm_carrera_materia_con()
        {
            InitializeComponent();
        }

        public frm_carrera_materia_con(String usuario, String nombre, String promocion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.nombre = nombre;
            this.promocion = promocion;

            this.consultaInicial();
        }

        private void dat_carrera_materia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_carrera_materia_con_Load(object sender, EventArgs e)
        {

        }
        private void consultaInicial()
        {
            ca.v_nombre = this.nombre;
            ca.v_promocion = this.promocion;
            try
            {

                if ((ca.ConsultarCarreraMateria(ca)).v_materia_carrera.Count != 0)
                {

                    dat_carrera_materia.ColumnCount = 1;
                    dat_carrera_materia.Columns[0].Name = "materia";
                    foreach (String materias in ca.v_materia_carrera)
                    {
                        dat_carrera_materia.Rows.Add(materias);
                    }

                }
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                MessageBox.Show(ex.Errors[0].Message.ToString(),
                "Consultar Materia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
