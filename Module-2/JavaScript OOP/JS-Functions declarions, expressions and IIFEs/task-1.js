function solve() {
    return function(arr) {
        var i,
            len,
            sum = 0;
        if(arr === undefined) {
            throw new Error('The array cannot be undefined.');
        } else if(!arr.length){
            return null;
        } else {
            if(!arr.every(function(num) {
                    return num == Number(num);
                })) {
                throw new Error('All elements must be numbers.');
            }
            for (i = 0, len = arr.length; i < len; i += 1) {

                sum += parseInt(arr[i]);
            }
            return sum;
        }
    }

}