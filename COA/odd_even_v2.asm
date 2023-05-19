.MODEL SMALL
.STACK 100H

.DATA
str1 DW 'Enter a number (0-9) : $'
str2 DW 10,13,'It is not a number $'
str3 DW 10,13,'The number is even $'
str4 DW 10,13,'The number is odd $'

.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    MOV AH,9
    LEA DX,str1
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    JMP check_num
    
    
    even:
    LEA DX,str3
    JMP is_num
    
    odd:
    LEA DX,str4
    JMP is_num
    
    
    not_num:
    LEA DX,str2
    MOV AH,9
    INT 21H
    JMP exit
    
    
    
    check_num:
    CMP BL,30h
    JL not_num
    CMP BL,39h
    JG not_num
    
    TEST BL,1
    JZ even
    JMP odd
    
    is_num:
    MOV AH,9
    INT 21H
    
    JMP exit
    
    exit:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN
    