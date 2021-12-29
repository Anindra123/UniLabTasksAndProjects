

%%
int|float|string|char 		      {printf("%s is a keyword\n",yytext);}
"="|"*"|"-"|"+"|">="|"<="|"%"|"^"     {printf("%s is an operator\n",yytext);} 
[0-9]+[a-zA-Z]+ 		      {printf("%s is an  invalid identifier\n",yytext);}
[_]?[$]?[a-zA-Z]+[0-9]+?              {printf("%s is a valid identifier\n",yytext);}
.
\n 				      {return 0;}
%%

int yywrap(){

}

int main(){
yylex();
return 0;
}	