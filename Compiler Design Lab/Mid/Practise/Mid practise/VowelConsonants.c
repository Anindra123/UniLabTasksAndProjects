#include<stdio.h>
#include<stdio.h>
#include<string.h>
#include<stdlib.h>
#include<stdbool.h>
#include<ctype.h>

void VCCheck(char *str){
int v = 0,c=0;
int len = strlen(str);
for(int i=0;i<len;i++){
    if(str[i]  == 'e' || str[i] == 'E'
       || str[i] == 'a' || str[i] == 'A'
       || str[i] == 'i' || str[i] == 'I'
       || str[i] == 'o' || str[i] == 'O'
       || str[i] == 'u' || str[i] == 'U'
       )
       {
           printf("( %c )",str[i]);
        v++;
       }
    else if((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') )
        {
             printf(" %c ",str[i]);
        c++;
        }

}
printf("\nNumber of vowels : %d",v);
printf("\nNumber of consonants : %d",c);

}


int main(){
FILE *frp;
char data[500];
frp = fopen("Inpute.txt","r");
if(frp == NULL){
    printf("Error !");
    exit(-1);
}
fread(data,1,500,frp);
fclose(frp);
printf(data);
printf("\n");
VCCheck(data);

return 0;

}
