.MODEL SMALL
.STACK 100H
.DATA
str1 DW 'Enter your input : $'
str2 DW 10,13,'Reverse output is : $'

.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    
    MOV AH,9
    LEA DX,str1
    INT 21H
    
    MOV AH,1
    XOR CX,CX
    
    WHILE:
    INT 21H    
    CMP AL,0DH
    JE END_WHILE  
    PUSH AX
    INC CX
    JMP WHILE
    
    END_WHILE:
    MOV AH,9
    LEA Dx,str2
    INT 21H
    
    XOR DX,DX
    MOV AH,2
    
    LOOP_:
    POP DX
    INT 21H
    LOOP LOOP_
    
    MAIN ENDP

END MAIN
    