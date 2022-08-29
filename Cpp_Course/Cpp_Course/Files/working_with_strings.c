#include <iostream>

using namespace std;

int main()
{
    cout << "C++ Tutorial";
    cout << "Hello" << endl;

    cout << "\n" << endl;

    cout << "C++ Tutorial\n";
    cout << "Hello" << endl;

    cout << "\n" << endl;

    string phrase = "C++ Tutorial";
    cout << phrase << endl;

    cout << "\n" << endl;

    //String Functions
    cout << phrase.length() << endl;
    cout << phrase[0] << endl;
    cout << phrase[2] << endl;

    phrase[0] = 'G';
    cout << phrase[0] << endl;
    cout << phrase.find("Tutorial") << endl;
    cout << phrase.find("Tutorial", 0) << endl;
    cout << phrase.find("orial", 0) << endl;
    string phrasesub;
    phrasesub = phrase.substr(8, 3);
    cout << phrasesub << endl;

    return 0;
}
