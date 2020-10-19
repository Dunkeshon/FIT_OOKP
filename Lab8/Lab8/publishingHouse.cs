using System;
using System.Collections.Generic;

public class Book
{
    private string title;
    private string author;
    public Book()
    {

    }
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }
    public override string ToString()
    {
        return "\n" + "Title: " + title + "\n" + "Author:" + author;
    }

    public string Title => title;
    public string Author => author;
}
public class PublishingHouse
{
    private string companyName;
    private List<Book> publishedBooks;
    private int dateOfFoundation;
    private int amountOfpublishedBooks;

    public PublishingHouse()
    {

    }
    public PublishingHouse(string companyName, List<Book> publishedBooks,
        int dateOfFoundation, int amountOfpublishedBooks)
    {
        this.companyName = companyName;
        this.publishedBooks = publishedBooks;
        this.dateOfFoundation = dateOfFoundation;
        this.amountOfpublishedBooks = amountOfpublishedBooks;
    }

    // indexator
    // @brief help get acces to published books 
    public Book this[int index]
    {
        get
        {
            return publishedBooks[index];
        }
        set
        {
            publishedBooks[index] = value;
        }
    }

    public override string ToString()
    {
        string resultString = "";
        string allBooks = "";
        resultString += "Company name: " + companyName + "\n";

        foreach (Book i in publishedBooks)
        {
            allBooks += i.ToString();
        }
        resultString += "Published Books: " + allBooks + "\n";
        resultString += "Date of Foundation: " + dateOfFoundation + "\n";
        resultString += "Amount of PublishedBooks " + amountOfpublishedBooks + "\n";
        return resultString;
    }

    public void PublishBooks(List<Book> booksToPublish)
    {
        foreach (Book i in booksToPublish)
        {
            publishedBooks.Add(i);
        }
        amountOfpublishedBooks = publishedBooks.Count;
    }
    public void PublishBooks(string title, string author)
    {
        publishedBooks.Add(new Book(title, author));
        amountOfpublishedBooks++;
    }

    public string CompanyName => companyName;
    public List<Book> PublishedBooks { private set; get; }
    public int DateOfFoundation { private set; get; }
    public int AmountOfpublishedBooks { private set; get; }

}
