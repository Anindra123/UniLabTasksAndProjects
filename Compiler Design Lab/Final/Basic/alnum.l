

%%
"hello world" {printf("Good bye world");}
[a-zA-Z0-9] {printf("Alpha numeric");}
. {printf("Wrong Input");}
end {return 0;}
%%

int yywrap(){

	return 1;
}

int main(){
yylex();
return 0;
}