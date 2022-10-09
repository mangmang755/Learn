using System.Text;
struct Books
{
    private string title;
    private string author;
    private string subject;
    private int book_id;
    public void setValues(string t,string a,string s,int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }
    public void display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("Book_id :{0}", book_id);
    }

}

public class testStructure
{
    public static void Main(string[] args)
    {
        Books Book1 = new Books();
        Books Book2 = new Books();

        Book1.setValues("C Programming",
      "Nuha Ali", "C Programming Tutorial", 6495407);
        Book2.setValues("Telecom Billing",
      "Zara Ali", "Telecom Billing Tutorial", 6495700);
        Book1.display();
        Book2.display();
        Console.ReadLine();
    }
}