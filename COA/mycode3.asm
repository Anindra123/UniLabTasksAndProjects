.MODEL SMALL
.STACK 100H

.DATA
str1 DB "Hello world$"


.CODE
MOV AX,@DATA
MOV DS,AX


MOV DL, OFFSET str1  
MOV AH,9
INT 21H

MOV AH,4CH
INT 21H

ENDS