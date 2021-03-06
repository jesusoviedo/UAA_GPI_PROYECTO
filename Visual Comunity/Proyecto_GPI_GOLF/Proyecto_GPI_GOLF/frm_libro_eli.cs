﻿using System;
using System.Collections;
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
    public partial class frm_libro_eli : Form
    {
        private string usuario { get; set; }
        private SortedList SLeditorial, SLtipolibro, SLidioma;

        public frm_libro_eli()
        {
            InitializeComponent();
        }

        public frm_libro_eli(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        public override string ToString()
        {
            return string.Format("frm_libro_eli");
        }

        private void frm_libro_eli_Load(object sender, EventArgs e)
        {

        }

        private void inicializarDatos()
        {
            tex_año.Text = "";
            tex_autor.Text = "";
            tex_edicion.Text = "";
            tex_isbn.Text = "";
            tex_titulo.Text = "";

            com_editorial.DataSource = null;
            com_editorial.Enabled = false;
            com_editorial.Show();

            com_tipo_libro.DataSource = null;
            com_tipo_libro.Enabled = false;
            com_tipo_libro.Show();

            com_idioma.DataSource = null;
            com_idioma.Enabled = false;
            com_idioma.Show();
        }

        private void but_eliminar_libro_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessages = new StringBuilder();
            Libro lib = new Libro();
            if (tex_isbn.Text.Length == 0)
            {
                this.inicializarDatos();
                MessageBox.Show("Debe ingresar un ISBN",
                "Eliminar Libro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    lib.v_isbn = tex_isbn.Text;
                    if ((lib.ConsultarLibro(lib)).v_isbn.Length != 0)
                    {
                        tex_isbn.Text = lib.v_isbn;
                        tex_titulo.Text = lib.v_titulo;
                        tex_edicion.Text = lib.v_edicion;
                        tex_autor.Text = lib.v_autor;
                        tex_año.Text = lib.v_año;

                        SLeditorial = new SortedList();
                        SLeditorial.Add(lib.v_Deditorial, lib.v_Deditorial);
                        com_editorial.DataSource = SLeditorial.GetValueList();
                        com_editorial.Show();
                        com_editorial.Enabled = false;
                        SLeditorial.Clear();

                        SLtipolibro = new SortedList();
                        SLtipolibro.Add(lib.v_Dtipo_libro, lib.v_Dtipo_libro);
                        com_tipo_libro.DataSource = SLtipolibro.GetValueList();
                        com_tipo_libro.Show();
                        com_tipo_libro.Enabled = false;
                        SLtipolibro.Clear();

                        SLidioma = new SortedList();
                        SLidioma.Add(lib.v_Didioma, lib.v_Didioma);
                        com_idioma.DataSource = SLidioma.GetValueList();
                        com_idioma.Show();
                        com_idioma.Enabled = false;
                        SLidioma.Clear();

                        lib.v_usuario_m = this.usuario;

                        if ((MessageBox.Show("¿Desea eliminar el Libro con Titulo: " + lib.v_titulo + " ?", "Eliminar Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {

                            try
                            {
                                if (lib.EliminarLibro(lib) != 0)
                                {
                                    this.inicializarDatos();
                                    MessageBox.Show("Libro eliminada correctamente",
                                    "Eliminar Libro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
                                this.inicializarDatos();
                                MessageBox.Show(ex.Errors[0].Message.ToString(),
                                    "Eliminar Libro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
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
                    this.inicializarDatos();
                    MessageBox.Show(ex.Errors[0].Message.ToString(),
                    "Eliminar Libro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }

            }
        }
    }
}
