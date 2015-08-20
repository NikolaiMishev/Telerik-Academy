//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

var arrA = [5,-2,-2,0,-3],
    arrB = [2,-22,4,-2.5,-0.5],
    arrC = [2,1,3,0,-1.1],
    arrD = [4,0,2,5,-2],
    arrE = [1,0,0,5,-0.1],
    i,
    j,
    temp,
    len;

for(i = 0, len = arrA.length; i < len; i+=1){

    for ( j = 0; j < 5; j += 1)
    {
        if (arrA[i] < arrB[i])
        {
            temp = 0;
            temp = arrA[i];
            arrA[i] = arrB[i];
            arrB[i] = temp;
        }
        if (arrB[i] < arrC[i])
        {
            temp = 0;
            temp = arrB[i];
            arrB[i] =  arrC[i];
            arrC[i] = temp;
        }
        if (arrC[i] < arrD[i])
        {
            temp = 0;
            temp = arrC[i];
            arrC[i] = arrD[i];
            arrD[i] = temp;
        }
        if (arrD[i] < arrE[i])
        {
            temp = 0;
            temp = arrD[i];
            arrD[i] = arrE[i];
            arrE[i] = temp;
        }
    }
    console.log(arrA[i]);
}