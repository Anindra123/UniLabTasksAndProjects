#include<stdio.h>

struct Employee{
char emp_name[50];
int salary;
};

int main(){

FILE *fptr;
int empSize;
fptr = fopen("Employee.txt","w+");
if(fptr == NULL){

    printf("Error!");
    return(-1);
}
printf("Enter the number of employees :");
scanf("%d",&empSize);
struct Employee emp1[empSize], emp2[empSize];
for(int i=0;i<empSize;i++){
    printf("Enter employee name :");
    scanf("%s",&emp1[i].emp_name);
    printf("Enter employee salary :");
    scanf("%d",&emp1[i].salary);
}
fwrite(emp1,sizeof(emp1),1,fptr);
fclose(fptr);

fptr = fopen("Employee.txt","r");
fread(emp2,sizeof(emp2),1,fptr);
for(int i=0;i<empSize;i++){
    printf("Employee Name : %s , Salary : %d\n",emp2[i].emp_name,emp2[i].salary);
}
fclose(fptr);

}
