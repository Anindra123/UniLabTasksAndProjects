#include <stdbool.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include<ctype.h>




bool isOperator(char ch)
{
    if (ch == '+' || ch == '-' || ch == '*' ||
        ch == '/' || ch == '>' || ch == '<' ||
        ch == '=' || ch == '%')
        return (true);
    return (false);
}
bool validOperator(char ch){

    if(ch == '+' || ch == '-'){
        return true;
        }
    return false;

}
bool checkParenthesis(char *str){

int length = strlen(str);
int pointer = 0;
for(int i=0;i<length;i++){
    if(str[i] == '('){
        pointer++;
    }
    if(str[i] == ')'){
        pointer--;
    }
    if(pointer < 0 ){
        return false;
    }


}
if(pointer == 0){
    return true;
}else if(pointer > 0){
   return false;
}

}


bool isValidIdentifier(char *str){

if(!((str[0] >= 'a' && str[0] <= 'z')|| (str[0] >='A' && str[0] <= 'Z')
   || str[0] == '_' || str[0] == '$')){

    return false;
}
int len = strlen(str);
for(int i=1;i<len;i++){
    if(!((str[i] >= 'a' && str[i] <= 'z')|| (str[i] >='A' && str[i] <= 'Z')
        || str[i] == '_' || str[i] == '$' || (str[i]>='0' && str[i] <='9'))){
        return false;
    }
}

return true;
}
bool validOperand(char *str){
if(isValidIdentifier(str)){
    return true;
}
int len =strlen(str);
int flag = 0;
for(int i=0;i<len;i++){
    if(!(str[i] >= '0' && str[i] <='9') ){
        flag = 1;
    }
}
if(flag == 0){
return true;
}
return false;
}

bool CheckValidMathExp(char *str){
int flag = 0;
int len = strlen(str);
char buf[50];
int idx=0;
if(!checkParenthesis(str)){
    flag = 1;
}
else if(isOperator(str[0]) && !validOperator(str[0])){
    flag = 1;
}
else if(isOperator(str[len-1])){
    flag = 1;
}
else if(!isOperator(str[0])){

    for(int i=0;i<len;i++){
       if(str[i] == ' ' && isalnum(str[i-1]) && isalnum(str[i+1])){
        flag = 1;
       }
       else if(str[i] == '(' || str[i] == ')' || str[i] == ' ' || str[i] == ','){
        continue;
       }
       else if(!isOperator(str[i])){
        buf[idx++] = str[i];
       }else{
        buf[idx] = '\0';
        if(!validOperand(buf)){
            flag  = 1;
        }
        idx = 0;
       }
    }
    if(idx > 0){
        buf[idx] = '\0';
        if(!validOperand(buf)){
            flag = 1;
        }
        idx = 0;
    }
    for(int i=0;i<len;i++){
        if(isOperator(str[i]) && isOperator(str[i+1])){
            flag = 1;
        }
    }


}
if(flag == 0){
    return true;
}
return false;
}


int main(){
char exp[10][20] = { "ab - bc_1 * 57","ab - 1bc * 57x","+ ab - bc_1 * 57","% ab - bc_1 * 57","ab - bc_1 * 57 +",
"(ab - (bc_1 * 57))","(ab - (bc_1 * 57)","ab - )bc_1 * 57)","ab -* bc_1 * 57","ab bc_1 * 57)"};



for(int i=0;i<10;i++){

if(CheckValidMathExp(exp[i])){
    printf("%s....Valid Expression\n",exp[i]);
}else{
    printf("%s....Invalid Expression\n",exp[i]);

}

}

}
