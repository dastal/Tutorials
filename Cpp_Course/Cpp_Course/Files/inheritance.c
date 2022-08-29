#include <iostream>

using namespace std;

// Superclass
class Chef {
    public:
        void makeChicken() {
            cout << "The Chef makes Chicken." << endl;
        }
        void makeSalad() {
            cout << "The Chef makes Salad." << endl;
        }
        void makeSpecialDish() {
            cout << "The Chef makes BBQ Ribs." << endl;
        }
};

// Subclass
class ItalianChef : public Chef {
    public:
        void makeSpecialDish() {
            cout << "The Chef makes Chicken Parm." << endl;
        }
        void makePasta() {
            cout << "The Chef makes Pasta." << endl;
        }
};

int main()
{
    Chef chef;
    chef.makeChicken();
    chef.makeSpecialDish();

    ItalianChef italianChef;
    italianChef.makeChicken();
    italianChef.makePasta();
    italianChef.makeSpecialDish();

    return 0;
}
