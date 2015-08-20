/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neighter `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

function solve () {

    function checkContents(contents) {
        for (var i = 0; i < contents.length; i += 1) {
            if (typeof contents[i] !== "string" && typeof contents[i] !== "number") {
                throw new Error('string' + contents[i]);
            }
        }
    }

    return function (element, contents) {
        var i, len,
            fragment = document.createDocumentFragment(),
            div;

        if(typeof element === undefined || typeof contents === undefined){
            throw new Error();
        }
        checkContents(contents);

        if(typeof(element) !== 'string' && !(element instanceof HTMLElement)){
            throw '';
        }

        if (typeof element === "string") {
            element = document.getElementById(element);
        }

        element.innerHTML = "";

        for (i = 0, len = contents.length; i < len; i += 1) {
            div = document.createElement('div');

            div.textContent = contents[i];
            fragment.appendChild(div);
        }
        element.appendChild(fragment);
    };
}

module.exports = solve;