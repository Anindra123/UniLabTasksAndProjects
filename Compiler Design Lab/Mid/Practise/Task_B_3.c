#include<stdio.h>

void GetName(char firstName[10],char lastName[10])
{
    printf("Full name is : %s %s",firstName,lastName);
}

int main(){

char fName[10];
char lName[10];

printf("Enter your first name : ");
scanf("%s",&fName);
printf("Enter your last name : ");
scanf("%s",&lName);

GetName(fName,lName);


}
