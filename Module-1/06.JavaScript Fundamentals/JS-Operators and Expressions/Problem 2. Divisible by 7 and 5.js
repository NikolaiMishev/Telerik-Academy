//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
var arr = [3,0,5,7,35,140];
for(var i = 0; i < arr.length; i++){

        console.log(arr[i] + ' - ' +  isDevidingBy7And5(arr[i]));

}
    function isDevidingBy7And5(number) {
        return Boolean(number % 5 == 0 && number % 7 == 0);
    }