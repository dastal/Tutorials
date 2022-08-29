#include <iostream>

using namespace std;

class Book {
    public:
        string title;
        string author;
        int pages;
};

int main()
{
    Book book1;
    book1.title = "Harry Potter";
    book1.author = "JK Rowling";
    book1.pages = 500;

    cout << book1.title << endl;
    cout << book1.author << endl;
    cout << book1.pages << endl;

    cout << "\n" << endl;

    Book book2;
    book2.title = "Lord of the Rings";
    book2.author = "Tolkien";
    book2.pages = 700;

    cout << book2.title << endl;
    cout << book2.author << endl;
    cout << book2.pages << endl;

    cout << "\n" << endl;

    book2.title = "Hunger Games";
    cout << book2.title << endl;

    return 0;
}
