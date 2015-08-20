//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

var array = [1,2,3,1,3,4,6,7,5,2,3,5,6,1,4,7,2,9,8,1,7,9,7,4,3,5,7,9,4,2,2,4,6,7,8,3,9,3];

    console.log(countDigit(array));

function countDigit(arr){
    var i,
        counter = {};

     for(i in arr){
         if(!counter[arr[i]]){
             counter[arr[i]] = 0;
         }
         counter[arr[i]]+=1;
     }
    return counter;

}