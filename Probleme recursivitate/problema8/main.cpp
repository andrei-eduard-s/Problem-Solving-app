/*Sa se calculeze recursiv suma 1*2 + 2*3 + ... + n*(n+1).*/
#include <iostream>
#include<fstream>
#include<stdlib.h>
using namespace std;
ifstream f("date8.in");
int suma(int n)
{ if (n==0) return 0;
  else return suma(n-1)+n*(n+1);
}
int n;
int main()
{
    f>>n;
    cout<<"Suma este: "<<suma(n);
    cout<<endl;
    system("pause");
    return 0;
}
