// Base class
public class LibraryItem
{
    public string Title { get; set; }
    private int itemId;

    public int ItemID
    {
        get { return itemId; }
        set { itemId = value; }  // Encapsulated property
    }

    public LibraryItem(string title, int id)
    {
        Title = title;
        ItemID = id;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Item ID: {ItemID}");
    }
}

// Derived class for Book
public class Book : LibraryItem
{
    public string Author { get; set; }

    public Book(string title, int id, string author) : base(title, id)
    {
        Author = author;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}, Item ID: {ItemID}");
    }
}

// Derived class for Magazine
public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }

    public Magazine(string title, int id, int issueNumber) : base(title, id)
    {
        IssueNumber = issueNumber;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Magazine: {Title}, Issue Number: {IssueNumber}, Item ID: {ItemID}");
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        List<LibraryItem> libraryItems = new List<LibraryItem>();

        // Adding items to the library
        libraryItems.Add(new Book("C# Basics", 101, "John Doe"));
        libraryItems.Add(new Magazine("Tech Weekly", 202, 15));

        // Display all items
        foreach (LibraryItem item in libraryItems)
        {
            item.DisplayInfo();  // Polymorphism at work
        }
    }
}
