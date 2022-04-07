#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
    int n,a,b,A[101][101];
    cin>>n>>a>>b;
    for(int i=1;i<=n;i++)
       for(int j=1;j<=n;j++)
       {
           if(i%2==1) A[i][j]=j*a;
           else A[i][j]=j*b;
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
