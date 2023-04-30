#! /bin/bash


read -p "Enter a number range to print the primes within the range :" a b


for ((n=$a;n<$b;n++))
do
	if [ $n -eq 0 -o $n -eq 2 ];then
		echo $n
	elif [ `expr $n % 2` -ne 0 ];then
	       echo $n
	 fi

	n=$((n++))
done
