.MODEL SMALL
.STACK 100H


;data section

.data
num DW ?
fizz DW 'fizz$'
buzz DW 'buzz$'
ins DW 'Enter a number to fizzbuzz to :$'     
 
;code section
.code
main PROC
    
    ;set variables to data segment
    MOV AX, @data
    MOV DS,AX    
    MOV BL,1 ; will be used as counter
    MOV DH,3;   
    
    ;show user prompt
    MOV AH,9
    LEA DX,ins
    INT 21H       
    
    ;take user input
    MOV AH,1
    INT 21H
    MOV CH,AL
    SUB CH,'0'
    
    
    
    ;new line
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    ;write a loop
    mainloop:
    ;condition
    CMP BL,CH           ; first check whether the number is less than given number
    JL check_condition         ; go to check_condition label 
    JE exit
    
    check_condition:
    MOV CL,BL
    MOV AL,BL
    MOV AH,0
    MOV BH,3
    DIV BH 
    CMP AH,0
    JE is_fizz
    MOV AL,BL
    MOV AH,0
    MOV BH,5
    DIV BH
    CMP AH,0
    JE is_buzz
    JMP print_num
    
    is_fizz:
    MOV AH,9
    LEA DX,fizz
    INT 21H
    JMP increment
    ;SUB AL,48
    
    is_buzz:
    MOV AH,9
    LEA DX,buzz
    INT 21H
    JMP increment
    
    print_num:
    ADD CL,48
    MOV AH,2
    MOV DL,CL  
    INT 21H
    
    increment:
    
     
    ; incrementing the number
    INC BL
    JMP newline
                  
    ;new line
    newline:
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    JMP mainloop
    
    
    exit:
    MOV AH,4CH
    INT 21H
    main ENDP

END
    
     
    
