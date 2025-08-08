namespace BackendCConecta.Aplicacion.Modulos.Usuarios.Utilidades
{
    public static class ReglasUsuario
    {
        public static bool EsCorreoValido(string correo)
        {
            return correo.Contains("@") && correo.Contains(".");
        }

        public static bool EsTipoAccesoValido(string tipo)
        {
            return new[] { "usuario", "colaborador", "administrador" }.Contains(tipo.ToLower());
        }
    }
}
