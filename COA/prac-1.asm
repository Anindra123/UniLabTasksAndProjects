.MODEL SMALL
.STACK 100H

.DATA

.CODE
MAIN PROC
    
    MOV AH,2
    MOV DL,'?'
    INT 21H
    
    MOV AH,1
    
    INT 21H
    
    MOV BL,AL
    
    MOV AH,2
    MOV DL,0Dh
    INT 21h
    MOV DL,0Ah
    INT 21H
    
    
    MOV DL,BL
    INT 21H
    
    
    MOV AH,4CH
    INT 21H
MAIN ENDP

END MAIN
