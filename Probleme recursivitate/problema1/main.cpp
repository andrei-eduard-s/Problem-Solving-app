/*Scrieti o functie recursiva care primeste ca paramentru un numar natural n si returneaza numarul obtinut din n prin eliminarea cifrelor impare.
Exemplu: daca n=234435, functia returna 244.*/
#include <iostream>
#include <fstream>
#include<stdlib.h>
using namespace std;
ifstream f("date1.in");
int stergimp(int n)
{
    if(n==0) return 0;
    else if(n%2==1) return stergimp(n/10);
         else return stergimp(n/10)*10+n%10;
}
int n;
int main()
{
    f>>n;
    cout<<stergimp(n);
    cout<<endl;
    system("pause");
    return 0;
}
