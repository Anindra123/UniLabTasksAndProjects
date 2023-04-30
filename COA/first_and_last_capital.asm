.MODEL SMALL
.STACK 100H

.DATA
str1 DW "Enter line of text :$",10,13
str2 DW 10,13,"First capital : $"
str3 DW 10,13,"Last capital : $"
str4 DW 10,13,"No capital letters $"


.MODEL

MAIN PROC
    MOV AX,@DATA
    MOV DS,AX
    
    MOV BL,0
    MOV CL,0
    
    LEA DX,str1
    MOV AH,9
    INT 21H
    
    MOV AH,1
    
    WHILE:
    INT 21H
    CMP AL,0DH
    JE END_WHILE
    CMP AL,41H
    JL  small
    CMP AL,5AH
    JG  small
    
    CMP BL,41H 
    JGE capital2
    CMP AL,41H
    JGE capital1 
    
    capital1:
    MOV BL,AL
    MOV CL,AL
    JMP WHILE
    
    capital2:
    CMP AL,BL
    JE WHILE
    JL update1
    
    CMP AL,CL
    JE WHILE
    JG update2
    
    JMP small
    
    update1:
    MOV BL,AL
    JMP WHILE
    
    update2:
    MOV CL,AL
    JMP WHILE
    
    
    
    small:
    JMP WHILE
    
    END_WHILE:
    CMP BL,41H
    JL no_capital
    
    LEA DX,str2
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,BL
    INT 21H
    
    LEA DX,str3
    MOV AH,9
    INT 21H
    
    MOV AH,2
    MOV DL,CL
    INT 21H
    
    JMP exit
    
    
    no_capital:
    
    LEA DX,str4
    MOV AH,9
    INT 21H
    
    JMP exit
    
    
    exit:
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP
END MAIN
    
    
    
