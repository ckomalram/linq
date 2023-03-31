public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

    public IEnumerable<Book> TodaLaCollection()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDps2000()
    {

        // With extension method
        return librosCollection.Where(p => p.PublishedDate.Year > 2000);

        // With query expresion
        // return from lc in librosCollection where lc.PublishedDate.Year > 2000 select lc;
    }

    public IEnumerable<Book> LibrosPage250AndTitleContain()
    {

        // With extension method
        return librosCollection.Where(p => p.PageCount > 250 && p.Title.Contains("in Action"));

        // With query expresion
        // return from lc in librosCollection where lc.PageCount > 250 && lc.Title.Contains("in Action") select lc;
    }

    public IEnumerable<Book> LibrosCategoriaPython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }

    public bool LibrosStatusAll()
    {
        return librosCollection.All(p => p.Status != string.Empty);
    }

    public bool LibrosPublicado2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }


    public IEnumerable<Book> LibrosJavaPorNombreAsc()
    {
        return librosCollection
                    .Where(p => p.Categories.Contains("Java"))
                    .OrderBy(p => p.Title);
    }


    public IEnumerable<Book> LibrosPaginas450Desc()
    {
        return librosCollection
                    .Where(p => p.PageCount > 450)
                    .OrderByDescending(p => p.PageCount);
    }

    public IEnumerable<Book> LibrosJavaTake()
    {
        return librosCollection
                    .Where(p => p.Categories.Contains("Java"))
                    .OrderByDescending(p => p.PublishedDate)
                    .Take(3);
        // .TakeLast(3);
    }

    public IEnumerable<Book> LibrosJavaTakeSkip()
    {
        return librosCollection
                    .Where(p => p.PageCount > 400)
                    .Take(4)
                    .Skip(2);
        // .TakeLast(3);
    }


    public IEnumerable<Book> LibrosSelectTake()
    {
        return librosCollection
                    .Take(3)
                    .Select(p => new Book() { Title = p.Title, PageCount = p.PageCount, PublishedDate = p.PublishedDate });
        // .TakeLast(3);
    }

    public int LibrosCountPage()
    {
        var rta = librosCollection
                    .Count(p => p.PageCount >= 200 && p.PageCount <= 500);


        return rta;
    }

    public long LibrosLongCountPage()
    {
        var rta = librosCollection
                    .LongCount(p => p.PageCount >= 200 && p.PageCount <= 500);


        return rta;
    }

    public DateTime LibrosMinFecha()
    {
        return librosCollection.Min(p => p.PublishedDate);
    }

    public int LibrosMaxPage()
    {
        return librosCollection.Max(p => p.PageCount);
    }

    public Book LibrosMinByPage()
    {

        return librosCollection.Where(p => p.PageCount > 0).MinBy(p => p.PageCount);
    }

    
    public Book LibrosMaxByDate()
    {

        return librosCollection.MaxBy(p => p.PublishedDate);
    }

    public int SumaLibrosPagina(){
        return librosCollection
        .Where(p => p.PageCount >= 0 && p.PageCount <= 500)
        .Sum(p => p.PageCount);
    }

    public string LibrosAggregateTittle(){

        return librosCollection.Where(p => p.PublishedDate.Year > 2015)
                                .Aggregate("", (TitulosLibros, next ) => {
                                 if (TitulosLibros  != string.Empty)
                                 {
                                    TitulosLibros += "\n" + next.Title;
                                 }else
                                 {
                                    TitulosLibros +=   next.Title;
                                    
                                 }
                                 return TitulosLibros;
                                });
    }






}