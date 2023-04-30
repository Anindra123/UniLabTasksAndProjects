#! /bin/bash


read -p "Enter file name :" filename


if [ -f $filename ];then
	echo "$filename exist"

else
	echo "$filename does not exist"
fi



