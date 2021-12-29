#include<stdio.h>
#include<string.h>

int CheckIfKeyWord(char input[]){
char inputcpy[50];
strcpy(inputcpy,input);
char keyword[32][10]={
 "auto","double","int","struct","break","else","long",
 "switch","case","enum","register","typedef","char",
 "extern","return","union","const","float","short",
 "unsigned","continue","for","signed","void","default",
 "goto","sizeof","voltile","do","if","static","while"
 };

 for(int i=0;i<32;i++){
    if(strcmp(input,keyword[i]) == 0){
        return 1;
    }
 }
return 0;
}
int CheckIfOperator(char input[]){
char inputcpy[50];
strcpy(inputcpy,input);
char operators[11][5] = {
    "+","-","/","*","||","&&",">","<",">=","<=","="
    };
for(int i=0;i<11;i++){
    if(strcmp(input,operators[i]) == 0){
        return 1;
    }
}
return 0;
}
void CheckIfEndofString(char *input){
char inputcopy[50];
strcpy(inputcopy,input);
if(input[strlen(input)-1] == ';'){
    strtok(inputcopy,";");
}

}

void CheckIfIdentifier(char input[]){
if(CheckIfKeyWord(input)|| CheckIfOperator(input)){
    return;
}


char inputCpy[50];
strcpy(inputCpy,input);
int flag = 0;

if((input[0] >= 'a' && input[0] <= 'z') ||
    (input[0] >= 'A' && input[0] <= 'Z') ||
    (input[0] == '_') || (input[0] == '$')
   )
{

    flag = 1;
}

int lengthofInput = strlen(input);

for(int i=1;i<lengthofInput;i++){
    if((input[i] >= 'a' && input[i] <= 'z') ||
    (input[i] >= 'A' && input[i] <= 'Z') ||
    (input[i] == '_') || (input[i] == '$') ||
       (input[i] >=0 && input[i]<='9')){
        flag = 1;

       }
    else{
        flag = 0;
        break;
    }
}
if(flag == 1){
     printf(strcat(inputCpy,"| Valid Identifier\n"));
}else{
    printf(strcat(inputCpy," | Invalid Identifier\n"));
}
}

void CheckIfComment(char *input){
char *output;
if(input[0] == '/' && input[1] == '/'){
    printf("%s\n",input);
}

}


int main(){

FILE *frp;
char data[500];
char *token;
frp = fopen("Token.txt","r");

if(frp == NULL){
    printf("Error!");
    return(-1);
}

if(fgets(data,500,frp) != NULL){
    token = strtok(data," ");
}
while(token[0] != '/' && token[1] != '/'){
    if(CheckIfKeyWord(token)){
        printf("%s | keyword \n",token);
    }
    if(CheckIfOperator(token)){
        printf("%s | operator \n",token);
    }
    CheckIfIdentifier(token);

    token = strtok(NULL," ");
}
for(int i=0;i<strlen(token);i++){
    printf("%c",token[i]);

}
}
