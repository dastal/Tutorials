#include <iostream>

using namespace std;

int main()
{
    bool isMale = true;

    if(isMale){
        cout << "You are a male." << endl;
    }


    bool isMale1 = false;

    if(isMale1){
        cout << "You are a male." << endl;
    } else {
        cout << "You are not male." << endl;
    }

    cout << "\n" << endl;

    bool isMale2 = true;
    bool isTall = true;

    if(isMale2 && isTall){
        cout << "You are a tall male." << endl;
    } else {
        cout << "You are not male." << endl;
    }

    cout << "\n" << endl;

    bool isMale3 = false;
    bool isTall1 = true;

    if(isMale3 && isTall1){
        cout << "You are a tall male." << endl;
    } else {
        cout << "You are not male." << endl;
    }

    cout << "\n" << endl;

    if(isMale3 || isTall1){
        cout << "You are a tall male." << endl;
    } else {
        cout << "You are not male." << endl;
    }

    cout << "\n" << endl;

    bool isMale4 = true;
    bool isTall2 = true;

    if(isMale4 && isTall2){
        cout << "You are a tall male." << endl;
    } else if (isMale4 && !isTall2){
        cout << "You are a short male." << endl;
    } else if (!isMale4 && isTall2){
        cout << "You are not a male but you are tall." << endl;
    } else {
        cout << "You are not male and not tall." << endl;
    }

    cout << "\n" << endl;

    bool isMale5 = true;
    bool isTall3 = false;

    if(isMale5 && isTall3){
        cout << "You are a tall male." << endl;
    } else if (isMale5 && !isTall3){
        cout << "You are a short male." << endl;
    } else if (!isMale5 && isTall3){
        cout << "You are not a male but you are tall." << endl;
    } else {
        cout << "You are not male and not tall." << endl;
    }

    cout << "\n" << endl;

    bool isMale6 = false;
    bool isTall4 = true;

    if(isMale6 && isTall4){
        cout << "You are a tall male." << endl;
    } else if (isMale6 && !isTall4){
        cout << "You are a short male." << endl;
    } else if (!isMale6 && isTall4){
        cout << "You are not a male but you are tall." << endl;
    } else {
        cout << "You are not male and not tall." << endl;
    }

    cout << "\n" << endl;

    bool isMale7 = false;
    bool isTall5 = false;

    if(isMale7 && isTall5){
        cout << "You are a tall male." << endl;
    } else if (isMale7 && !isTall5){
        cout << "You are a short male." << endl;
    } else if (!isMale7 && isTall5){
        cout << "You are not a male but you are tall." << endl;
    } else {
        cout << "You are not male and not tall." << endl;
    }

    return 0;
}
