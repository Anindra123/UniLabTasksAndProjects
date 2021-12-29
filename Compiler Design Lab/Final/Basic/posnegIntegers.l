

%%
[+]?[0-9]+ {printf("%s is a positive integer",yytext);}
[-][0-9]+  {printf("%s is a negative integer",yytext);}
[a-zA-Z]+  {return 0;}
%%

int yywrap(){
	return 1;
}

int main(){
yylex();
return 0;
}