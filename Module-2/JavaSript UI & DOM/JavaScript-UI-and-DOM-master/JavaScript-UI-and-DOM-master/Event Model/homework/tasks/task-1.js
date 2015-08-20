/* globals $ */

/* 

Create a function that takes an id or DOM element and:


*/

function solve(){
  return function (selector) {
    var classBtn = document.querySelectorAll('.button'),
        classContent = document.querySelectorAll('.content');

    if(selector == undefined){
      throw new Error();
    }
    if(selector !== HTMLElement){
      selector = document.getElementById(selector);
    }
    if(selector == null){
      throw new Error();
    }

    var i, len = classBtn.length;
    function ShowHideFn(){
        var next = this.nextElementSibling;

        while(next.className !== 'button'){
            if (next.className === 'content') {
                break;
            }
            next = next.nextElementSibling;
        }
        if (next.className === 'content' && next.style.display == '') {

            this.innerHTML = 'show';
            next.style.display = "none";
        }
        else {

            this.innerHTML = "hide";
            next.style.display = '';
        }
    }


    for(i = 0; i < len; i+=1) {
        classBtn[i].innerHTML = "hide";
        classBtn[i].addEventListener('click', ShowHideFn, false);
    }


  };
}

module.exports = solve;