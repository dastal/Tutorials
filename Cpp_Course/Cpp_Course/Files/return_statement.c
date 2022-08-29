#include <iostream>

using namespace std;

double cube(double num){
    double result = num * num * num;
    return result;
}

double cube1(double num){
    return num * num * num;
    cout << "Hello"
}

// return signals C++ to end the function

int main()
{
    double answer = cube(5.0);

    cout << "The result is: " << answer << endl;
    cout << "The result is: " << cube(5.0) << endl;
    cout << "The result is: " << cube1(5.0) << endl;

    return 0;
}
