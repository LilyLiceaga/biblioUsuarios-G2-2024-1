using System;

namespace biblioUsuarios_G2_2024_1
{
    public class Usuario
    {
        #region Attributos
        private string nomUsuario;
        private string password;
        #endregion

        #region Propiedades
        //encapsular
        public string NomUsuario { get => nomUsuario; set => nomUsuario = value; }  
        public string Password { get => password; set => password = value; }
        #endregion

        #region Constructor
        public Usuario(string nomUsuario, string password)
        {
            NomUsuario = nomUsuario;
            Password = password;
        }
        #endregion
    }
}
