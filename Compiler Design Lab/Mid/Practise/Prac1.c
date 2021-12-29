#include<stdio.h>



int main(){
/*Writing to a text file */
FILE *filePointer;
char data[100];

//Opening text file in write mode
printf("Opening a text file in write mode.....\n");
filePointer = fopen("test.txt","w");
if(filePointer == 0){
    printf("Error");
    return 1;
}

// Writing hello world to the text file
printf("Writing Hello world to the text file.....\n");
fprintf(filePointer,"Hello world");

//Closing the text file
printf("Closing the text file........\n");
fclose(filePointer);



/*Reading from a text file */
FILE *fileReadPointer;
//Opening text file in write mode
printf("Opening a text file in read mode.....\n");
fileReadPointer = fopen("test.txt","r");
if(fileReadPointer == 0){
    printf("Error");
    return 1;
}
// Reading the text from the file
while(fgets(data,100,fileReadPointer) != '\0'){
    printf("%s \n",data);
}


//Closing the text file
printf("Closing the text file........\n");
fclose(fileReadPointer);
return 0;

}
