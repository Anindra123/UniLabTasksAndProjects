.MODEL SMALL
.STACK 100H

.DATA

new_line DW 10,13,'$'

.CODE


MAIN PROC  
    MOV AX,@DATA
    MOV DS,AX
    
    MOV AH,2
    MOV DL,'?'
    INT 21H
    
    MOV CX,0
    
    MOV AH,1
    
    LOOP_:
    
    INT 21H
    CMP AL,0Dh
    JE END_LOOP
    PUSH AX
    INC CX
    JMP LOOP_
    
    END_LOOP:
    LEA DX,new_line
    MOV AH,9
    INT 21H
    
    REVERSE_LOOP:
    POP DX
    MOV AH,2
    INT 21H
    
    DEC CX
    
    JZ EXIT
    
    JMP REVERSE_LOOP
    
    
    
    
    
    
    EXIT:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN