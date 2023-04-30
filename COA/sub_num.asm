.MODEL SMALL
.STACK 100H
.DATA

STR1 DB 'The difference of $'

STR2 DB ' AND $'          

STR3 DB ' IS $'

.CODE
MAIN PROC  
    MOV AX,@DATA
    MOV DS,AX
    
    MOV AH,2
    MOV DL,'?'
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    INT 21H
    
    MOV CL,AL
    
    MOV AH,2
    MOV DL,0DH
    INT 21H
   
    MOV DL,0AH
    INT 21H
    
    
    LEA DX,STR1
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    LEA DX,STR2
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,CL
    INT 21H
    
    LEA DX,STR3
    MOV AH,9
    INT 21H
    
    SUB BL,CL
    ADD BL,'0' 
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN
    