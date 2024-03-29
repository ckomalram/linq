﻿using Animals;

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

// ImprimirValores(queries.LibrosSelectTake());


//Count: Libros que tengan entre 200 y 500 paginas
// Console.WriteLine($"Libros que tengan entre 200 y 500 paginas => {queries.LibrosCountPage()}");

// MIN: Libro con la menor fecha de publicación
// Console.WriteLine($"Libro con la menor fecha de publicación => {queries.LibrosMinFecha()}");

// MAX: Libro con mas # paginas
// Console.WriteLine($"Libro con mas # paginas => {queries.LibrosMaxPage()}");

//MINBY: Libro con min page con  paginas > 0 => 
// var librorta = queries.LibrosMinByPage();
// Console.WriteLine($"Libro con min page con  paginas > 0 =>  {librorta.Title} - {librorta.PageCount}");

//MAXBY: Libro con fecha de publicación mas reciente
// var librorta2 = queries.LibrosMaxByDate();
// Console.WriteLine($"Libro con fecha de publicación mas reciente=>  {librorta2.Title} - {librorta2.PublishedDate.ToShortDateString()}");

// SUM : Suma cantidad de pagina de todos los libros que tengan  0 y 500 paginas => 
// Console.WriteLine($"Suma cantidad de pagina de todos los libros que tengan  0 y 500 paginas =>  {queries.SumaLibrosPagina()}");

// AGGREGATE: Titulo de libros que tienen fecha mayor a 2015 => 
// Console.WriteLine($"Titulo de libros que tienen fecha mayor a 2015 => \n {queries.LibrosAggregateTittle()}");


// AVERAGE:  Promedio de caracteres de los titulos de los libros =>
// Console.WriteLine($"Promedio de caracteres de los titulos de los libros => {queries.LibrosAverageTitle()}");

// GROUP BY: Libros que fueron publicados a partir del 2000, agrupados por años
// ImprimirGrupo(queries.LibrosGroupByYear());

//LOOKUP: Retorna un diccionario de libros que permita consultar por primera letra del titulo
// var rtaLookup = queries.LibrosDiccionarioPorLetra();
// ImprimirDiccionario(rtaLookup, 'P');

// JOIN : Libros con mas de 500 paginas y otra collecion que contengan año mayor 2005, retornar ambas **simulando 
ImprimirValores(queries.LibrosJoin());


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

// void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
// {
//     foreach(var grupo in ListadeLibros)
//     {
//         Console.WriteLine("");
//         Console.WriteLine($"Grupo: { grupo.Key }");
//         Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
//         foreach(var item in grupo)
//         {
//             Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
//         }
//     }
// }

void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
   Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   foreach(var item in ListadeLibros[letra])
   {
         Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
   }
}