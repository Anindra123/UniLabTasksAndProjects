.MODEL SMALL
.STACK 100H 

.DATA
g DW 'it is greater$'
l DW 'it is less$' 
e DW 'they are equal$'

.CODE
MOV AX,@DATA
MOV DS,AX

MOV DL,0F7H
MOV CH,0F7H

CMP DL,CH
JG greater
JL less
JE equal

greater:
    LEA DX,g
    MOV AH,9
    INT 21H
    
    JMP exit


less:
    LEA DX,l
    MOV AH,9
    INT 21H
    
    JMP exit   
    
equal:
    LEA DX,e
    MOV AH,9
    INT 21H
    
    JMP exit 
    

exit:
    MOV AH,4CH
    INT 21H

ENDS