#include <stdbool.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>


int main(){


FILE *frp;
char data[500];
frp = fopen("vowelConsonant.txt","r");
if(frp == NULL){
    printf("Error !");
    exit(-1);
}
int vol=0,cons=0;
while(!(fgets(data,500,frp) == NULL))
{
    printf("%s",data);
}
printf("\n\n");
fseek(frp,0,SEEK_SET);
while(!feof(frp)){
    char c = fgetc(frp);
    if(c == 'A' || c== 'a' || c=='E' || c=='e' ||
        c == 'O' || c=='o' || c == 'i' || c == 'I'
        || c=='U' || c=='u'
       ){
        printf("( %c )",c);
        vol++;
       }
    else if((c>='a' && c<='z') || (c>='A' && c<='Z')){
        printf(" %c ",c);
        cons++;
    }
}
printf("\nNumber of vowels : %d\nNumber of consonants: %d\n",vol,cons);
fclose(frp);
return 0;
}
