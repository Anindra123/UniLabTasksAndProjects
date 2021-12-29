#include<stdio.h>


void GetNumOfOddAndEven(int numberArray[],int arraySize){
int odd =0;
int even = 0;
for(int i=0;i<arraySize;i++){
    if(numberArray[i] % 2 == 0){
        even++;
    }else{
        odd++;
    }
}
printf("Number of even : %d \n",even);
printf("Number of odd : %d \n",odd);

}

int main(){
int sizeOfArray;
printf("Enter the number of values to store : ");
scanf("%d",&sizeOfArray);
int numsArray[sizeOfArray];
for(int i=0;i<sizeOfArray;i++){
    printf("Enter value of num %d :",i+1);
    scanf("%d",&numsArray[i]);
}
GetNumOfOddAndEven(numsArray,sizeOfArray);
return 0;
}
