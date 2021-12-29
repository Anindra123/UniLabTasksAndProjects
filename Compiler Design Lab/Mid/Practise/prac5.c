#include<stdio.h>
#include<string.h>


void CheckIfValidExpression(char *str){
int len = strlen(str);
int pointer = 0;
for(int i=0;i<len;i++){
    if(str[i] == '('){
        pointer++;
    }
    else if(str[i] == ')'){
        pointer--;
    }
    if(pointer < 0){
        printf("Invalid Expression");
        break;
    }
}

if(pointer > 0){
    printf("Invalid Expression");

}
if(pointer == 0){
    printf("Valid Expression");

}

}


int main(){
char exp[500];
printf("Enter an expression : ");
gets(exp);
CheckIfValidExpression(exp);


}
