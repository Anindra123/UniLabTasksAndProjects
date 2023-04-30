.MODEL SMALL
.STACK 100H


.CODE
MOV AX,08000h
MOV BX,08000h

SUB AX,BX

JB bigger
JMP exit

bigger:
    MOV AH,2
    MOV DL,'b'
    INT 21H
    
exit:
    MOV AH,4CH
    INT 21H
    
ENDS
 