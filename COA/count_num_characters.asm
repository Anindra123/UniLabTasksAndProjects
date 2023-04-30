.MODEL SMALL
.STACK 100H

.DATA 

chars DW 10,13,'Write some chars :$'  
output DW 10,13,'Number of chars is : $'

.CODE
MAIN PROC 
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,chars
    MOV AH,9
    INT 21H
    
    MOV CL,0
    MOV AH,1
    
    INT 21H
    
    WHILE:
    CMP AL,0DH
    JE END_WHILE
    INC CL
    INT 21H
    
    JMP WHILE
    END_WHILE:
    
    LEA DX,output
    MOV AH,9
    INT 21H
    
    ADD CL,30H
    
    MOV AH,2
    MOV DL,CL
    INT 21H
    
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP
END MAIN
    