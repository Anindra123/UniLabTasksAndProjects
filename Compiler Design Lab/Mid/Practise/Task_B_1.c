#include<stdio.h>

void CalculateAvg(int numArray[],int sizeofArray){
int sum = 0;
for(int i=0;i<sizeofArray;i++){
    sum += numArray[i];
}

int avgOfNums = sum / sizeofArray;

printf("The average of the numbers are :%d \n",avgOfNums);

}


int main(){
int arraySize;
printf("Enter the amount of numbers to count avg of : ");
scanf("%d",&arraySize);
int avgNumCountArray[arraySize];
for(int i=0;i<arraySize;i++)
{
    printf("Enter %d number value : ",i+1);
    scanf("%d",&avgNumCountArray[i]);

}
CalculateAvg(avgNumCountArray,arraySize);

}
