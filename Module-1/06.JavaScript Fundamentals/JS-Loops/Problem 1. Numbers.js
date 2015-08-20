//Write a script that prints all the numbers from 1 to N.
var numb1 = 7,
    numb2 = -7;

printNumbers(numb1);
printNumbers(numb2);

function printNumbers(number){
    var upDown = number < 0 ? -1 : 1,
        n = 1;
    while(true){

        console.log(n);
        if(n === number){
            break;
        }

        n += upDown;
    }
}