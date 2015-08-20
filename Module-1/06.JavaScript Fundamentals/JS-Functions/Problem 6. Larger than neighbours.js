//Write a function that checks if the element at given position
// in given array of integers is bigger than its two neighbours (when such exist).

var array = [1,4,123,5,72543,23412,773,1234,112,13,4,7,321,5,231,1,1,1421,1,1,1,1],
    result;

result = isBiggerThanNeighbours(20,array);
console.log(result);

function isBiggerThanNeighbours(position,arr){
    var i,
        len;

    len = arr.length;
    if(position === 0 || position == len-1){
        return 'There is no enough neighbours!';
    }

    for(i = 0; i < len; i +=1){

        if(arr[position-1] < arr[position] && arr[position] > arr[position+1]){
            return true;
        }
        else
        {
            return false;
        }
    }
}