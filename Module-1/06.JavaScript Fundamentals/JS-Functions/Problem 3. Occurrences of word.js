//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.
var text = 'args argS args aRGs ARGS arGs ArgS aRGs Args';
console.log(findOccurrences(text,'args',false));
console.log(findOccurrences(text,'args',true));
function findOccurrences(text,word,isCaseSensitive){
  var textArr,
      count = 0;
    if(!isCaseSensitive){
       text = text.toUpperCase();
       word = word.toUpperCase();
    }

    textArr = text.toString().split(' ');
    for(var i = 0; i < textArr.length; i += 1){

        if(textArr[i] == word){
            count += 1;
        }
    }

    return count;
}