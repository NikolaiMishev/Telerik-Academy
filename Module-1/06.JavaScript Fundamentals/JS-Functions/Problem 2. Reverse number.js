//Write a function that reverses the digits of given decimal number.
var arr = [256,123.45,-103]

for(var i = 0; i < arr.length; i += 1){
   console.log(reverseNumber(arr[i]));
}

function reverseNumber(number){
    var isNegative = number < 0 ? -1 : 1,
        number = number.toString().replace('-','').split(''),
        reversed = [];

            reversed = number.reverse();
            reversed = (+reversed.join('')) * isNegative;

   return reversed;
}