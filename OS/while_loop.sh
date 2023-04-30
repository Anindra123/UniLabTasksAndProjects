#! /bin/bash


read -p "Enter message and number of times to print :" m n

num=0

while [ $num -ne $n ]
do
	echo $m
	num=`expr $num + 1`
done



