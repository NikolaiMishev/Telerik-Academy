//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
function checkExpr(string) {
    var counter = 0;
    var isCorrect = true;
    for (var i = 0; i < string.length; i++) {
        if (string[i] === '(') {
            counter++;
        }
        else if (string[i] === ')') {
            counter--;
        }
        if (counter < 0 || (string[i] === '(' && string[i+1] === ')')) {
            isCorrect = false;
            break;
        }
    }
    if (counter !== 0) {
        isCorrect = false;
    }
    return isCorrect;
}
var expr1 = '((a+5)/2)',
    expr2 = '()*((a-45)*3)';

console.log(checkExpr(expr1));
console.log(checkExpr(expr2));