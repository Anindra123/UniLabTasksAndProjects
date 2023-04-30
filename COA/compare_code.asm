.model small
.stack 100h

;data section

.data
output_greater DW 'The output is greater than 5 $'
output_less DW 'The output is less than 5 $'
number DB 1   
num DB 1

; code section
.code         
main PROC
    ;saving all variable in data segment
    MOV AX, @data
    MOV DS, AX
    
    
    MOV AH,1
    INT 21H
    MOV number,AL 
    MOV num,AL
    SUB number,'0'
    
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H  
    
    
    MOV AH,2
    MOV DL,num
    INT 21H
    
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    CMP number,5
    JL  less
    JG  greater
    JMP exit
    
    
    less:
    MOV AH,9
    LEA DX,output_less
    INT 21H
    JMP exit
    
    greater:
    MOV AH,9
    LEA DX,output_greater
    INT 21H 
    JMP exit
    
    
    exit:
    MOV AH,4CH
    INT 21H
    main ENDP

END
    
    
    
    
        
    