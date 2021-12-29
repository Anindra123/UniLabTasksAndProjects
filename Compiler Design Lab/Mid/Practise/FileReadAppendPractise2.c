#include<stdio.h>


int main(){
 FILE *fileAppendPointer, *fileReadPointer;
char dataToRead[50];
char fileName[50] = "Example2.txt";
printf("Opening the file %s in append mode \n",fileName);
fileAppendPointer = fopen(fileName,"a");

if(fileAppendPointer == 0){
    printf("Error occured !");
    return 1;
}


}
