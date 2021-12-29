#include<stdio.h>
#include<string.h>




int main(){

char str[500];
FILE *frp;
frp = fopen("20-41848-1.txt","r");
if(frp == NULL){
    printf("Error!");
    return 1;
}
while(fgets(str,500,frp)!= NULL){
    printf("String on the file : %s \n",str);
}

int vol = 0,cons = 0;

int length = strlen(str);

for(int i=0;i<length;i++){

    if(!(str[i] >= 'a' && str[i] <= 'z') && !(str[i] >='A' && str[i] <='Z') ){
        continue;
    }
    if(str[i] == 'A'||str[i]=='a'||str[i]== 'o'||str[i]=='O'
       ||str[i] == 'i' || str[i] == 'I' || str[i] == 'e' ||
       str[i] == 'E' || str[i] == 'U' || str[i] == 'u'
       )
    {
        printf("%c is a vowel\n",str[i]);
        vol++;
    }else{
        printf("%c is a consonant\n",str[i]);
        cons++;
    }
}
printf("%d number of vowels\n",vol);
printf("%d number of consonants\n",cons);
}
