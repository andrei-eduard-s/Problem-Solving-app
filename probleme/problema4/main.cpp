#include<fstream>
#include<iostream>
#include <stdlib.h>
using namespace std;
ifstream fin("f.in");

int main()
{
	int a[10][10],n,m,i,j,k;
	fin>>n>>m;
	for(i=1;i<=n;i++)
		for(j=1;j<=m;j++)
			fin>>a[i][j];
	for(k=2;k<=n+1;k++)
	{
		n++;
		for(i=n;i>=k+1;i--)
			for(j=1;j<=m;j++)
				a[i][j]=a[i-1][j];
		for(j=1;j<=m;j++) a[k][j]=a[k-1][m+1-j];
		k++;
	}

	for(i=1;i<=n;i++)
	{
		for(j=1;j<=m;j++)
			cout<<a[i][j]<<" ";
		cout<<endl;
	}
	fin.close();
system("pause");
	return 0;
}
