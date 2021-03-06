/*O harta este data intr-o matrice n*m in care valorile 1
reprezinta uscatul, iar valorile 0 reprezinta apa. Doua zone
de uscat se considera ca fac parte din acelasi continent
daca sunt vecine pe linie sau pe coloana. Determinati
numarul de continente de pe harta si care este aria (numarul
de valori de 1) maxima dintre ariile continentelor.
Exemplu:
harta.in
6 6
1 1 1 0 1 0
0 0 1 0 1 1
1 1 1 0 0 0
0 1 0 1 1 1
0 0 0 1 1 1
1 1 0 0 0 0
harta.out
4 (numarul de continente)
8 (aria continentului din stanga-sus)*/
#include<fstream>
#include<stdlib.h>
#include<iostream>
using namespace std;
ifstream fin("harta.in");
int a[102][102];
void fill(int a[102][102], int n, int m, int i, int j, int c)
{
    a[i][j]=c;
    if(a[i-1][j]==1) fill(a,n,m,i-1,j,c);//sus
    if(a[i][j+1]==1) fill(a,n,m,i,j+1,c);//dreapta
    if(a[i+1][j]==1) fill(a,n,m,i+1,j,c);//jos
    if(a[i][j-1]==1) fill(a,n,m,i,j-1,c);//stanga
}

int main()
{
    int n,m,c=0;
    fin>>n>>m;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=m;j++)
            fin>>a[i][j];
    for(int i=1;i<=n;i++)
        for(int j=1;j<=m;j++)
            if(a[i][j]==1)
            {
                c++;
                fill(a,n,m,i,j,c+1);
            }
    /*for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++) cout<<a[i][j]<<" ";
            cout<<endl;
        }*/
    cout<<"Numarul de continente: "<<c<<endl;
    int max=0;
    for(int cul=2;cul<=c+1;cul++)
    {
        int s=0;
        for(int i=1;i<=n;i++)
            for(int j=1;j<=m;j++)
                if(a[i][j]==cul) s++;
        if(s>max)  max=s;
    }
    cout<<"Aria continentului din stanga-sus: "<<max;
    cout<<endl;
    fin.close();
    system("pause");
    return 0;
}
