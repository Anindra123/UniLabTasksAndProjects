%{
int c = 0;
int l = 0;
%}

%%
\n {l++;}
. {c++;}
end {printf("\nNumber of characters : %d",c); printf("\nNumber of lines : %d",l); return 0;}
%%

int yywrap(){
	return 1;
}
int main(){
yylex();
return 0;
}