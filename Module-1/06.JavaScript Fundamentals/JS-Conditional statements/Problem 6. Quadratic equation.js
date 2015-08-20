//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0
// and solves it (prints its real roots).
//Calculates and prints its real roots.

var arrA = [2,-1,-0.5,5],
    arrB = [5,3,4,2],
    arrC = [-3,0,-8,8],
    determinant,
    xOne,
    xTwo;

for(var i = 0; i < arrA.length; i+=1){
    determinant = Math.sqrt((arrB[i] * arrB[i]) - 4 * arrA[i] * arrC[i]);

    xOne = (-arrB[i] - determinant) / (2 * arrA[i]);

    xTwo = (-arrB[i] + determinant) / (2 * arrA[i]);

    if (arrA[i] + arrB[i] <= arrC[i])
    {
        console.log('There are no real roots!');
    }
    else
        console.log('X1= '+ xOne +' X2= '+ xTwo);
}