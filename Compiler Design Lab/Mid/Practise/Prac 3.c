#include<stdio.h>
#include<string.h>



int main(){

char string1[10] = "hello";
char string2[10] = "Hello";
char string3[10] = "hello";


printf("Length of 1st string : %d \n",strlen(string1));
printf("Comparing first and second string : %d \n",strcmp(string1,string2));
printf("Comparing second and third string : %d \n",strcmp(string2,string3));
printf("Comparing first and third string : %d \n",strcmp(string1,string3));


}

