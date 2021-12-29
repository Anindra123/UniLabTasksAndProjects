/* read from text file and generate token */

%%
end {return 0;}
"while"|"if"|"for"|"else"|"main" {printf("%s : keyword\n",yytext);}
"int"|"float"|"char" {printf("%s : keyword\n",yytext);}
"="|"+"|"-"|"/"|"*"|"<="|">="|"<"|">"|"%" {printf("%s : operator\n",yytext);}
[(){};,] {printf("%s : seperator\n",yytext);}
[0-9]+ {printf("%s : integer\n",yytext);}
[0-9]+"."[0-9]+ {printf("%s : float\n",yytext);}
[0-9]+[a-zA-Z0-9_]+ {printf("%s : invalid identifier\n",yytext);}
[a-zA-Z_][a-zA-Z0-9_]* {printf("%s : valid identifier\n",yytext);}
.
%%

int yywrap(){

}

int main(){
FILE *fp;
fp = fopen("Code.txt","r");
yyin = fp;
yylex();
return 0;
} 