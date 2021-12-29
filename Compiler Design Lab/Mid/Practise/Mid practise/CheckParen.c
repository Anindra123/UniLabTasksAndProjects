#include<stdio.h>
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<stdbool.h>
#include<ctype.h>


bool CheckParen(char *str){
int flag = 0;
int pointer = 0;
int len = strlen(str);
for(int i=0;i<len;i++){
    if(str[i] == '('){
            pointer++;
    }if(str[i] == ')'){
        pointer--;
    }
    if(pointer < 0){
        flag = 1;
    }
}
if(flag == 0 && pointer == 0){
    return true;
}
return false;

}


int main(){
char input[10][50] = { "((a+b",")a+b(","(a+b)",")","((a+b)+c)","((())c","((a+b)^c)","(a+(b^(c%d))"};
for(int i=0;i<10;i++){
    if(CheckParen(input[i])){
        printf("%s.....Expression is valid\n",input[i]);
    }else{
        printf("%s.....Expression is invalid\n",input[i]);

    }
}



}
