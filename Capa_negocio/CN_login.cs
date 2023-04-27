using Capa_datos;
using Capa_entidad;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace Capa_negocio
{
    public class CN_login
    {
        CD_login ologin = new CD_login();


        public bool Lista(Ce_login login)// crear un metodo que retone un valor de tipo boleano y rcibe un modelo ce_login
        {
            string contrasena = login.Contraseña; //se crea una variable de tipo string a la cual e le asigna el valoe de login.contrasena

            bool permitiringreso = false;//se crea una veriable de tipo de boolean 

            contrasena = GetSHA256(contrasena);

            List<string> lista = ologin.lista(login);

            if (login.Usuario == lista[0] && contrasena == lista[1])
                permitiringreso = true;

            return permitiringreso;

        }


        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }


    }
}

