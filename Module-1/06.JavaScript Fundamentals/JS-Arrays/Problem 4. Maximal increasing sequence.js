//Write a script that finds the maximal increasing sequence in an array.
var arr = [3, 2, 3, 4, 2, 2, 4];


getSequence(arr);

function getSequence(arr){
    var counter = 1,
        maxSequence = 1,
        currentChar,
        result = [];

    for(var i = 1; i < arr.length; i+=1){
        if(arr[i] === arr[i-1]+1){

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


    for(var  j = 0; j < maxSequence; j+=1){
        result.push(currentChar-j);
    }
    result.reverse();
    console.log(result);

}