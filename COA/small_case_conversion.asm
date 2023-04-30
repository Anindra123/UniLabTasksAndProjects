.MODEL SMALL
.STACK 100H


.DATA

str1 DW 10,13,'Enter a character input : $'
str2 DW 10,13,'Toggle case is : $'

.CODE


MAIN PROC
    
    MOV AX,@DATA
    MOV DS,AX
    
    LEA DX,str1
    MOV AH,9
    INT 21H 
    
    MOV AH,1
    INT 21H
    
    MOV BL,AL
    
    CMP AL,61H
    JGE  lowercase
     
    ADD BL,20H
    JMP exit 
    
    lowercase:
    SUB BL,20H
    JMP exit        
   
    
    
    exit:
    LEA DX,str2
    MOV AH,9
    INT 21H        
      
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    MOV AH,4CH
    MAIN ENDP
END MAIN
    