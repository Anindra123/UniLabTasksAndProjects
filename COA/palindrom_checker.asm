.MODEL SMALL
.STACK 100H

.DATA
string DD ?
str1 DW 'Enter your input : $'
p DW 10,13,'It is a palindrome$'
not_p DW 10,13,'It is not a palindrome $'


.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    MOV BX,OFFSET string
    
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
    MOV [BX],AL
    INC BX
    INC CX
    JMP WHILE
    
    END_WHILE:
    XOR DX,DX
    MOV DI,OFFSET string
    OUTPUT:
    POP AX
    MOV DX,[DI]
    CMP AL,DL
    JNE not_palindrome
    INC DI
    LOOP OUTPUT
    
    MOV AH,9
    LEA DX,p
    INT 21H
    JMP EXIT
    
    not_palindrome:
    MOV AH,9
    LEA DX,not_p
    INT 21H
    
    EXIT:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN
    
    