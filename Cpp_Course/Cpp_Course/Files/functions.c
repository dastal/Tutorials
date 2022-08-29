#include <iostream>

using namespace std;

// Functions must be implemented BEFORE the main function!

void sayHi(){
    cout << "Hello User" << endl;
}

void sayHi1(string name){
    cout << "Hello " << name << endl;
}

void sayHi2(string name, int age){
    cout << "Hello " << name << ", you are " << age << " years old." << endl;
}

// But it can be instantiated first and given the functionality after the main function
void sayHi3(string name, int age);

int main()
{
    string name = "Dave";
    int age = 100;

    sayHi();
    sayHi1(name);
    sayHi2(name, age);
    sayHi2("Steve", 45);
    sayHi2("Tom", 19);
    sayHi3("Dave", 29);

    return 0;
}

void sayHi3(string name, int age){
    cout << "Hello " << name << ", you are " << age << " years old." << endl;
}
