namespace Parejas
{
    public class Persona
    {
       String nombre;
       int edad;
       char sexo;
       
       enum RangoEdad
       {
           M, J, P, M, V // M ("Muy Joven") >> J ("Joven") >> P ("Plenitud") >> M ("Madurez") >> V ("Vejez")
       }

       public void RangoDeEdad(){

       if ((edad >= 0) && (edad <= 19)
            {
                Console.WriteLine ("Muy Joven")
            }

        else((edad >= 20) && (edad <= 29)
            {
                Console.WriteLine ("Joven")
            }

        else ((edad >= 30) && (edad <= 39)
            {
                Console.WriteLine ("Plenitud")
            }

        else ((edad >= 40) && (edad <= 49)
            {
                Console.WriteLine ("Madurez")
            }

        else (edad >= 50)
            {
                Console.WriteLine ("Vejez")
            }
       }

        public override string ToString() => $"A codificar";
    }
}