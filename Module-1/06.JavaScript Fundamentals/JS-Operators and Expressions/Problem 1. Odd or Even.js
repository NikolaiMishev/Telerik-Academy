//Write an expression that checks if given integer is odd or even.
var array = [3,2,-2,-1,0];

for(var i = 0; i < array.length; i++){
    if(array[i] % 2 == 0){
        console.log(array[i] + ' - ' + false);
    }
    else{
        console.log(array[i] + ' - ' + true);
    }
}