#include<stdio.h>
#include<string.h>
#include<stdlib.h>
const char *RemoveComment(char *str){
char output[strlen(str)];
int point = 0;
for(int i=0;i<strlen(str);i++){
    if(str[i] == '/' ){
        if(str[i+1] == '/'){
            while(str[i]!= '\n'){
                i++;
            }
        }else if(str[i+1] == '*'){
            i++;
            while(str[i] != '*' && str[i+1] !='/'){
                i++;
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
char data[5000];

fp = fopen("Code.txt","r");
if(fp == NULL){
    printf("Error!");
    return 1;
}
fseek(fp,0L,SEEK_END);
long sz = ftell(fp);
fseek(fp,0L,SEEK_SET);
char *output = malloc(sizeof(char) * sz);
strcpy(output,"");
while(fgets(data,5000,fp)!= NULL){
    int len = strlen(RemoveComment(data));
    if(len > 0){
      strcat(output,RemoveComment(data));
    }
}
fclose(fp);
fp = fopen("Code.txt","w+");
if(fp == NULL){
    printf("Error!");
    return 1;
}
fputs(output,fp);
////fputs(output,fp);
fclose(fp);

return 0;
}
