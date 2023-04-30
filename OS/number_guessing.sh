#! /bin/bash


read -p 'Enter a your mood from (1-5):' n


case $n in 
	0)
		echo "In a very bad mood"
		;;
	1)
		echo "A bad mood "
		;;
	2)
		echo "A little bad mood"
		;;
	3)
		echo "Ok mood"
		;;
	4)
		echo "A little good mood"
		;;
	5)
		echo "Very good mood"
		;;
	*)
		echo "Don't know what mood youre in"
		;;
esac

