#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
    int A[21][21],n;
    cin>>n;
    int x=1;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=n;j++)
            { A[i][j]=n*x;
              x++;
            }
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=n;j++)
            cout<<A[i][j]<<" ";
        cout<<endl;
    }
    system("pause");
    return 0;
}
