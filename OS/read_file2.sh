#! /bin/bash


while IFS=':' read name salary age
do
	echo $name $salary $age
done < f2.txt


