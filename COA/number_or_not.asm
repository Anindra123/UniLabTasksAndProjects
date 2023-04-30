.MODEL SMALL
.STACK 100H


.DATA

num DB 'It is a Number$'
str DB 'It is not a Number$'   
prompt DB 'Input : $' 


.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    
    LEA DX,prompt
    MOV AH,9
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    CMP BL,'0'      
    JLE not_a_number  
    
    CMP BL,'9'
    JLE number 
    
    CMP BL,'9'
    JGE not_a_number
    
    not_a_number:
    MOV AH,2
    MOV DL,0DH
    INT 21H
    
    MOV AH,2
    MOV DL,0AH
    INT 21H
    
    LEA DX,str
    MOV AH,9
    INT 21H
    JMP exit
    
    
    number:  
    MOV AH,2
    MOV DL,0DH
    INT 21H
    
    MOV AH,2
    MOV DL,0AH
    INT 21H
    LEA DX,num
    MOV AH,9
    INT 21H 
    JMP exit
    
    exit:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN
    
    
     
    