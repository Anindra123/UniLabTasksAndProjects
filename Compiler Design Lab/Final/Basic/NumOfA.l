%{
int c = 0;
%}

%%
[aA] {c++;}
.
\n {return 0;}
%%

int yywrap(){}
int main(){
yylex();
printf("\nNumber of a's in the string : %d\n",c);
return 0;
}