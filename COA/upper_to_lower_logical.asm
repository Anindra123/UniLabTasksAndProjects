.MODEL SMALL
.STACK 100H

.DATA

str1 dw 'Enter an input character : $' 
str2 dw 10,13,'Input is not a correct character $'
str3 dw 10,13,'Uppercase character is :$'
str4 dw 10,13,'Lowercase character is :$'

.CODE

MAIN PROC
    
    MOV AX,@DATA
    MOV DS,AX
    
    
    LEA DX,str1
    MOV AH,9
    INT 21H
    
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL

    MOV CL,40H
    
    CMP CL,BL
    
    JLE is_char 
    
    LEA DX,str2
    MOV AH,9
    INT 21H
    JMP exit
    
    
    is_char:
    
    MOV CH,61H
    CMP CH,BL
    
    JLE small
    XOR BL,00100000b
    
    LEA DX,str4
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    JMP exit
    
    
    small:
    XOR BL,00100000b
    
    LEA DX,str3
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    
    
    JMP exit
    
    
    exit:
    MOV AH,4CH
    INT 21H
    MAIN ENDP

END MAIN