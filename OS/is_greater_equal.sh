#! /bin/bash



read -p  "Enter  two number :" a b


if [ $a -le $b ];then
	echo  $a is less than or equal $b
fi
if [ $a -ge $b ];then
	echo $a is greater than $b
fi
