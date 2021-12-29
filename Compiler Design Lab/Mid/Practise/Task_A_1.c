#include<stdio.h>



int main(){

int numberArray[10] = {1,2,3,4,5,6,7,8,9,10};
printf("Normal order : ");
for(int i=0;i<10;i++){
    printf("%d ",numberArray[i]);
}
printf("\n");
printf("Reverse order : ");
for(int i=9;i>=0;i--){
    printf("%d ",numberArray[i]);
}
}
