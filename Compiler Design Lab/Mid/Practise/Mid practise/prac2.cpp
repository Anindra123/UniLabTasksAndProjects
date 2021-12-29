#include<iostream>
#include<fstream>
using namespace std;


int main(){

ifstream If("Code.txt");
string line;
while(getline(If,line,' ')){
    cout<<line<<endl;
}


}



