#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include<stdbool.h>
#include<ctype.h>
bool checkValidIdentifier(char *str){
int flag = 0;
if(!((str[0] >= 'a' && str[0] <='z') ||
   (str[0] >= 'A' && str[0] <= 'Z') ||
   (str[0] == '_') || (str[0] == '$')
   )){

     flag = 1;

   }

int len = strlen(str);
for(int i=0;i<len;i++){
    if(!((str[i] >= 'a' && str[i] <='z') ||
   (str[i] >= 'A' && str[i] <= 'Z') ||
   (str[i] == '_') || (str[i] == '$')||
    (str[i] >= '0' && str[i]<= '9')
    )){
    flag = 1;

    }
}
if(flag ==0){
    return true;
}
return false;
}

bool checkIFOperator(char c){
if(c == '%' || c == '+' || c == '=' || c == '-'
   || c == '*' || c == '/' || c == '>' || c == '<'
   )
    return true;
return false;
}

bool checkIFKeyword(char *str){

char keywords[5][50] = {"main","int","void","bool","return"};
for(int i=0;i<5;i++){
    if(strcmp(keywords[i],str) == 0){
        return true;
    }
}
return false;
}

const char* RemoveCmnt(char *str){
int len = strlen(str);
int idx = 0;
char buffer[len];
char *output = malloc(len);
bool single = false,multiple = false;
for(int i=0;i<len;i++){
    if(str[i] == '/' && str[i+1] == '/'){
        single = true;
        i++;
    }
    else if(str[i] == '/' && str[i+1] == '*'){
        multiple = true;
        i++;
    }
    else if(single == true && str[i] == '\n'){
        single = false;
    }
    else if(multiple == true && (str[i] == '*' && str[i+1] == '/')){
        multiple = false;
        i++;
    }else if(single || multiple){
        continue;
    }
    else{
        buffer[idx] = str[i];
        idx++;
    }
}
buffer[idx] = '\0';
strcpy(output,buffer);
return output;
}

void Tokenize(char *str){
char buffer[15];
int idx =0;
int len = strlen(str);
for(int i=0;i<len;i++){
    if(checkIFOperator(str[i])){
        printf("%c is a operator\n",str[i]);
    }
    if(isalnum(str[i])){
        buffer[idx] = str[i];
        idx++;
    }
    else if((str[i] == ' ' || str[i] == '\n' || str[i] == '{'
            || str[i] == '}' || str[i] == '(' || str[i] == ')'
            || str[i] == ';' ) && (idx != 0)
            )
    {

        buffer[idx] = '\0';
        idx = 0;
        if(checkIFKeyword(buffer)){
            printf("%s is a keyword\n",buffer);
        }else {
            if(checkValidIdentifier(buffer)){

             printf("%s is a valid identifier\n",buffer);
            }
            else{
             printf("%s is not a valid identifier\n",buffer);

            }
        }
    }
}

}


int main(){
FILE *frp;
frp = fopen("input.c","r");
if(frp == NULL){
    printf("Error !");
    exit(1);
}
char *data;
char *output;
fseek(frp,0,SEEK_END);
long sz = sizeof(char) * ftell(frp);
fseek(frp,0,SEEK_SET);
data = malloc(sz);
fread(data,1,sz,frp);
fclose(frp);
output = malloc(sz);
strcpy(output,RemoveCmnt(data));
Tokenize(output);


return 0;
}
