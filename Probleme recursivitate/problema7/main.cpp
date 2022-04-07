/*Sa se scrie o functie recursiva care numara cate vocale mici are un
cuvant transmis ca parametru.
*/
#include<iostream>
#include<fstream>
#include<string.h>
#include<stdlib.h>
using namespace std;
ifstream f("date7.in");
int vocale(char s[20])
{
	if(strlen(s)==0) return 0;
	else if(strchr("aeiou",s[0])) return 1 + vocale(s+1);
	     else return vocale(s+1);
}
char s[20];
int main()
{ f.get(s,20);
    cout<<"Numar vocale de mici: "<<vocale(s);
    cout<<endl;
    system("pause");
  return 0;
}
