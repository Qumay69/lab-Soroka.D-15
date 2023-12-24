//Вариант 14 уровень сложности средний

KnegrMagaZ knegr = new KnegrMagaZ();
try
{


    Console.Write("Введите название книги:");
    knegr.Name = Console.ReadLine();
    Console.Write("Введите автора:");
    knegr.Author = Console.ReadLine();
    Console.Write("Введите год:");
    knegr.YearPublication = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите цену:");
    knegr.Price = Convert.ToDouble(Console.ReadLine());

}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}

Console.WriteLine(knegr.Name);
Console.WriteLine(knegr.Author);
Console.WriteLine(knegr.YearPublication);
Console.WriteLine(knegr.SkolkoLetKnegr());
Console.WriteLine(knegr.Price);
knegr.Discount();
Console.WriteLine(knegr.Price);
public class Knegr
{
    private string name;
    private string author;
    private int yearPublication;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public int YearPublication
    {
        get { return yearPublication; }
        set
        {
            if (yearPublication >= 0) yearPublication = value;
            else yearPublication = 0;
        }
    }
    public Knegr()
    {
        this.name = "";
        this.author = "";
        this.yearPublication = 0;
    }

    public Knegr(string name, string author, int yearPublication)
    {
        this.name = name;
        this.author = author;
        this.yearPublication = yearPublication;
    }

    public int SkolkoLetKnegr()
    {
        return DateTime.Now.Year - YearPublication;
    }
}
public class KnegrMagaZ : Knegr
{
    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                price = 0;
        }
    }
    public KnegrMagaZ()
    {
        this.price = 0;
    }

    public KnegrMagaZ(string name, string author, int yearPublication, int price) : base(name, author, yearPublication)
    {
        this.price = 0;
    }
    public void Discount() 
    {
        if (base.SkolkoLetKnegr() > 5)
        {
           this.price *= 0.8;
        }
        
    }
}
