/* program to detect whether abb/compiler/design is a substring of a string */

%%
.*abb.* {printf("The input string has substring abb");}
.*(compile|design).* {printf("Accepted");}
.*ab {printf("Accepted");}
.* {printf("Rejected");}
%%

int yywrap(){
	return 1;
}

int main(){
yylex();
return 0;
}
