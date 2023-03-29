// See https://aka.ms/new-console-template for more information
LinqQueries queries = new LinqQueries();
ImprimirValores(queries.TodaLaCollection());
void ImprimirValores (IEnumerable<Book> listaLibros){
    Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15}\n\n", "|| Titulo ||" , "|| #Paginas ||" , "|| FechaPublicado ||");

    foreach (var item in listaLibros)
    {
        Console.WriteLine("{0 , -60}   {1 , 15}   {2, 15}\n", item.Title , item.PageCount, item.PublishedDate.ToShortDateString());
        
    }
}