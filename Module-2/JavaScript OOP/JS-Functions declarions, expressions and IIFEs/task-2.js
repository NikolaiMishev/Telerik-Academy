//Write a function that finds all the prime numbers in a range
//It should return the prime numbers in an array
//It must throw an Error if any of the range params is not convertible to Number
//It must throw an Error if any of the range params is missing
function solve(){
    return function (start, end){
        var result = [],
            startPoint,
            endPoint,
            i;
        if(arguments.length < 2){
            throw new Error('Not enough arguments!!!');
        }
        else if(!isNumber(start) || !isNumber(end)){
            throw new Error('Not convertible to Number!!!');
        }else{
            startPoint = +start;
            endPoint = +end;
            for( i = startPoint; i <= endPoint; i+=1){
                if(isPrime(i)){
                    result.push(i);
                }
            }
            return result;
        }

        function isNumber(some){
            return some == Number(some);
        }


        function isPrime(number) {
            var maxDivisor = Math.sqrt(number),
                isPrime = true,
                currDivisor;

            if(number < 2) {
                return false;
            }

            for(currDivisor = 2; currDivisor <= maxDivisor; currDivisor += 1) {
                if(!(number % currDivisor)) {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }

}
