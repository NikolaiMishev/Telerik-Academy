//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element,
// move it at the first position, find the smallest from the rest,
// move it at the second position, etc.
//Hint: Use a second array
var arr = [2,66,5,41,5135,124,0.4,1,4,56,80,72,3.5,14,13,222,109,1000,-9,-111],
    resultArr = [],
    currentSmallest;

for(var i = 0; i < arr.length; i+= 1){
    for(var j = 0; j < arr.length; j +=1){
        if(arr[i] < arr[j]){
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;

        }
    }
}
console.log(arr);