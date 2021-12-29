#include<stdio.h>
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<stdbool.h>
#include<ctype.h>


bool isCapital(char c){

if(c>='A' && c <='Z'){
    return true;
}
return false;
}

bool isSmall(char c){

if(c>='a' && c <='z'){
    return true;
}
return false;
}


bool CheckValidSen(char *str){

int len = strlen(str);
int flag = 0;

if(!isCapital(str[0]) || str[len-1] != '.' ){
    return false;
}
for(int i = 0;i<len;i++){
    if(str[i] == ' ' && str[i+1] == ' '){
        flag = 1;
    }
    else if(isCapital(str[i]) && isCapital(str[i+1])){
        flag = 1;
    }
    else if(isSmall(str[i]) && isCapital(str[i+1])){
        flag = 1;
    }
    else if(str[len-1] == '.' && str[len-2] == ' '){
        flag = 1;
    }
}
if(flag == 1){
    return false;
}
return true;
}


int main(){
char input[6][50] = {"this is a sentence.","This is another sentence","Hello  World.","Hello WOrld.","Hello wOrld.","Hello world."};


for(int i=0;i<6;i++){
    if(CheckValidSen(input[i])){
        printf("%s is grammatically correct\n",input[i]);
    }else{
        printf("%s is grammatically incorrect\n",input[i]);

    }
}

}
