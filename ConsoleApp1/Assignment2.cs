#nullable enable
using System;
using System.Text;

//Q1
{
    string title = "clean code";
    string upperTitle = title.ToUpper();
    Console.WriteLine("Q01: " + title + ", Uppercase: " + upperTitle);
}

//Q2
{
    string a = "Clean Code";
    string b = "Clean Code";
    Console.WriteLine("Q02: " + ReferenceEquals(a, b));
}

//Q3,Q4
{
    StringBuilder ab = new StringBuilder();
    ab.Append("Book List");
    ab.Append(" - Updated");
    Console.WriteLine("Q03: " + ab.ToString());
    ab.Replace("Book List", "Library");
    Console.WriteLine("Q04: " + ab.ToString());
}
//Q5
{
    string title = "Clean Code";
    int pages = 464;
    string sentence = "Book: " + title + ", Pages: " + pages;
    Console.WriteLine("Q05: " + sentence);
}
//Q6
{
    string title = "Clean Code";
    int pages = 464;
    string sentence = $"Book: {title}, Pages: {pages}";
    Console.WriteLine("Q06: " + sentence);
}
//Q7
{
    string title = "Clean Code";
    int pages = 464;
    string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);
    Console.WriteLine("Q07: " + sentence);
}
//Q8 
{
    int pages = 464;
    if (pages > 300)
        Console.WriteLine("Q08: Long Book");
    else
        Console.WriteLine("Q08: Short Book");
}
// Q9
{
    int pages = 464;
    bool isAvailable = true;
    if (pages > 300 && isAvailable)
    {
        Console.WriteLine("Q09: You can borrow this book");
    }
}
// Q10
{
    string title = "Refactoring";
    switch (title)
    {
        case "Clean code":
            Console.WriteLine("Q10: Great choice");
            break;
        case "Refactoring":
            Console.WriteLine("Q10: Nice pick!");
            break;
        default:
            Console.WriteLine("Q10: Never heard of it");
            break;
    }
}
//Q11
{
  int pages = 464;
    string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    Console.WriteLine("Q11: " + sizeLabel);

}
//Q12
{ string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    for (int i = 0; i < Books.Length; i++)
    {
        Console.WriteLine("Q12: " + (i + 1) + ". " + Books[i] + ".");
    }
}
//Q13
{
        string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        int i = 0;
        while (i < Books.Length)
        {
            Console.WriteLine("Q13: " + (i + 1) + ". " + Books[i] + ".");
            i++;
        }    
}
//Q14
{ 
string Book =  "Checking book" ;
    int i = 1;
    do
    {
        Console.WriteLine("Q14: " +  Book );
        i++;
    } while (i < 4);
}
//Q15
{
    string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    foreach (string book in Books)
    {
        Console.WriteLine("Q15: " + book);
    }
}
//Q16
{
    string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    for (int i = 0; i < Books.Length; i++)
    {
        if (Books[i] == "Refactoring")
        {
            break;
        }
        Console.WriteLine("Q16: " + Books[i]);
    }
}

//Q17 
{
    string[] Books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
    for (int i = 0; i < Books.Length; i++)
    {
        if (Books[i] == "The Pragmatic Programmer")
        {
            continue;
        }
        Console.WriteLine("Q17: " + Books[i]);
    }
}
//Q18


string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
PrintFirstBook(books);                 

string[] empty = { };
PrintFirstBook(empty);

static void PrintFirstBook(string[] books)
{
    if (books.Length == 0)
    {
        return;
    }

    Console.WriteLine("Q18: " + books[0]);
}
