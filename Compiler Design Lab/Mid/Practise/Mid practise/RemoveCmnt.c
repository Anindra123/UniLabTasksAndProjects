#include<stdio.h>
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<stdbool.h>
#include<ctype.h>




void RmvCmnt(char *str){
int len = strlen(str);
char buf[len];
int idx = 0;
bool s = false,m = false;
for(int i=0;i<len;i++){
    if(str[i] == '/' && str[i+1] == '/'){
        s = true;
        i++;
    }
    else if(str[i] == '/' && str[i+1] == '*'){
        m = true;
        i++;
    }
    else if(str[i] == '\n' && s == true){
        s = false;
    }
    else if((str[i] == '*' && str[i+1] == '/') && m == true){
        m = false;
        i++;
    }
    else if(s || m){
        continue;
    }
    else{
        buf[idx] = str[i];
        idx++;
    }
}

buf[idx] = '\0';
printf("\nAfter removing comment :\n");
if(idx > 0){
    printf("%s",buf);
}


}



int main(){


FILE *frp;
char *data;
frp = fopen("input.c","r");
if(frp == NULL){
    printf("Error!");
    exit(-1);
}
fseek(frp,0,SEEK_END);
long sz = sizeof(char) * ftell(frp);
fseek(frp,0,SEEK_SET);
data = malloc(sz);

fread(data,1,sz,frp);
fclose(frp);
printf("Before removing comment :\n");
printf("%s",data);
RmvCmnt(data);

return 0;
}
