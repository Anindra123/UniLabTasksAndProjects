.MODEL SMALL
.STACK 100H

.DATA
str1 DW 'Enter an input : $'
str2 DW 10,13,'The number of 1s is $'

.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    MOV AH,9
    LEA DX,str1
    INT 21H
    
    MOV AH,1
    INT 21H
    
   
    
    MOV BX,AX
    AND BX,000Fh
    MOV CX,16
    XOR AX,AX
    
    WHILE:
    ROL BX,1
    JNC skip
    INC AX
    skip:
    LOOP WHILE
    
    OR AX,0030h
    
    XOR CX,CX
    
    MOV CX,AX
    
    MOV AH,9
    LEA DX,str2
    INT 21H
    
    MOV DL,CL
    MOV AH,2
    INT 21H
    
    MOV AH,4CH
    INT 21H
    MAIN ENDP

END MAIN