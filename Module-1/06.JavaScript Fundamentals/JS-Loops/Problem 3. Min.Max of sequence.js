//Write a script that finds the max and min number from a sequence of numbers.
var sequence = [77,91,9,-1234,11,0.4,41,40,22,34,133,0,244,-94,-0.3,66,-50.55,1111,421,-900];

findThem(sequence);

function findThem(sequence){
    var tempMax = Number.MIN_VALUE,
        tempMin = Number.MAX_VALUE;

   for(var i = 0; i < sequence.length; i+=1){

       if(sequence[i] > tempMax){
           tempMax = sequence[i];
       }
       if(sequence[i] < tempMin){
           tempMin = sequence[i];
       }
   }
       console.log('Max number -> ' + tempMax);
    console.log('Min number -> ' + tempMin);


}