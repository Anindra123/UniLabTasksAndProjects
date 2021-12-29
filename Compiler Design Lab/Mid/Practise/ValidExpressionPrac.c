#include<stdio.h>
#include<string.h>
#define MAX 100


char arr[MAX];


int pointer = -1;

int checkEmpty(){
if(pointer == -1){
    return 1;
}
return 0;
}


void push(char c){
pointer++;
arr[pointer] = c;
}

void pop(){
if(!checkEmpty()){
    pointer--;
}

}
char checkTop(){
if(!checkEmpty()){
    return arr[pointer];
}
else{
    return '\0';
}
}

int main(){
char str[50] = "((*c(d+e)";
int len = strlen(str);
for(int i=0;i <len;i++){
    if(str[i] == '('){
        push(str[i]);
    }
    if(str[i] == ')'){
        if(checkTop() == '('){
            pop();
        }else{
            push('(');
        }
    }
}
if(!checkEmpty()){
    printf("Invalid Expression \n");
}else{
    printf("Valid Expression \n");
}
}
