/* program to generate token*/

%%
end {return 0;}
"while"|"if"|"else"|"for" {printf("%s : keyword\n",yytext);}
"int"|"float"|"char" {printf("%s : keyword\n",yytext);}
"+"|"="|"-"|"*"|"/"|"%" {printf("%s : operator\n",yytext);}
[(){},;] {printf("%s : seperator\n",yytext);}
[0-9]+ {printf("%s : integer\n",yytext);}
[0-9]+[a-zA-Z0-9_]+ {printf("%s : invalid identifier\n",yytext);}
[a-zA-Z_][a-zA-Z0-9_]* {printf("%s : valid identifier\n",yytext);}
[0-9]+"."[0-9]+ {printf("%s : float\n",yytext);}
%%

int yywrap(){
	return 1;
}


int main(){
yylex();
return 0;
}