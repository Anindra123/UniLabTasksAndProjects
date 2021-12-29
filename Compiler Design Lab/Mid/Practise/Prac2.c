#include<stdio.h>



int main(){

char data[500];
char name[50];
int marks;
int numberOfStudents;
/*Append to a text file */

FILE *fileAppendPointer;
printf("Enter the number of students :");
scanf("%d",&numberOfStudents);

//Open the file in append mode
fileAppendPointer = fopen("test2.txt","a");

if(fileAppendPointer == 0){
    printf("Error!");
    return 1;
}
//Writing data to file in append mode
for(int i=1;i<=numberOfStudents;i++){

    printf("Enter the name of student :");
    scanf("%s",&name);
    printf("Enter the marks of student :");
    scanf("%d",&marks);
    fprintf(fileAppendPointer,"Name : %s  Marks: %d\n",name,marks);
}


//Closing the file

fclose(fileAppendPointer);


/*Reading from a text file */
FILE *fileReadPointer;
//Opening text file in write mode
printf("Opening a text file in read mode.....\n");
fileReadPointer = fopen("test2.txt","r");
if(fileReadPointer == 0){
    printf("Error");
    return 1;
}
// Reading the text from the file
while(fgets(data,100,fileReadPointer) != '\0'){
    printf("%s",data);
}


//Closing the text file
printf("Closing the text file........\n");
fclose(fileReadPointer);

return 0;
}
