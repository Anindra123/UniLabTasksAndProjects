#! /bin/bash


read -p "Enter two number to add :" a b


add=$(expr $a + $b)

echo "Result of two addition : $add"

read -p "Enter two number to sub:" a b


sub=$(expr $a - $b)

echo "Result of two subtraction : $sub"

read -p "Enter two number to divide:" a b


div=$(expr $a / $b)

echo "Result of two division: $div"


read -p "Enter two number to multiply:" a b


mul=$(expr $a \* $b)

echo "Result of two multiply: $mul"



read -p "Enter two number to mod:" a b


mod=$(expr $a % $b)

echo "Result of two mod: $mod"



