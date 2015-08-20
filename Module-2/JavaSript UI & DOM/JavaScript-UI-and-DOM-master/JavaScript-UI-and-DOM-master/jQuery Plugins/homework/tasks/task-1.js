function solve() {
    return function (selector) {
        var $selectedList = $(selector).hide();

        var $divContainer = $('<div />')
            .addClass('dropdown-list')
            .append($selectedList);

        var options = $selectedList.find('option');

        var $currentSelection = $('<div />').addClass('current').attr('data-value', '').text('Select value')
            .appendTo($divContainer);

        var $OptionsContainer = $('<div />')
                                .addClass('options-container')
                                .css({
                                    position: 'absolute',
                                    display: 'none'
                                });
        $currentSelection.on('click', function () {
            var $container = $('.options-container');
            $container.css('display', 'inline-block');

        });
        $OptionsContainer.on('click', function (ev) {
            var $clicked = $(ev.target);
            var $divToDisplay = $('.current');
            $divToDisplay.text($clicked.html());
            $selectedList.val($clicked.attr('data-value'));
            var $container = $(this)
                .css('display', 'none');
        });


        for(var i = 0; i < options.length; i+=1){
            var newOptiont = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', $(options[i]).val())
                .attr('data-index', i)
                .text($(options[i]).text());
            $OptionsContainer.append(newOptiont);
        }

        $divContainer.appendTo('body');
        $currentSelection.appendTo($divContainer);
        $OptionsContainer.appendTo($divContainer);

    };
}

module.exports = solve;