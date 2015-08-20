//Write a function that replaces non breaking white-spaces in a text with &nbsp;
function replaceWhiteSpace(text) {
    return (text.split(/\s/g).join('&nbsp;'));
}
var text = "We are living in an yellow submarine." +
    " We don't have anything else. inside the submarine is very tight." +
    " So we are drinking all the day. We will move out of it in 5 days.";
console.log(replaceWhiteSpace(text));