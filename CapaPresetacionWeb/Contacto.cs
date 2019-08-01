using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresetacionWeb
{
    public partial class Contacto : System.Web.UI.Page
    {
        Comentarios CE = new Comentarios();
        LogicaNegociosComentarios CN = new LogicaNegociosComentarios();
    }
}