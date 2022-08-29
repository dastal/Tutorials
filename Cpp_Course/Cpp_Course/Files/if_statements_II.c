#include <iostream>

using namespace std;

int getMax(int num1, int num2){
    int result;

    if (num1 >= num2){
        result = num1;
    }
    else{
        result = num2;
    }

    return result;
}

int getMax1(int num1, int num2, int num3){
    int result;

    if (num1 >= num2 && num1 >= num3){
        result = num1;
    } else if (num2 >= num1 && num2 >= num3){
        result = num2;
    } else {
        result = num3;
    }

    return result;
}

// More comparison operators; ==, >, <, <=, !=

int main()
{
    cout << "The result is: " << getMax(2, 5) << endl;
    cout << "The result is: " << getMax(5, 2) << endl;
    cout << "The result is: " << getMax(2, 2) << endl;
    cout << "The result is: " << getMax1(2, 5, 10) << endl;
    cout << "The result is: " << getMax1(20, 5, 10) << endl;
    cout << "The result is: " << getMax1(2, 50, 10) << endl;
    cout << "The result is: " << getMax1(50, 50, 10) << endl;

    return 0;
}
