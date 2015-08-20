//Write an if statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

var arrA = [5,3,5.5],
    arrB = [2,4,4.5],
    i,
    len;

for(i = 0,len = arrA.length; i < len; i+=1){

console.log(isGreater(arrA[i],arrB[i]));

}

function isGreater( a, b){
    if(a>b){
        var temp = a;
       a = b;
        b = temp;
    }
    return a + ' ' + b;
}
