.MODEL SMALL
.STACK 100H

.DATA

stat_1 DB 'Enter a lowercase character :$'
stat_2 DB 10,13,'Upper case character is : $'

.CODE

MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,stat_1
    MOV AH,9
    INT 21H
    
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    
    SUB BL,32
    
    LEA DX,stat_2
    MOV AH,9
    INT 21H
    
    MOV DL,BL
    MOV AH,2
    INT 21H
    
    MAIN ENDP

END MAIN