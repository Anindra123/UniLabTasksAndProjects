#! /bin/bash

os=('Javascript', 'Python', 'C#')

echo "${os[0]}"
echo "${os[1]}"
echo "${os[2]}"
echo "Length of array ${#os[@]}"

echo removing 2nd element of array 


unset os[1]



echo "${os[@]}"



read -a ai -p "Enter ai domain :"


echo  "${ai[@]}"



