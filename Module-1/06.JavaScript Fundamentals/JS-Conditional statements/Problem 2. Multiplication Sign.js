//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
var arrA = [5,-2,-2,0,-1],
    arrB = [2,-2,4,-2.5,-0.5],
    arrC = [2,1,3,4,-5.1],
    i,
    count,
    len;
for(i = 0, len = arrA.length; i < len;i+=1){

    if (arrA[i] < 0)
    {
        count++;
    }
    if (arrB[i] < 0)
    {
        count++;
    }
    if (arrC[i] < 0)
    {
        count++;
    }
    if (!(arrA[i] == 0 || arrB[i] == 0 || arrC[i] == 0))
    {
        if (count == 1 || count == 3)
        {
            console.log('-');
        }
        else
        {
            console.log('+');
        }
    }
    else
    {
        console.log('0');
    }
    count = 0;
}