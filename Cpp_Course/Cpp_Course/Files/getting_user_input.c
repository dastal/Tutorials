#include <iostream>

using namespace std;

int main()
{
    int age;
    cout << "Enter your age: " << endl;
    cin >> age;
    cout << "You are " << age << " years old." << endl;

    cout << "\n" << endl;

    double dage;
    cout << "Enter your age: " << endl;
    cin >> dage;
    cout << "You are " << dage << " years old." << endl;


    cout << "\n" << endl;

    char cage;
    cout << "Enter your age: " << endl;
    cin >> cage;
    cout << "You are " << cage << " years old." << endl;

    cout << "\n" << endl;

    // Strings are different

    string name;
    cout << "Enter your name: ";
    getline(cin, name);

    cout << "Hello " << name << "." << endl;

    return 0;
}
