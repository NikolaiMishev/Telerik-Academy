//Write a JavaScript function that replaces in a HTML document given as string
// all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
console.log(ReplaceTags(text));
//Expected answer
console.log('<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>');
function ReplaceTags(text){
    var startTag = '<a href="',
        middleTag = '">',
        endTag = '</a>',
        result = [];
    for(var i = 0; i < text.length; i+=1){

        if(text.substr(i,startTag.length) === startTag){
            result.push('[URL=');
            i+= startTag.length;
        }
        if(text.substr(i,middleTag.length) === middleTag){
            result.push(']');
            i+= middleTag.length;
        }
        if(text.substr(i, endTag.length) === endTag){
            result.push('[/URL]');
            i+=endTag.length;
        }


        result.push(text[i]);
    }
    return result.join('');
}