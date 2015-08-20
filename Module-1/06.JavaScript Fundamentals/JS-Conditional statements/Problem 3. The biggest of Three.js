//Write a script that finds the biggest of three numbers.
//Use nested if statements.
var arrA = [5,-2,-2,0,-0.1],
    arrB = [ 2,-2,4,-2.5,-0.5],
    arrC = [2,1,3,5,-1.1],
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
    console.log('The biggest number is: ' + arrA[i]);
}

// 5
//  	1
//  	4
//    5
//	-0.1