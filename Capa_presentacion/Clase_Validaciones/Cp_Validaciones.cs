using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Capa_presentacion.Clase_Validaciones
{
    public class Cp_Validaciones
    {
        public static void SoloNum(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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
