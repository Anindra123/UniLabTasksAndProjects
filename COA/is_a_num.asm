.MODEL SMALL
.STACK 100H

.DATA
str_1 DB 'Enter your input : $'
str_2 DB 10,13,'It is a number $'
str_3 DB 10,13,'It is not a number $'

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
    
    CMP BL,'0'
    
    JL not_number
    
    CMP BL,'9'
    
    JG not_number
    
    LEA DX,str_2
    MOV AH,9
    INT 21H
    JMP exit
    
    not_number:
    LEA DX,str_3
    MOV AH,9
    INT 21H
    JMP exit
    
    exit:
    MOV AH,4CH
    INT 21H
    MAIN ENDP

END MAIN
    
    