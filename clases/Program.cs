// Nombre del espacio de trabajo
namespace Clases
{
    //[modificador de acceso] - [clase] - [identificador]
    public class ClaseCustom()
    {
        // Propiedades
        bool boolProp = true;
        int intProp = 1;
        string stringProp = "Esta es una propiedad";

        // Metodo principal
        public static void Main()
        {
            CallClaseExtra();
        }

        // Metodo publico para ser accedido
        public static void CallClaseExtra()
        {
            // Invocando una clase para su uso
            var clase = new ClaseExtra();

            clase.Llamado("Holaaaa mundo");

            Console.WriteLine(clase.RetornandoLlamado("Hola mundo de regreso"));
        }

    }

    // Clase extra para metodos especifios
    class ClaseExtra()
    {
        // ejemplo de metodo para invocar de la clase
        // pero que ejecuta una orden sin regresar algún valor
        public void Llamado(string ejemplo)
        {
            Console.WriteLine(ejemplo);
        }

        // metodo extra que retorna algún valor
        public string RetornandoLlamado(string ejemplo)
        {
            return ejemplo;
        }
    }
}
