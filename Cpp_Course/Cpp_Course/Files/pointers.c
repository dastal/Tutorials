#include <iostream>

using namespace std;

int main()
{
    int age = 19;
    double gpa = 2.7;
    string name = "James";

    // prints out the pysical memory address where the value is stored (pointer). Use & before the variable
    cout << "Age: " << &age << endl;
    cout << "Gpa: " << &gpa << endl;
    cout << "Name: " << &name << endl;

    cout << "\n" << endl;

    // storing the pointer of age in pAge
    int *pAge = &age;

    double *pGpa = &gpa;
    string *pName = &name;

    cout << pAge << endl;
    cout << pGpa << endl;
    cout << pName << endl;

    cout << "\n" << endl;

    // dereferencing the pointer
    cout << *pAge << endl;
    cout << *pGpa << endl;
    cout << *pName << endl;

    cout << "\n" << endl;

    cout << *&age << endl;
    cout << &*&age << endl;

    return 0;
}
