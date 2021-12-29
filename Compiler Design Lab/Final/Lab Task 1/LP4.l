%{
int nfs =0;
int ns = 0;
int nl =0;
int niw = 0;
%}

%%
"int"|"float"|"this"|"main"|"if"|"while"|"else" {printf("%s - keyword\n",yytext);}
";" {printf("%s - seperator\n",yytext);ns++;}
"." {printf("%s - seperator\n",yytext);nfs++;}
[ ,(){}] {printf("%s - seperator\n",yytext);}
[0-9]+ {printf("%s - integer\n",yytext);}
[a-z_][a-zA-Z0-9_]* {printf("%s - identifier/word\n",yytext);niw++;}
[0-9][a-zA-Z0-9_]+ {printf("%s - invalid identifer\n",yytext);}
[0-0]+"."[0-9]+ {printf("%s - float\n",yytext);}
[a-z]*[#@][a-zA-Z0-9_]+ {printf("%s - invalid identifer\n",yytext);}
"+"|"="|"-"|"%"|"/"|"*" {printf("%s - operator\n",yytext);}
"++"|"--"|"&&" {printf("%s - operator\n",yytext);}
"+-"|"-+" {printf("%s - invalid operator\n",yytext);}
"|&" {printf("%s - invalid operator\n",yytext);}
"&|" {printf("%s - invalid operator\n",yytext);}
"||" {printf("%s - operator\n",yytext);}
[\n] {nl++;}
.
%%

int yywrap(){
	
}

int main(){
FILE *fp;
fp = fopen("input.txt","r");
yyin = fp;
yylex();
printf("Number of semi-colon - %d\n",ns);
printf("Number of fullstop - %d\n",nfs);
printf("Number of lines - %d\n",nl);
printf("Number of identifier/word - %d\n",niw);
return 0;
}