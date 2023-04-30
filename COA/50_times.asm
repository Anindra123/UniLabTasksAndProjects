.MODEL SMALL
.STACK 100H

.DATA
str_1 DB 'Enter a character : $'
str_2 DB 10,13,'Thank you !$'   
str_3 DB 10,13,'Avg run time : 4.76 sec $'

.CODE
MAIN PROC
    MOV AX,@DATA
    MOV DS,AX

    LEA DX,str_1
    MOV AH,9
    INT 21H

    MOV AH,1
    INT 21H


    MOV CX,50

    MOV BL,AL
    
    MOV DL,10
    MOV AH,2
    INT 21H

    MOV DL,13
    MOV AH,2
    INT 21H

    loop_:
    

    MOV DL,BL
    MOV AH,2
    INT 21H

    DEC CX

    JNZ loop_

    LEA DX,str_2
    MOV AH,9
    INT 21H
    
    LEA DX,str_3
    MOV AH,9
    INT 21H
    
    
    MOV AH,4CH
    INT 21H
    
    MAIN ENDP

END MAIN




