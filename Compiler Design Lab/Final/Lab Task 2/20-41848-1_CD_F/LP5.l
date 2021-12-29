%{
int p_count = 0;
int flag = 0;
%}

%%
"(" {p_count++;printf("%s",yytext);}
")" {p_count--;printf("%s",yytext);}
[+*%^\-][+*%^\-] {flag = 1;printf("%s",yytext);}
[a-z]*[#@][a-zA-Z0-9_]+ {flag = 1;printf("%s",yytext);}
[a-zA-Z0-9_]*[a-zA-Z0-9_]+" "[a-zA-Z0-9_]*[a-zA-Z0-9_]+ {flag = 1;printf("%s",yytext);}
[0-9%)*^\=][a-zA-Z0-9_]+ {flag = 1;printf("%s",yytext);}
[\n] { 
	if(p_count > 0 ){printf("- invalid expression\n",yytext); }
	else if(p_count<0){printf("- invalid expression\n",yytext);}
	else if(flag == 1) { printf("- invalid expression\n",yytext); } 
	else{printf("- valid expression\n",yytext);}
	p_count = 0;
	flag = 0;
     }
%%

int yywrap(){
	
}

int main(){
FILE *fp;
fp = fopen("input.txt","r");
yyin = fp;
yylex();
return 0;
}