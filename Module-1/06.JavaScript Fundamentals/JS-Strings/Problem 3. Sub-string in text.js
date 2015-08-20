//Write a JavaScript function that finds how many times
// a substring is contained in a given text (perform case insensitive search).

var text = "We are living in an yellow submarine." +
    " We don't have anything else. inside the submarine is very tight." +
    " So we are drinking all the day. We will move out of it in 5 days.",
    count = 0,
    subStringToFind = 'in';

for(var i = 0; i < text.length; i+=1){
    if(text.substr(i,subStringToFind.length).toLowerCase() === subStringToFind.toLowerCase()){
        count+=1;
        i+=1;
    }
}
console.log('The result is: ' + count);