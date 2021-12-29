#include<stdio.h>


int main(){
FILE *frp;
frp = fopen("Code.txt","w+");
if(frp == NULL){

    printf("Error!");
    return -1;
}
fputs("Goodbye world",frp);
fseek(frp,0,SEEK_END);
fputs("Hello world",frp);
fclose(frp);

}
