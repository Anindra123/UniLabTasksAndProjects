.MODEL SMALL
.STACK 100H

.DATA

inp DB 'input a number :$'
pos DB 10,13,'positive$'
negative DB 10,13,'negative$'
equal_num DB 10,13,'zero$'
.CODE

MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,inp
    MOV AH,9
    INT 21H
    
    MOV AH,1
    INT 21H
    
    MOV BH,AL
           
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    MOV DL,'-'
    
    CMP DL,BH   
    
    
    
    JNE not_negative
    JE negate_num
    negate_num:
       NEG BL
       
    not_negative:
    
    MOV CL,'0'       
           
    CMP BL,CL
    
    JL negative_num
    JG positive_num
    JE equal
    JMP exit
    
    positive_num:
       
       LEA DX,pos
       MOV AH,9
       INT 21H  
       JMP exit
       
    negative_num:
       LEA DX,negative
       MOV AH,9
       INT 21H
       JMP exit
    
    equal:
       LEA DX,equal_num
       MOV AH,9
       INT 21H
       JMP exit 
       
    exit:
       MOV AH,4CH
       INT 21H
       MAIN ENDP

END MAIN
        
        
       
       
   
       
