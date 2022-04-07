/*Sa se scrie o functie recursiva care primeste un parametru n numar natural si returneaza numarul obtinut din n prin scaderea cu 1 a cifrelor impare si marirea cu 1 a celor pare.
Ex. din n=2324 returneaza 3235*/
#include <iostream>
#include<fstream>
#include<stdlib.h>
using namespace std;
ifstream f("date9.in");
long schimba(long n)
{
    if(n==0) return 0;
    else if(n%2==1)
        return schimba(n/10)*10+n%10-1;
    else
        return schimba(n/10)*10+n%10+1;
}
int n;
int main()
{
    f>>n;
    cout<<"Numarul obtinut: "<<schimba(n);
    cout<<endl;
    system("pause");
    return 0;
}
