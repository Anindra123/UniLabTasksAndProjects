#include<stdio.h>
void GetMaxInArray(int numArray[],int sizeOfArray){

int maxVal = numArray[0];
for(int i=0;i<sizeOfArray;i++){
    if(numArray[i] > maxVal){
        maxVal = numArray[i];
    }

}
printf("Maximum value on the array is : %d \n",maxVal);

}


void GetMinInArray(int numArray[],int sizeOfArray){

int minVal = numArray[0];
for(int i=0;i<sizeOfArray;i++){
    if(numArray[i] < minVal){
        minVal = numArray[i];
    }

}
printf("Minimum value on the array is : %d \n",minVal);

}



int main(){
int arraySize;
printf("Enter the amount of numbers to store in array : ");
scanf("%d",&arraySize);
int numsArray[arraySize];
for(int i=0;i<arraySize;i++)
{
    printf("Enter %d number value : ",i+1);
    scanf("%d",&numsArray[i]);

}
GetMaxInArray(numsArray,arraySize);
GetMinInArray(numsArray,arraySize);

}
