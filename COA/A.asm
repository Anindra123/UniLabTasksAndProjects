ORG 100H
    MOV AX,0B800H
    MOV DS,AX
    MOV CL,'A'
    MOV CH,1101_111b
    MOV BX,15Eh
    MOV [BX],CX
RET