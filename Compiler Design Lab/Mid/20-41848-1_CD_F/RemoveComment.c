#include<stdio.h>
#include<string.h>


int main(){

char str[1000] = " int a = b+c;//this is a single line comment\n/*this is a multiline comment*/ ";
int length = strlen(str);
char output[500];
int count = 0;
printf("Code :\n");
printf("%s",str);
for(int i=0;i<length;i++){
    if(str[i] == '/'){
        if(str[i+1] == '/'){
            while(str[i] !='\n'){
                str[i] = '\0';
                i++;
            }

        }
        else if(str[i+1] == '*'){
            while(1){
                str[i] = 0;
                i++;
                if(str[i] == '*' && str[i+1] == '/'){
                    break;
                }
            }

        }
    }
    else{
        output[count] = str[i];
        count++;
    }
}
output[count] = '\0';
strcpy(str,output);
printf("\nOutput :\n");
printf("%s",str);

}
