//Write a script that compares two char arrays lexicographically (letter by letter).

var charArr1 = ['a','b','c','d','e','f','g'],
    charArr2 = ['g','i','c','b','q','f','s'],
    charArr3 = ['g','i','c','b','q','f','s'];

console.log(compare(charArr1,charArr2));

console.log(compare(charArr2,charArr3));

function compare(arr1,arr2){
   var bool = true;
    for(var i = 0; i<arr1.length;i+=1){
        if(arr1[i] !== arr2[i]){
            bool = false;
        }
    }
    return bool;
}