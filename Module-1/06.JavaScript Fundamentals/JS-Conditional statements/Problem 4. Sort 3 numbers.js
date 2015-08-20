//Sort 3 real values in descending order.
//Use nested if statements.

var arrA = [5,-2,-2,0,-1.1,10,1],
    arrB = [ 1,-2,4,-2.5,-0.5,20,1],
    arrC = [2,1,3,5,-0.1,30,1],
    i,
    j,
    temp,
    len;

for(i = 0, len = arrA.length; i < len; i+=1){

    for ( j = 0; j < 3; j += 1)
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
    }
    console.log(arrA[i]+ ' ' + arrB[i] + ' ' + arrC[i]);
}