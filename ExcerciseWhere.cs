namespace Animals
{
    public class ExcerciseWhere
    {

        public ExcerciseWhere()
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
            animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
            animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
            animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
            animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
            animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
            animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
            animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
            animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });


            var resultado = animales.Where(a => a.Color == "Verde" && "AEIOU".Contains(char.ToUpper(a.Nombre[0])));
            var resultado2 = from ani in animales where ani.Color == "Verde" && "AEIOU".Contains(char.ToUpper(ani.Nombre[0])) select ani;
            // Console.Write(resultado );

            Console.WriteLine("----Extension Verde y con vocal al inicio: " );
            
            foreach (var animal in resultado)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}, Color: {animal.Color}");
            }
            
            Console.WriteLine("----Expression Verde y con vocal al inicio:  " );

            foreach (var animal in resultado2)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}, Color: {animal.Color}");
            }
        }

        //    public void getAnimales(){
        //     var resultado = animales.Where(a => a.Color == "Verde" && "AEIOU".Contains(char.ToUpper(a.Nombre[0]))).ToList();
        //     Console.Write(resultado );
        //   }

        public class Animal
        {
            public string Nombre { get; set; }
            public string Color { get; set; }
        }
    }
}
