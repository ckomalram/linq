using Animals;

// See https://aka.ms/new-console-template for more information
LinqQueries queries = new LinqQueries();

// Todas
// ImprimirValores(queries.TodaLaCollection());

//Where > 2000
// ImprimirValores(queries.LibrosDps2000());

// where paginar > 250 And title contain 'in Action'
ImprimirValores(queries.LibrosPage250AndTitleContain());

//Obtener Animales verdes y con nombre que inicie con vocal
var animales = new ExcerciseWhere();
// animales.getAnimales();


void ImprimirValores (IEnumerable<Book> listaLibros){
    Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15}\n\n", "|| Titulo ||" , "|| #Paginas ||" , "|| FechaPublicado ||");

    foreach (var item in listaLibros)
    {
        Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15}\n", item.Title , item.PageCount, item.PublishedDate.ToShortDateString());
        
    }
}