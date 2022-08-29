#include <iostream>

using namespace std;

int main()
{
    int luckyNums[] = {4, 8, 15, 16, 23, 42};

    cout << luckyNums[0] << endl;
    cout << luckyNums[2] << endl;

    luckyNums[0] = 19;

    cout << luckyNums[0] << endl;

    luckyNums[6] = 109;

    cout << luckyNums[6] << endl;

    int luckyNums1[20] = {4, 8, 15, 16, 23, 42};

    luckyNums1[10] = 51;

    cout << luckyNums1[10] << endl;

    int luckyNums2[20];

    luckyNums2[0] = 100;

    cout << luckyNums2[0] << endl;

    return 0;
}
