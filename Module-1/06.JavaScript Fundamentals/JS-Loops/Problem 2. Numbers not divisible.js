//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

var numb1 = 50,
    numb2 = -50;

printNumbers(numb1);
//printNumbers(numb2);

function printNumbers(number){
    var upDown = number < 0 ? -1 : 1,
        n = 1;
    while(true){

        if(n % 3 != 0 || n % 7 != 0){
            console.log(n);
        }
        else
        {
            console.log('-');
        }

        if(n === number){
            break;
        }

        n += upDown;
    }

}