#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{ int n,i,j,a[101][101];
cin>>n;
for (i=1;i<=n;i++)
for (j=1;j<=n;j++)
{
   cin>>a[i][j];
}

for (i=0;i<=n+1;i++)
  a[0][i]=a[n+1][i]=a[i][0]=a[i][n+1]=999999999;

for (i=1;i<=n;i++)
   for (j=1;j<=n;j++)
     if (a[i][j]<a[i][j-1]&& a[i][j]<a[i-1][j]&& a[i][j]<a[i][j+1]&& a[i][j]<a[i+1][j])
       cout<<a[i][j]<<" ";
system("pause");
   return 0;
}
