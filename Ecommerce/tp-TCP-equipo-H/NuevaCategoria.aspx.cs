using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace tp_TCP_equipo_H
{
    public partial class NuevaCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string nombreCategoria = inpCategoria.Text;

            if (!string.IsNullOrEmpty(nombreCategoria))
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                try
                {
                    if (categoriaNegocio.CategoriaExiste(nombreCategoria))
                    {
                        Response.Write("<script>alert('La categoría ya existe');</script>");
                    }
                    else
                    {
                        categoriaNegocio.agregarCategoria(nombreCategoria);

                        Response.Write("<script>alert('Categoría agregada con éxito');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('El nombre de la categoría no puede estar vacío');</script>");
            }
        }
    }
}