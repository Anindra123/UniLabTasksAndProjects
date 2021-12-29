#include<stdio.h>
#include<string.h>
#include<stdlib.h>

int CheckKeyword(char *str){
char str2[strlen(str)];
strcpy(str2,str);
char keyword[32][10]={
 "auto","double","int","struct","break","else","long",
 "switch","case","enum","register","typedef","char",
 "extern","return","union","const","float","short",
 "unsigned","continue","for","signed","void","default",
 "goto","sizeof","voltile","do","if","static","while"
};
for(int i=0;i<32;i++){
   if(strcmp(str,keyword[i]) == 0){
    printf("%s = Keyword \n",str2);
    return 1;
   }
}
return 0;
}

int CheckOperator(char *str){
char str2[strlen(str)];
strcpy(str2,str);
char opList[20][3] = {"+","-","=","/","*","%","<=",">=","<",">"};
for(int i=0;i<20;i++){
    if(strcmp(str,opList[i]) == 0){
        printf("%s = Operator \n",str2);
        return 1;
    }

}
return 0;
}

void CheckIdentifier(char *str){
char str2[strlen(str)];
strcpy(str2,str);
if(CheckOperator(str) || CheckKeyword(str)){
    return;
}
int flag = 0;
if((str[0] >= 'a' && str[0] <='z') ||
    (str[0] >= 'A' && str[0] <='Z') ||
    str[0] == '_' || str[0] == '$'
    )
    {
        flag = 1;
    }

int len = strlen(str);
if(len > 0){
    for(int i=1;i<len;i++){
    if((str[0] >= 'a' && str[0] <='z') ||
    (str[0] >= 'A' && str[0] <='Z') ||
    str[0] == '_' || str[0] == '$'
    || (str[0] >= '0' && str[0] <= '9')){
        flag = 1;
    }else{
        flag = 0;
        break;
    }
    }
}
if(flag == 1){
    printf("%s = Valid Identifier\n",str2);
}else{
    printf("%s = Invalid Identifier\n",str2);
}
}

char *RemoveComment(char *str){
char output[strlen(str)];
int point = 0;
for(int i=0;i<strlen(str);i++){
    if(str[i] == '\n'){
        continue;
    }
    if(str[i] == '/' ){
        if(str[i+1] == '/'){
            while(str[i]!= '\n'){
                i++;
            }
        }
        if(str[i+1] == '*'){
            while(1){
                i++;
                if(str[i] == '*' && str[i+1] == '/'){
                    break;
                }
            }
        }
    }else{
        output[point] = str[i];
        point++;
    }

}
output[point] = '\0';
strcpy(str,output);
return str;

}

int main(){

FILE *fp;
fp = fopen("Code.txt","r");
if(fp == NULL){
    printf("Error!");
    return 1;
}
fseek(fp,0L,SEEK_END);
long sz = ftell(fp);
fseek(fp,0L,SEEK_SET);
long len = sizeof(char) * sz;
char *output = malloc(len);
char *data = malloc(len);
strcpy(output,"");
while(fgets(data,len,fp)!= NULL){
      strcat(output,data);
}
char *token = strtok(RemoveComment(output)," ");
while(token != NULL){
    CheckIdentifier(token);
    token = strtok(NULL," ");
}
fclose(fp);
free(output);
free(data);
return 0;
}
