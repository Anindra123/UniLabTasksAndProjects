.MODEL SMALL
.STACK 100H


.DATA

str_1 DB 'Enter your input : $'
str_2 DB 10,13,'It is positive $'
str_3 DB 10,13,'It is negative $'
str_4 DB 10,13, 'It is zero $'
str_5 DB 10,13,'Not a number $'


.CODE

MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,str_1
    MOV AH,9
    INT 21H
    
    MOV AH,1
    INT 21H
    
    
    MOV BH,AL
    
    INT 21H
    MOV BL,AL
    
    CMP BL,'0'
    JL not_number
    
    CMP BL,'9'
    JG not_number
    
    MOV CL,'-'
    CMP CL,BH
    
    JNE not_negative
    
    LEA DX,str_3
    MOV AH,9
    INT 21H
    JMP exit
    
    not_negative:
    CMP BH,'0'
    JL not_number
    
    CMP BH,'9'
    JG not_number
    
    CMP BL,'0'
    JE zero
    
    LEA DX,str_2
    MOV AH,9
    INT 21H
    JMP exit
    
    not_number:
    LEA DX,str_5
    MOV AH,9
    INT 21H
    
    JMP exit
    
    
    zero:
    LEA DX,str_4
    MOV AH,9
    INT 21H
    JMP exit
    
    
    exit:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN