.MODEL SMALL
.STACK 100H

.DATA
str1 DW 'Enter a character : $'
str2 DW 10,13,'It is not a valid character $'
str3 DW 10,13,'Uppercase character is : $'
str4 DW 10,13,'Lowercase character is : $'
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
    
    CMP BL,41h
    JGE is_capital
    JL is_small
    
    is_capital:
    CMP BL,5Ah
    JLE small
    JG is_small
    
    is_small:
    CMP BL,61h
    JGE is_small_char
    JL not_character
    
    is_small_char:
    CMP BL,7Ah
    JLE capital
    JG not_character
    
    capital:
    LEA DX,str3
    JMP is_character
    
    small:
    LEA DX,str4
    JMP is_character

    is_character:
    XOR BL,20h
    
    MOV AH,9
    INT 21H 
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    JMP exit
    
    
    not_character:
    MOV AH,9
    LEA DX,str2
    INT 21H
    JMP exit
    
    exit:
    MOV AH,4CH
    INT 21H
    MAIN ENDP

END MAIN
    
    
    
    