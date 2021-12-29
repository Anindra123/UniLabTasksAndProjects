#include<stdio.h>
#include<string.h>
void printVowelConsontant(char *str){
int vol =0, cons =0;
int len = strlen(str);
for(int i=0;i<len;i++){
    if(!(str[i] >= 'a' && str[i] <= 'z') && !(str[i] >= 'A' && str[i] <= 'Z')){
        continue;
    }
    if(str[i] == 'a' || str[i] == 'A' ||
       str[i] == 'e' || str[i] == 'E' ||
       str[i] == 'i' || str[i] == 'I' ||
       str[i] == 'o' || str[i] == 'O'||
       str[i] == 'u' || str[i] == 'U')
    {
        printf("( %c )",str[i]);
        vol++;
    }else{
        printf(" %c ",str[i]);
        cons++;
    }

}
printf("\nVowels : %d",vol);
printf("\nConsonants : %d",cons);

}



int main(){

FILE *fp;

fp = fopen("vowelConsonant.txt","w");

if(fp == NULL){
    printf("Error !");
    return 1;
}

fputs("Anindra Das Bivas",fp);
fclose(fp);
FILE *frp;
char data[500];
frp = fopen("vowelConsonant.txt","r");
if(frp == NULL){
    printf("Error !");
    return 1;
}
if(fgets(data,500,frp)!= NULL){
    printVowelConsontant(data);
}
fclose(frp);

return 0;


}
