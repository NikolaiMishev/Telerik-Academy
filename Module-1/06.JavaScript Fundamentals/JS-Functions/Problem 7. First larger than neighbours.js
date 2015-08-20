//Write a function that returns the index of the first element in array
// that is larger than its neighbours or -1, if there’s no such element.

var array = [1,4,5,5,7254,23412,773,1234,112,13,4,7,321,5,231,1,1,1421,1,1,1,1],
    result;

result = FirstBiggerThanNeighbours(array);
console.log('The index of the first number that is bigger than it\'s neighbours is: '  + result);

function FirstBiggerThanNeighbours(arr){
    var i,
        len;

    len = arr.length;
    for(i = 1; i < len-1; i += 1){

        if(arr[i-1] < arr[i] && arr[i] > arr[i+1])
        {
            return i;
        }
    }
    return -1;
}