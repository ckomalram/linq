using Animals;

// See https://aka.ms/new-console-template for more information
LinqQueries queries = new LinqQueries();

// Todas
// ImprimirValores(queries.TodaLaCollection());

//Where > 2000
// ImprimirValores(queries.LibrosDps2000());

// where paginar > 250 And title contain 'in Action'
// ImprimirValores(queries.LibrosPage250AndTitleContain());

//ALL Todos libros con status
// Console.WriteLine($"Todos los libros con status?? R =>  {queries.LibrosStatusAll()}");

//ANY Alguno d elos libros publicado en 2005
// Console.WriteLine($"Algún libro publicado en 2005?? R =>  {queries.LibrosPublicado2005()}");

//CONTAINS:  libros con cateogira pyhton
// ImprimirValores(queries.LibrosCategoriaPython());

//ORDER BY :  libros que  java ordenados por titulos desc
// ImprimirValores(queries.LibrosJavaPorNombreAsc());

//ORDER BY DESC:  libros que tengan paginas  > 450, ordenados por #paginas de forma DESC
// ImprimirValores(queries.LibrosPaginas450Desc());


// TAKE: primeros 3 libros con fecha de publicado más reciente que tengan categoria Java.
// ImprimirValores(queries.LibrosJavaTake());

// SKIP: #paginas>400 escoger 3er y 4to resultado solamente.
// ImprimirValores(queries.LibrosJavaTakeSkip());

// SELECT :  Seleccionar titulo y #paginas de los 3 primeros libros

ImprimirValores(queries.LibrosSelectTake());




//EXERCISE ORDER BY : Obtener Animales verdes y con nombre que inicie con vocal
// var animales = new ExcerciseWhere();

//EXERCISE WHERE : elementos de la colleción animal ordenados por nombre
// var animales = new ExcerciseOrderBy();


void ImprimirValores (IEnumerable<Book> listaLibros){
    Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15}\n\n", "|| Titulo ||" , "|| #Paginas ||" , "|| FechaPublicado ||" );

    foreach (var item in listaLibros)
    {
        Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15} \n", item.Title , item.PageCount, item.PublishedDate.ToShortDateString() );
        
    }
}