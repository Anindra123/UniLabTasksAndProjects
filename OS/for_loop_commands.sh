#! /bin/bash


for cmd in ls pwd date
do
	echo "Command name : $cmd"
	echo "Command output :"
	$cmd
done

