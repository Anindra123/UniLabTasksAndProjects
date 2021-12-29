#include<stdio.h>

void printMatrix(int sizeofMat,int matrix[][sizeofMat]){
for(int i=0;i<sizeofMat;i++){
    for(int j=0;j<sizeofMat;j++){
        printf("%d ",matrix[i][j]);
    }
    printf("\n");
}

}
void MatrixAddition(int sizeofMat,int mat1[][sizeofMat],int mat2[][sizeofMat],int mat3[][sizeofMat]){
int matAddition[sizeofMat][sizeofMat];
for(int i=0;i<sizeofMat;i++){
    for(int j=0;j<sizeofMat;j++){
        matAddition[i][j] = mat1[i][j] + mat2[i][j] + mat3[i][j];
    }
}
printf("Addition of the matrices : \n");
printMatrix(sizeofMat,matAddition);

}
int main(){
int mat1[3][3],mat2[3][3],mat3[3][3];
int mat1val = 12,mat2val = 1,mat3val = 101;
//Matrix 1
for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        mat1[i][j] = mat1val;
        mat1val++;
    }
}
//Matrix 2
for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        mat2[i][j] = mat2val;
        mat2val++;
    }
}
//Matrix 3
for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        mat3[i][j] = mat3val;
        mat3val++;
    }
}
int sizeOfMat = 3;
printf("First Matrix : \n");
printMatrix(sizeOfMat,mat1);
printf("Second Matrix : \n");
printMatrix(sizeOfMat,mat2);
printf("Third Matrix : \n");
printMatrix(sizeOfMat,mat3);
MatrixAddition(sizeOfMat,mat1,mat2,mat3);
return 0;
}
