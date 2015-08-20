//Problem 1, 2, 3, 4
var int = 13,
    string = '\'How you doin\'?\', Joey said\'',
    float = 3.14,
    arr = [1,2,3,4,5],
    obj = {name:'Pesho',age:21},
    bool = true,
    func = function(){return},
    nullValue = null,
    undefinedValue = undefined;

var arr2 = [int,string,float,arr,obj,bool,func,nullValue,undefinedValue];

for(var i = 0;i < arr2.length;i++){
    console.log(typeof(arr2[i]) + ' - ' + arr2[i]);
}
console.log('Is \'arr\' an array-' + ' - ' + Array.isArray(arr));