//Write a script that finds the maximal sequence of equal elements in an array.
var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

getSequence(arr);

function getSequence(arr){
    var counter = 1,
        maxSequence = 1,
        currentChar,
        result = [];

    for(var i = 1; i < arr.length; i+=1){
        if(arr[i] === arr[i-1]){

            counter+=1;

        }
        else
        {
            if(counter > maxSequence){
                maxSequence = counter;
                currentChar = arr[i-1];

            }
            counter = 1;
        }
    }

   for(var j = 0; j < maxSequence; j += 1){
       result.push(currentChar);
   }
    console.log(result);
}