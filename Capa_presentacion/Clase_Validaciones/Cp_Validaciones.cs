using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Capa_presentacion.Clase_Validaciones
{
    public class Cp_Validaciones
    {
        public static void SoloNum(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public static bool ValidarCorreoElectronico(string correoElectronico)  // Metodo encargado de validar un correo electronico
        {
            if (string.IsNullOrEmpty(correoElectronico))
            {
                return false;
            }

            // Expresi�n regular para validar el correo electr�nico
            string patron = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Match match = Regex.Match(correoElectronico.Trim(), patron);

            return match.Success;
        }
    }
}
