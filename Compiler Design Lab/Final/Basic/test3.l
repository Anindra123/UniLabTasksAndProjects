%{
#include<stdbool.h>
bool f = true;
%}

%%
[a-z]+[A-Z] {f = false;}
.
\n {return 0;}
%%

int yywrap(){}
int main(){
yylex();
if(f == false){
printf("\nInvalid Expression\n");
}else{
printf("\nValid Expression\n");
}
return 0;
}