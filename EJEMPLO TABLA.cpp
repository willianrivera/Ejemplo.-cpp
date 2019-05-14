
#include<iostream>
using namespace std;


int main() {
	int a;
	int i;
	cout << " ingrese su numero" << endl;
	cin >> a;
	for (i=0;i<=12;i++) {
		cout << a*i << " " << "(" << i+1 << ")" << endl;
	}
	return 0;
}

