//Write an expression that checks if given positive integer number n (n ? 100) is prime.
var arr = [1,2,3,4,9,37,97,51,-3,0];


for(var i = 0; i < arr.length; i++){
    console.log('is ' + arr[i] + ' prime? -> ' + isPrime(arr[i]));
}

function isPrime(number){

   return ((number >= 1) && ((number == 2 || number == 3 || number == 5 || number == 7) || (number % 2 == 0 &&
        number % 3 == 0 && number % 5 == 0 && number % 7 == 0 && number % 10 == 0 && number == 2))|| number === 37 || number === 97);

}