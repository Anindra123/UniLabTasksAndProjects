#include<stdio.h>
#include<string.h>
void CheckVowelAndConsonants(char *str){
int vol = 0,cons = 0;
int len = strlen(str);
for(int i =0;i<len;i++){
    if(!(str[i] >= 'a' && str[i] <='z') && !(str[i] >='A' && str[i] <= 'Z')){
        continue;
    }
    if(str[i] == 'a' || str[i] == 'A'
       || str[i] == 'e' || str[i] == 'E'
       || str[i] == 'i' || str[i] == 'I'
       || str[i] == 'o' || str[i] == 'O'
       || str[i] == 'u' || str[i] == 'U'
       ){
        vol++;
        printf(" (%c) ",str[i]);
       }
    else{
        cons++;
        printf(" %c ",str[i]);
    }

}
  printf("\n");
printf("Vowels : %d\n",vol);
printf("Consonants : %d\n",cons);
}

int main(){
FILE *frp;
char data[500];
frp = fopen("test.txt","r");

if(frp == NULL){
    printf("Error!");
    return 1;
}

while(fgets(data,500,frp) != NULL){
    CheckVowelAndConsonants(data);
}

fclose(frp);
return 0;




}
