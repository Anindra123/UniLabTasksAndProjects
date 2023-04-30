#! /bin/bash


function Sum(){

	sum=`expr $a + $b`
	return $sum

}


read -p "Enter first operand :" a
read -p "Enter second operand : " b
Sum a b
echo "Sum is : " $?

