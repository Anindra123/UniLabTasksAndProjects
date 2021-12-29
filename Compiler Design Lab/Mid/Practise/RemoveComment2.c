#include <stdbool.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

void RemoveComment(char *str){
int len = strlen(str), j =0;
char output[len];
bool single = false, multiple = false;
for(int i=0;i<len;i++){
    if(str[i] == '/' && str[i+1] == '/'){
        single = true;
        i++;
    }else if(str[i] == '/' && str[i+1] == '*'){
        multiple = true;
        i++;
    }
    else if(single == true && str[i] == '\n'){
        single = false;
    }
    else if(multiple == true && str[i] == '*' && str[i+1] == '/'){
        multiple = false;
        i++;
    }
    else if(single || multiple){
        continue;
    }
    else{
        output[j] = str[i];
        j++;
    }
}
output[j] = '\0';
printf("After removing comment :");
if(j>0){
    printf("%s",output);
}

}


int main(){

char *inputcode;

FILE *frp = fopen("input.c","r");

if(frp == NULL){
    printf("Error !");
    return 1;
}

fseek(frp,0,SEEK_END);
long sz = sizeof(char) * ftell(frp);
fseek(frp,0,SEEK_SET);
inputcode = (char*) malloc(sz+1);

fread(inputcode,1,sz+1,frp);
inputcode[sz] = '\0';
fclose(frp);
printf("Before removing comment :");
printf("%s",inputcode);

RemoveComment(inputcode);
return 0;
}

