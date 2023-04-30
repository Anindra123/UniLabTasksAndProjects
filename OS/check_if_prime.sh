#! /bin/bash



read -p "Enter a number to check prime :" p

is_prime=`expr $p % 2`

if [ $p -eq 0 ];then
	echo 'It is a prime number'
elif [ $is_prime -ne 0 ]; then
	echo 'It is a prime number'
elif [ $is_prime -eq 0 ];then

	echo 'It is not a prime number'
else
	
	echo 'It is not a number'
fi
	
	
