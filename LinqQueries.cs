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
}