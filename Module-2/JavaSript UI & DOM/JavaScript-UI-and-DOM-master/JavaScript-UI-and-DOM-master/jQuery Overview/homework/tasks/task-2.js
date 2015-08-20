/* globals $ */

/*
 Create a function that takes a selector and:
 * Finds all elements with class `button` or `content` within the provided element
 * Change the content of all `.button` elements with "hide"
 * When a `.button` is clicked:
 * Find the topmost `.content` element, that is before another `.button` and:
 * If the `.content` is visible:
 * Hide the `.content`
 * Change the content of the `.button` to "show"
 * If the `.content` is hidden:
 * Show the `.content`
 * Change the content of the `.button` to "hide"
 * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
 * Throws if:
 * The provided ID is not a **jQuery object** or a `string`

 */
function solve() {
    return function (selector) {
        if (typeof(selector) !== 'string' || $(selector).size() === 0) {
            throw 'invalid selector';
        }
        function OnClickBtn() {

            var $this = $(this),
                next = $this.next();

            while (!next.hasClass('button')) {
                if (next.hasClass('content')) {
                    break;
                }
                next = next.next();
            }
            if (next.hasClass('content') && next.css('display') == 'none') {
                $this.text('hide');
                next.css('display', '');
            }
            else {
                $this.text('show');
                next.css('display', 'none');
            }
        }

        var buttons = $('.button'),
            contents = $('.content'),
            len = buttons.length,
            i;

        for (i = 0; i < len; i += 1) {
            $(buttons[i]).text('hide');
            $(buttons[i]).on('click', OnClickBtn);
        }

    };
}

module.exports = solve;