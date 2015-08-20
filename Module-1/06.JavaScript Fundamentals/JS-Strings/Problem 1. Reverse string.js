//Write a JavaScript function that reverses a string and returns it.
var str = 'Reverse me';

console.log(reverseString(str));


function reverseString(str){
    return str.split('').reverse().join('');
}

