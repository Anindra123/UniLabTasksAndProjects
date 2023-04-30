.MODEL SMALL
.STACK 100H

.DATA

str_1 DB 'Enter your first input :$'
str_2 DB 10,13,'Enter your second input :$'
str_3 DB 10,13,'Result is positive $'
str_4 DB 10,13,'Result is negative $'
str_5 DB 10,13,'Result is zero $'

.CODE

MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,str_1
    MOV AH,9
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    LEA DX,str_2
    MOV AH,9
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV CL,AL
    SUB BL,CL
    
    JZ zero
    JS negative
    JNS positive
    
    positive:
    LEA DX,str_3
    MOV AH,9
    INT 21H
    JMP exit
    
    negative:
    LEA DX,str_4
    MOV AH,9
    INT 21H
    JMP exit 
    
    zero:
    LEA DX,str_5
    MOV AH,9
    INT 21H
    JMP exit
    
    exit:
    MOV AH,4CH
    INT 21H
    MAIN ENDP


END MAIN