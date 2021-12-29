#include <stdbool.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>

bool capital(char ch){
if(ch >='A' && ch<='Z'){
    return true;
}
return false;
}

bool small(char ch){
if(ch >='a' && ch<='z'){
    return true;
}
return false;
}


int main(){
char exp[500];
printf("Enter a senetence :");
gets(exp);
int flag = 0;
int len = strlen(exp);

if(!capital(exp[0]) || !exp[len-1] != '.' ){
    flag = 1;
}

for(int i=0;i<len;i++){
    if(capital(exp[i]) && capital(exp[i+1])){
        flag = 1;
    }else if(exp[i] == ' ' && exp[i+1] == ' ' ){
        flag = 1;
    }else if(small(exp[i]) && capital(exp[i+1])){
        flag = 1;
    }else if(exp[len-1] == '.' && exp[len-2] == ' '){
        flag = 1;
    }

}
if(flag == 0){
    printf("%s sentence is grammatically correct",exp);

}else{
    printf("%s sentence is grammatically incorrect",exp);

}



}
