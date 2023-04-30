.model small
.stack 100H


.data
num DB 31H
char DB 'A'
output DW 'hi mom !$'
input_char DB ?
input_num DB ?



.code
main PROC
    MOV AX, @data     ; imports all variables
    MOV DS, AX        ; moves the data to Datasegment register
    
    
    ;input a character
    MOV AH,1           ;calling the AH register for taking a single char input
    INT 21H            ;Calling interrupt flag, the value will be stored in AL register
    MOV input_char,AL  ;storing the data in input_char variable
    
    MOV AH,1           ;setting the AH register for taking a single character input
    INT 21H            ; calling the interrupt flag, value gets stored in  AL register
    SUB AL,'0'         ; to convert it to number the value get subtracted with previous AL
    MOV input_num,AL   ;storing the value to input_num variable
    
    
    ;Output a new line
    MOV AH,2            ; the AH register is set to 2 which is a predefined value for outputing a character
    MOV DL,10           ; the output is stored in the DL register
    INT 21H
    MOV DL,13
    INT 21H
    
    
    ;Output a string
    
    MOV AH,9            ;  for outputting a string the predefined value is AH set to 9
    LEA DX,output       ; for string output we must load effective address(address with offset) using LEA
                        ; instruction , the string variable must be in datasegment register  
    INT 21H
    
    
    
    ;Output a new line
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    ;Output a number
    
    MOV AH,2
    MOV DL,num
    INT 21H
      
      
    ;Output a new line
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    
    ;Output a character 
    
    MOV AH,2
    MOV DL,char
    INT 21H
    
    
    
    ;Output a new line
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    
    ;Output a character taken from user
    
    MOV AH,2
    MOV DL,input_char
    INT 21H
    
    ;Output a new line
    MOV AH,2
    MOV DL,10
    INT 21H
    MOV DL,13
    INT 21H
    
    
    ;Output a number taken from user
    
    
    MOV AH,2
    MOV DL,input_num
    INT 21H


    exit:
    MOV AH, 4CH
    INT 21H
    main ENDP

END main