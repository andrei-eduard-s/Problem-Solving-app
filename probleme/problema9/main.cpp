#include <iostream>
#include <stdlib.h>
using namespace std;

int main()
{
int a[10][10],m,n,i,j,mini;

cin>>m;

cin>>n;
for (i=1;i<=m;i++)
for (j=1;j<=n;j++)
{

cin>>a[i][j];
}
for (i=1;i<=m;i++)
{
mini=a[i][1];
for (j=2;j<=n;j++)
if (a[i][j]<mini)
mini=a[i][j];
cout<<endl;
cout<<mini<<" ";
}
system("pause");
return 0;
}
