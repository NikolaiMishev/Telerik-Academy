///Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.

var text = "<html><head><title>Sample site</title></head>" +
    "<body><div>text<div>more text</div>and more...</div>in body</body></html>";

console.log(getText(text));
console.log('Sample sitetextmore textand more...in body');
function getText(text){
    var append = true,
        result = [];
    for(var i = 0; i < text.length; i +=1) {

        if(text[i] === '<') {
            append = false;
            continue;
        }
        if(text[i] === '>'){
            append = true;
            continue;
        }

        if (append) {
            result.push(text[i])
        }
    }
    return result.join('');
}