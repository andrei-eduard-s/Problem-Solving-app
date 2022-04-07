/*Se citeste un vector cu n elemente numere naturale. Afisati
elementele care sunt numere factoriale. Se vor folosi functii
recursive pentru toate prelucrarile necesare.
Ex: 6
1 3 7 6 24 100
se vor afsa numerele 1 6 24*/
#include<iostream>
#include<fstream>
#include<stdlib.h>
using namespace std;
ifstream fin("r.in");
int ok(int x, int n)
{
   if(x==1) return 1;
   else if(x%n!=0) return 0;
        else return ok(x/n, n+1);
}


void citire(int n, int a[100])
{
	if(n>0)
	{
		citire(n-1,a);
		fin>>a[n];
	}
}

void afis(int n, int a[100])
{
	if(n>0)
	{
		afis(n-1,a);
		if(ok(a[n],2)) cout<<a[n]<<" ";
	}
}

int main()
{
	int n,a[100];
	fin>>n;
	citire(n,a);
	afis(n,a);
	cout<<endl;
	fin.close();
	system("pause");
	return 0;
}
