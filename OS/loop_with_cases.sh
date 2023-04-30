#! /bin/bash


#echo "Calculator Program"
#echo "1.Addition"
#echo "2.Subtraction"
#echo "3.Multiplication"
#echo "4.Division"
#echo "5.Exit"

#read -p "Select an operation :" n

select n in add sub mul div 
do 
	case $n in		 
		add) 
			read -p "Enter two number for addition :" a b
			echo "Result is" `expr $a + $b`
			;;
		sub) 
			read -p "Enter two number for subtraction:" a b
			echo "Result is " `expr $a - $b`
			;;
		mul) 
			read -p "Enter two number for mulitplication :" a b
			echo "Result is " `expr $a /* $b`
			;;
		div) 
			read -p "Enter two number for division:" a b
			echo "Result is "`expr $a \ $b`
			;;
		*) 
			break
			;;
	esac
done

