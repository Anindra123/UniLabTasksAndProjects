#include<stdio.h>
#include<string.h>


int main(){
char str2[500];
printf("Enter expression :");
gets(str2);
int length = strlen(str2);
int pointer = 0;
for(int i=0;i<length;i++){
    if(str2[i] == '('){
        pointer++;
    }
    if(str2[i] == ')'){
        pointer--;
    }
    if(pointer < 0 ){
        printf("Invalid Expression");
        break;
    }


}
if(pointer == 0){
    printf("Expression is valid");
}else if(pointer > 0){
    printf("Invalid Expression");
}
return 0;
}
