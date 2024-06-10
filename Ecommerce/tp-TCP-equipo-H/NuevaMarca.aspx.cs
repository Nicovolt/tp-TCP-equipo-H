using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_TCP_equipo_H
{
    public partial class NuevaMarca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string nombreMarca = inpMarca.Text;

            if (!string.IsNullOrEmpty(nombreMarca))
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();

                try
                {
                    if (marcaNegocio.MarcaExiste(nombreMarca))
                    {
                        Response.Write("<script>alert('La marca ya existe');</script>");
                    }
                    else
                    {
                        marcaNegocio.agregarMarca(nombreMarca);

                        Response.Write("<script>alert('Marca agregada con éxito');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('El nombre de la marca no puede estar vacío');</script>");
            }
        }
    }
}