#! /bin/bash


read -p  "Enter your name : " name
read -p  "Enter your password :" pas

n="bivas"
p=1234
if [ -z $name -o $pas -lt 1000 ];then
	echo "not a valid name or pass "
elif [ -z $name ] || [ $pas -lt 1000 ];then
	echo "not a valid name or pass "
else 
	echo "valid name and  pass "
fi

if [ $name = $n -a $pas -eq $p ];then
	echo "Logged in"
elif [ $name != $n ] && [ $pas -eq $p ];then
	echo "Name or pass is incorrect"
elif [ $name != $n ] && [ $pas -ne $p ];then
	
	echo "Name or pass is incorrect"

else
	echo "Logged in"
fi
