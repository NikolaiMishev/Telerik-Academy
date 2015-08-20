//Write a script that finds the most frequent number in an array.
var arr =[4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    currentMostFrequent,
    counter = 0,
    currentMax = 0,
    result = [];

for(var i = 0; i < arr.length; i += 1){
    for(var j = 0; j < arr.length; j +=1){
        if(arr[i] == arr[j]){
            counter +=1;
        }
    }
    if(currentMax < counter){
        currentMax = counter;
        currentMostFrequent = arr[i];
    }
    counter = 0;
}

console.log(currentMostFrequent +'(' + currentMax + ' times)');