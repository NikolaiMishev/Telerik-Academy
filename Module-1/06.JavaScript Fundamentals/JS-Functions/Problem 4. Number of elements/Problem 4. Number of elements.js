//Write a function to count the number of div elements on the web page.
console.log(countDivs());

function countDivs(){
   return document.getElementsByTagName('div');
}