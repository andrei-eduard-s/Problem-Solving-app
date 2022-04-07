#include <fstream>
#include <iostream>
#include <stdlib.h>
using namespace std;
ifstream f("date.in");

int main()
{
    int n,m,a[100][100],ok;
    f>>n>>m;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=m;j++)
           f>>a[i][j];
    for(int i=1;i<=n;i++)
    {
        ok=1;
        for(int j=2;j<m;j++)
            if(a[i][j-1]<=a[i][j] && a[i][j]>=a[i][j+1] || a[i][j-1]>=a[i][j] && a[i][j]<=a[i][j+1])
              ok=0;
        if(!ok)
        {
            for(int k=i;k<n;k++)
                for(int j=1;j<=m;j++)
                  a[k][j]=a[k+1][j];
                   n--;
                    i--;
        }
    }
    for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++)
             cout<<a[i][j]<<" ";
               cout<<endl;
        }
    f.close();
    system("pause");
    return 0;
}
