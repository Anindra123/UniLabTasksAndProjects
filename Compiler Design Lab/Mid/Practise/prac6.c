#include<stdio.h>
#include<string.h>
#include<stdlib.h>

void RemoveComments(char *str, char *out){
int len = strlen(str);
char output[5000];
int pointer = 0;

for(int i=0;i<len;i++){
    if(str[i] == '/'){
        if(str[i+1] == '/'){
            while(str[i] != '\n'){
                i++;
            }
        }
        else if(str[i+1] == '*'){
            while(1){
                i++;
                if(str[i] == '*' && str[i+1] == '/'){
                    break;
                }
            }
        }
    }
    else{
        output[pointer] = str[i];
        pointer++;
    }
}
output[pointer] = '\0';

if(pointer > 0){
    strcpy(out,output);
}
}


int main(){
FILE *frp;
frp = fopen("test.txt","r");
char data[5000];
if(frp == NULL){
    printf("Error!");
    return 1;
}
fseek(frp,0,SEEK_END);
long sz = ftell(frp);
printf("%d",sz);
fseek(frp,0,SEEK_SET);
char output[sz];
while(fgets(data,5000,frp) != NULL){
    RemoveComments(data,output);
}
printf(output);
fclose(frp);
return 0;
}
