.MODEL SMALL
.STACK 100H

.CODE
MOV CX,5
MOV DL,32
print_loop:   
    MOV AH,2
    INC DL
    INT 21H
    DEC CX
    JNZ print_loop
MOV AH,4CH
INT 21H

ENDS