#include<stdio.h>


int main(){
FILE *fileWritePointer, *fileReadPointer;
char textToWrite[50] = "Hello World";
char dataToRead[50];
char fileName[50] = "Example.txt";
printf("Opening the file %s in write mode \n",fileName);
fileWritePointer = fopen(fileName,"w");

if(fileWritePointer == 0){
    printf("Error occured !");
    return 1;
}

printf("Writing to file %s \n",textToWrite);
fprintf(fileWritePointer,textToWrite);
printf("Closing the file %s \n",fileName);
fclose(fileWritePointer);

printf("Opening the file %s in read mode \n",fileName);
fileReadPointer = fopen(fileName,"r");
if(fileReadPointer == 0){
    printf("Error occured !");
    return 1;
}
printf("Reading from file %s \n",fileName);
while(fgets(dataToRead,50,fileReadPointer)!= '\0'){
    printf("Data read from file : %s \n",dataToRead);
}
printf("Closing the file %s \n",fileName);
fclose(fileReadPointer);
return 0;
}

