#include <iostream>

using namespace std;

class Book {
    public:
        string title;
        string author;
        int pages;
        Book (){
            title = "no title";
            author = "no author";
            pages = 0;
        }
        Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            cout << "Creating new Book" << endl;
            cout << "Name: " << aTitle << endl;
            cout << "Author: " << aAuthor << endl;
            cout << "Pages: " << aPages << endl;
            cout << "\n" << endl;
        }
};

int main()
{
    Book book1("Harry Potter", "JK Rowling", 500);
    Book book2("Lord of the Rings", "Tolkien", 700);

    Book book3;
    cout << book3.title << endl;
    cout << book3.author << endl;
    cout << book3.pages << endl;

    return 0;
}
