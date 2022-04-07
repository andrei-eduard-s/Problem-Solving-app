#include <iostream>
#include <fstream>
#include <stdlib.h>
using namespace std;

int main()
{    ifstream f("date.in");
    int a[101][101],n;
    f>>n;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=n;j++)
            f>>a[i][j];
    for(int i=1;i<2*n;i++)
        for(int j=1;j<=i;j++)
            if(i+1-j<=n && j<=n)
            if(i%2==0)
            cout<<a[i+1-j][j]<<" ";
            else
                cout<<a[j][i+1-j]<<" ";
                f.close();
                system("pause");
    return 0;
}
