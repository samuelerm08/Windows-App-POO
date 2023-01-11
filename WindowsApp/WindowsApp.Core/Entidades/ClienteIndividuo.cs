namespace WindowsApp.Core.Entidades
{
    public class ClienteIndividuo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Apellido: {Apellido}\n" +
                   $"CUIT: {CUIT}\n" +
                   $"Email: {Email}\n" +
                   $"Telefono: {Telefono}\n" +
                   $"Direccion: {Direccion}\n";
        }
    }
}
