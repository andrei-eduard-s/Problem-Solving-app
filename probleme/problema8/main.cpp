#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
    int n,A[11][11];
    cin>>n;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=n+1-i;j++)
            A[i][j]=A[n+1-j][n+1-i]=n+1-i-j+1;
    for(int i=1;i<=n;i++)
    {
        for(int j=1;j<=n;j++)
            cout<<A[i][j]<<" ";
        cout<<endl;
    }
    system("pause");
    return 0;
}
