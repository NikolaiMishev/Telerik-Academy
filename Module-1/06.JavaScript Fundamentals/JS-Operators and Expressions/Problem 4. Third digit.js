//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
var arr = [5,701,1732,9703,877,777877,9999799];

for(var i = 0; i < arr.length; i++){

    console.log(arr[i] + ' - ' + (Math.floor((arr[i]/100)%10) === 7) );
}
