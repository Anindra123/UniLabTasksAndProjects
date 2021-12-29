#include<stdio.h>

void GetOddWithinRange(int num1,int num2){
printf("Odd number within range : \n");
for(int i=num1;i<=num2;i++){
    if(i%2 == 1){
        printf("%d ",i);
    }
}


}


int main(){

int firstNumValue = 0;
int secondNumValue = 0;
printf("Enter the first number : ");
scanf("%d",&firstNumValue);
printf("Enter the second number : ");
scanf("%d",&secondNumValue);
GetOddWithinRange(firstNumValue,secondNumValue);

return 0;
}
