//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

var arr = [5,8,0,15,5343,62241];

for(var i = 0; i < arr.length; i++){

    console.log(dec2Bin(arr[i]) + ' - ' + ((arr[i] >> 3) & 1));

}
function dec2Bin(dec){
    return (dec >>> 0).toString(2);
}