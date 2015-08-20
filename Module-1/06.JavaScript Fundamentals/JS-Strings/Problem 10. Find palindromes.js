//Write a program that extracts from a given text all palindromes,
// e.g. "ABBA", "lamal", "exe".

function findPalindromes(text) {
    var i,
        result = [],
        arrOfWords = text.split(' ').map(function(item) {
            return item.trim('.,!?-');
        });
    len = arrOfWords.length;
    for (i = 0; i < len; i += 1) {
        if (arrOfWords[i].length > 1 &&
            arrOfWords[i].toLowerCase() === reverseWord(arrOfWords[i].toLowerCase())) {
            result.push(arrOfWords[i]);
        }
    }
    return result;
}

function reverseWord(word) {
    return word.split('').reverse().join('');
}
var text = 'Some say ABBA is cool.But I think that exe stopped working aaand - Otto fault!';
console.log(findPalindromes(text));