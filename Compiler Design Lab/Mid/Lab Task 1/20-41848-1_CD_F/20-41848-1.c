#include<stdio.h>
#include<string.h>



int checkIfKeyword(char *c){

char keyword[32][10]={
      "auto","double","int","struct","break","else","long",
      "switch","case","enum","register","typedef","char",
      "extern","return","union","const","float","short",
      "unsigned","continue","for","signed","void","default",
      "goto","sizeof","voltile","do","if","static","while"
   };
for(int i=0;i<32;i++){
    if(strcmp(c,keyword[i]) == 0){
       return 1;
    }
}
return 0;

}

int checkIfIdentifier(char *c){
int lengthOfString;
if(!((c[0] >= 'a' && c[0]  <= 'z')||(c[0] >='A' && c[0]  <='Z') || (c[0] =='_') || (c[0] =='$'))){

return 0;

}

lengthOfString = strlen(c);

for(int i=1;i<lengthOfString;i++){
    if(!((c[i] >= 'a' && c[i]  <= 'z')|| (c[i] >='A' && c[i]  <='Z') || (c[i] =='_') || (c[i] =='$') ||(c[i]  >= '0' && c[i] <='9') )){

    return 0;

    }
}
return 1;

}

int CheckIfOperator(char *c){
char operators[10][5] = {"*","-","=","+","/",">=","<="};

for(int i = 0;i<10;i++){
    if(strcmp(c,operators[i]) == 0){
        return 1;
    }
}
return 0;

}


int main(){

char inputString[20] = "int a = b + 1c";
char *token = strtok(inputString," ");


while(token != NULL){
    if(checkIfKeyword(token)){
        printf("%s | Keyword\n",token);
    }else{
        printf("%s |Not a Keyword\n",token);

    }
    if(CheckIfOperator(token) && !checkIfIdentifier(token) && !checkIfKeyword(token)){
        printf("%s | Operator\n",token);

    }else{
         printf("%s |Not an Operator\n",token);
    }

    if(checkIfIdentifier(token) && !checkIfKeyword(token) && !CheckIfOperator(token)){
        printf("%s | Identifier\n",token);
    }else{
         printf("%s |Invalid Identifier\n",token);
    }
    token = strtok(NULL," ");
}

printf("\nWith file read write.....\n");
FILE *fileWritePointer;
fileWritePointer = fopen("20-41848-1.txt","w");
if(fileWritePointer == NULL){
    printf("Error !");
    return 1;
}
fprintf(fileWritePointer,"int a = b + 1c");
fclose(fileWritePointer);
char data[500];
FILE * fileReadPointer;
fileReadPointer = fopen("20-41848-1.txt","r");
if(fileReadPointer == NULL){
    printf("Error !");
    return 1;
}
while(fgets(data,500,fileReadPointer) != NULL){
    printf("%s\n\n",data);
}
fclose(fileReadPointer);

char *token2 = strtok(data," ");
while(token2 != NULL){
   if(checkIfKeyword(token2)){
        printf("%s | Keyword\n",token2);
    }else{
        printf("%s |Not a Keyword\n",token2);

    }
    if(CheckIfOperator(token2) && !checkIfIdentifier(token2) && !checkIfKeyword(token2)){
        printf("%s | Operator\n",token2);

    }else{
         printf("%s |Not an Operator\n",token2);
    }

    if(checkIfIdentifier(token2) && !checkIfKeyword(token2) && !CheckIfOperator(token2)){
        printf("%s | Identifier\n",token2);
    }else{
         printf("%s |Invalid Identifier\n",token2);
    }
    token2 = strtok(NULL," ");
}
return 0;


}
