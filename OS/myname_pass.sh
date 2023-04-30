#! /bin/bash


read -p "Enter your name :" name

read -sp "Enter your password :" pass

read -s id

echo -e "\n"


echo "Hi $name"

echo "ID : $id"
echo "Your password \"$pass\""

echo "Home directory : $HOME"
echo  "Current directory : $PWD"


echo "Bash directory : $BASH"
echo "BASH version : $BASH_VERSION"



echo -e "\n"
echo HI $name

echo  "Hi"$name


echo "Who"$name"did this"
