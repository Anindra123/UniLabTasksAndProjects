#! /bin/bash


read -p "Guess my name :" a
b="Bivas"

if [ $a = $b ];then
	echo "Answer is correct"
fi

if [ $a != $b ];then 
	echo "Answer is not correct"
fi
