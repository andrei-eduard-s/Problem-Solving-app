/*Sa se stearga din fiecare element al unui vector toate aparitiile cifrei maxime. Se vor folosi functii recursive pentru urmatoarele prelucrari:
- citirea elementelor vectorului
- determinarea cifrei maxime a unui numar
- stergerea tuturor aparitiilor unei cifre dintr-un numar
- parcurgerea vectorului si modificarea elementelor conform cerintei
- afisarea vectorului
Ex: 7
37 443 13 160 31 11 140
se vor afisa valorile: 3 3 1 10 1 0 10 */
#include <iostream>
#include<fstream>
#include<stdlib.h>
using namespace std;
ifstream fin("date5.in");
int cmax(int n)
{
	if(n<=9) return n;
	else if(cmax(n/10)>n%10) return cmax(n/10);
	     else return n%10;
}

int delcif(int n, int c)
{
	if(n==0) return 0;
	else if(n%10==c) return delcif(n/10,c);
	     else return delcif(n/10,c)*10+n%10;
}

void s(int a[100], int n)
{
	if(n>0)
	{
		s(a,n-1);
		a[n]=delcif(a[n],cmax(a[n]));
	}
}

void citire(int a[100], int n)
{
	if(n>0)
	{
		citire(a,n-1);
		fin>>a[n];
	}
}

void afis(int a[100], int n)
{
	if(n>0)
	{
		afis(a,n-1);
		cout<<a[n]<<" ";
	}
}

int main()
{
	int a[100],n;
	fin>>n;
	citire(a,n);
	s(a,n);
	afis(a,n);
	cout<<endl;
    fin.close();
	system("pause");
	return 0;
}
