#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    int wnum = 5;
    cout << wnum << endl;
    wnum ++;
    cout << wnum << endl;
    wnum --;
    cout << wnum << endl;
    wnum += 80;
    cout << wnum << endl;

    double dnum = 5.5;
    cout << dnum << endl;

    cout << 40 << endl;
    cout << -40 << endl;
    cout << 40.1 << endl;
    cout << 5 + 7 << endl;
    cout << 5 - 7 << endl;
    cout << 5 * 7 << endl;
    cout << 5 / 7 << endl;
    cout << 10 % 3 << endl;
    cout << 5 + 7 * 10 << endl;
    cout << (5 + 7) * 10 << endl;

    cout << 5.5 + 9 << endl;

    cout << 10 / 3 << endl;
    cout << 10.0 / 3.0 << endl;

    // Cmath
    cout << pow(2, 5) << endl;
    cout << sqrt(36) << endl;
    cout << sqrt(36.0) << endl;
    cout << round(4.3) << endl;
    cout << round(4.6) << endl;
    cout << ceil(4.1) << endl;
    cout << floor(4.9) << endl;
    cout << fmax(3, 10) << endl;
    cout << fmin(3, 10) << endl;

    return 0;
}
