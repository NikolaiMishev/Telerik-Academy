//Write a function that returns the last digit of given integer as an English word.
var arr = [100,32,41245,12,1245,122,568,234,31];
for(var i = 0; i < arr.length; i+=1){
   console.log(getNumberLastDigit(arr[i]));
}

function getNumberLastDigit(number){
    var lastdigit = number%10;

    switch (lastdigit){
        case 0:
            return 'zero';
        case 1:
            return 'one';
        case 2:
            return 'two';
        case 3:
            return 'three';
        case 4:
            return 'four';
        case 5:
            return 'five';
        case 6:
            return 'six';
        case 7:
            return 'seven';
        case 8:
            return 'eight';
        case 9:
            return 'nine';
        default:
            return 'Something is wrong!';
    }

}
