#include<iostream>
#include<fstream>
#include<sstream>

using namespace std;


int main(){
ifstream input("Split_Text.txt");

string line;

while(getline(input,line,' ')){
    cout<<line<<endl;
}

return 0;

}


