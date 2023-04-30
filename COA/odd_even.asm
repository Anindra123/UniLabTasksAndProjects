.MODEL SMALL
.STACK 100H

.DATA 

str1 dw 'Enter an input character : $' 
str2 dw 10,13,'Input is not a number $'
str3 dw 10,13,'Number is odd$'
str4 dw 10,13,'Number is even$'


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
    
    MOV CL,'0'
    MOV CH,'9'
    
    CMP BL,CL
    
    JL not_num
    
    CMP BL,CH
    
    JG not_num
    
    
    TEST BL,1
    
    JZ even
    
    LEA DX,str3
    MOV AH,9
    INT 21H
    JMP exit
    
    even:
    
    LEA DX,str4
    MOV AH,9
    INT 21H
    JMP exit
    
    
    
    
    not_num:
    
    LEA DX,str2
    MOV AH,9
    INT 21H
    JMP exit
    
    exit:
    
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN