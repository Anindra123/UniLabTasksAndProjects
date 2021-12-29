%{

%}


%%
(0|1)*111(0|1)* {printf("input as three consecutive 1\n");}
0(0|1)*1011(0|1)* {printf("starts with 0 and has substring 1011\n");}
(0|1)(0|1)0(0|1)* {printf("atleast 3 characters and third charater is 0\n");}
.* {printf("Reject\n");}
%%

int yywrap(){
return 1;
}

int main(){
yylex();
return 0;
}