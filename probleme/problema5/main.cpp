#include<fstream>
#include<iostream>
#include <stdlib.h>
using namespace std;
ifstream fin("f.in");

int main()
{ int a[10][10],n,i,j;
  fin>>n;
  for(i=1;i<=n;i++)
	for(j=1;j<=n;j++)
		a[i][j]=(i+j+1)%2;

  for(i=1;i<=n;i++)
  { for(j=1;j<=n;j++)
	cout<<a[i][j]<<" ";
    cout<<endl;
  }

  fin.close();
system("pause");
  return 0;
}
