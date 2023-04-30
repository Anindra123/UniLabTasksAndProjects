#! /bin/bash


read -p "Enter two number range for divisible by 3 number:" a b



until [ $a -eq $b ]
do
	if [ `expr $a % 3` -eq 0 ];then
		echo $a
	fi
	a=`expr $a + 1`
done
