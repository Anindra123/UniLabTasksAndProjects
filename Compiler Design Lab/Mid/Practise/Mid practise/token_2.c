#include<stdio.h>
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<stdbool.h>
#include<ctype.h>
bool IsOperator(char ch){

    if(ch == '+' || ch == '-' || ch == '*' ||
        ch == '/' || ch == '>' || ch == '<' ||
        ch == '='){
            return true;
        }
    return false;

}


bool isKeyword(char *str){
char keywords[33][10] = {"auto","break","case","char","const","continue","default",
    "do","double","else","enum","extern","float","for","goto",
    "if","int","long","register","return","short","signed",
    "sizeof","static","struct","switch","typedef","union",
    "unsigned","void","volatile","while","main"};

for(int i=0;i<33;i++){
    if(strcmp(str,keywords[i]) == 0){
        return true;
    }
}
return false;
}

bool isValidIdentifier(char *str){
int flag = 0;
if((str[0] >= 'a' && str[0] <= 'z')|| (str[0] >='A' && str[0] <= 'Z')
   || str[0] == '_' || str[0] == '$'){
    return true;
}else{
    return false;
}
int len = strlen(str);
for(int i=1;i<len;i++){
    if((str[i] >= 'a' && str[i] <= 'z')|| (str[i] >='A' && str[i] <= 'Z')
        || str[i] == '_' || str[i] == '$' || (str[i]>='0' && str[i] <='9')){
        flag = 1;
    }else{
        flag = 0;
        break;
    }
}
if(flag == 1){
    return true;
}
return false;
}



int main(){
FILE *frp;
char data[500];
char buf[15];
int idx = 0;
frp = fopen("Code.txt","r");
if(frp == NULL){
    printf("Error !\n");
    exit(-1);
}
while(!feof(frp)){
    char c = fgetc(frp);
    if(IsOperator(c)){
        printf("%c is an operator\n",c);
    }
    else if(isalnum(c)){
        buf[idx] = c;
        idx++;
    }
    else if((c == ' ' || c == '\n' || c == ';') && idx != 0){
        buf[idx] = '\0';
        idx = 0;
        if(isKeyword(buf)){
            printf("%s is a keyword\n",buf);
        }else if(isValidIdentifier(buf)){
            printf("%s is a valid identifier\n",buf);
        }
        else{
            printf("%s is a invalid identifier\n",buf);

        }
    }


}

fclose(frp);
return 0;

}


