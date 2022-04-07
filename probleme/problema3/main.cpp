#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
    int A[101][101],n;
    cin>>n;
    for(int i=1;i<=n;i++)
        for(int j=1;j<=n;j++)
            cin>>A[i][j];
            cout<<endl;
    for(int i=1;i<n;i++)
        for(int j=i+1;j<=n;j++)
            if(A[i][i]>A[j][j])
            {
                for(int k=1;k<=n;k++)
                {
                    int aux=A[i][k]; A[i][k]=A[j][k]; A[j][k]=aux;
                }
                for(int k=1;k<=n;k++)
                {
                    int aux=A[k][i]; A[k][i]=A[k][j]; A[k][j]=aux;
                }
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
