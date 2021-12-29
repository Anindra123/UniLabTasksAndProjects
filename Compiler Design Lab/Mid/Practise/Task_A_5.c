#include<stdio.h>


int Factorial(int value){
int factorialOutputValue = 0;

//Check if prime number
//Check by dividing the value from 2 to value-1
//Anything after half of the value doesn't give remainder zero
//So we add condition value/2
for(int i=2;i<=value/2;i++){
    if(value%i == 0){
        factorialOutputValue = -1;
        printf("Not a prime number\n");
        return factorialOutputValue;
    }
}
if(factorialOutputValue == 0){
        factorialOutputValue = 1;
        printf("Prime number\n");
}
for(int i=1;i<=value;i++){
    factorialOutputValue = i * factorialOutputValue;
}

return factorialOutputValue;

}


int main(){
float output = Factorial(5);
if(output >= 0){
    printf("Factorial is %f",output);
}

return 0;
}
