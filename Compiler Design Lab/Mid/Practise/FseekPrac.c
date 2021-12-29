#include<stdio.h>



int main(){
FILE *fp;


fp = fopen("FseekExample.txt","w+");

fputs("This is a C++ program",fp);

fseek(fp,10,SEEK_SET);

fputs("C program  ",fp);

fseek(fp,0,SEEK_SET);

fputs("Hello World",fp);

fclose(fp);

return(0);


}


