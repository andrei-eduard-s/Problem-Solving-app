/*Se citeste un numar natural n (n<=20). Afisati un desen format din caracterul * ca in exemplul de mai jos. Se vor folosi exclusiv subprograme recursive.
Exemplu:
Pentru n=3 se afiseaza
  *
 ***
*****
 ***
  * */
#include <iostream>
#include <fstream>
#include<stdlib.h>
using namespace std;
ifstream f("date2.in");
void linie(int n, char c)
{
    if(n>0)
    {
        linie(n-1,c);
        cout<<c;
    }
}

void sus(int n, int r)
{
    if(r<=n)
    {
        linie(n-r,' ');
        linie(2*r-1,'*');
        cout<<endl;
        sus(n,r+1);
    }
}

void jos(int n, int r)
{
    if(r<=n)
    {
        jos(n,r+1);
        linie(n-r+1,' ');
        linie(2*r-1,'*');
        cout<<endl;
    }
}
int main()
{
    int n;
    f>>n;
    sus(n,1);
    jos(n-1,1);
    cout<<endl;
    system("pause");
    return 0;
}
