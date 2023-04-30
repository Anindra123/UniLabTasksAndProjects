.model small
.stack 100h

;data
.data
ins DW 'Enter the number of tringle block :$'
block DB '*'


;code

.code    

main PROC 
    MOV AX,@data
    MOV DS,AX  
    
    
    MOV AH,9
    LEA DX,ins
    INT 21H
    MOV AH,1
    INT 21H
    MOV CL,AL
    SUB CL,48
    
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    main_loop:
    MOV BL,0
    CMP CL,0
    JG print_loop
    JMP exit
    
    
    print_loop:
    CMP BL,CL
    JL print_block
    JMP decrement
    
    print_block:
    MOV AH,2
    MOV DL,block
    INT 21H   
    INC BL
    JMP print_loop
    
    
    
    decrement:
    DEC CL
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    JMP main_loop
    
    
    exit:
    MOV AH,4CH
    INT 21H
    main ENDP
END