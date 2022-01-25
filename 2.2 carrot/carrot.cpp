//carrot.cpp -- food processing program
//uses and display a variable

#include <iostream>
int main() {
	using namespace std;
	int carrot;
	carrot = 25;
	cout << "I have " << carrot << " carrots." << endl;
	carrot = carrot - 1;
	cout << "Crunch Crunch. Now I have " << carrot << " carrots" << endl;
	return 0;
}