%{
int v = 0;
int c = 0;
%}

%%
[aeiouAEIOU] {printf("%s is a vowel\n",yytext);v++;}
[a-zA-Z] {printf("%s is consonant\n",yytext); c++;}
.
\n {return 0;}
%%

int yywrap(){}
int main(){
yylex();
printf("\nNumber of vowels: %d\n",v);
printf("\nNumber of consonants:%d\n",c);
return 0;
}
