/*Se citeste un vector cu n elemente numere naturale folosind o
functie recursiva. Sa se calculeze suma tuturor cifrelor din care
sunt formate elementele vectorului folosind doar functii recursive.*/
#include <iostream>
#include<fstream>
#include<stdlib.h>
using namespace std;
ifstream f("date10.in");
using namespace std;
int n, a[100];
void citire(int a[100], int n)
{
	if(n>0)
	{ citire(a,n-1);
	  f>>a[n];
	}
}
int sumacif(int n)
{
	if(n==0) return 0;
	else return n%10+sumacif(n/10);
}

int suma(int a[100], int n)
{
	if(n==0) return 0;
	else return
		suma(a,n-1)+sumacif(a[n]);
}
int main()
{
	f>>n;
	citire(a,n);
	cout<<"Suma tuturor cifrelor: "<<suma(a,n);
	cout<<endl;
	system("pause");
	return 0;
}
