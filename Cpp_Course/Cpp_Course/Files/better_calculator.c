#include <iostream>

using namespace std;

int main()
{
    int num1, num2;
    char op;

    cout << "Enter first number: " << endl;
    cin >> num1;
    cout << "Which operation do you want to carry out? Enter +,-,* or /:" << endl;
    cin >> op;
    cout << "Enter second number; " << endl;
    cin >> num2;

    int result;

    if(op == '+'){
        result = num1 + num2;
    } else if(op == '-'){
        result = num1 - num2;
    } else if(op == '*'){
        result = num1 * num2;
    } else if(op == '/'){
        result = num1 / num2;
    } else {
        cout << "Invalid operator" << endl;
    }

    cout << "The result is: " << result << endl;

    return 0;
}
