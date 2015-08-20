//Write a function that checks if a given object contains a given property.
//var obj  = …;
//var hasProp = hasProperty(obj, 'length');

var student = {
    name: 'John',
    age: 22,
    hair : {
        color: 'rainbow',
        kind: 'wtf'
    }
};

function hasProperty(obj,propName){
    for(var prop in obj){
        if(prop === propName){

            return true;
        }
    }
    return false;
}

var hasProp = hasProperty(student,'age');

console.log(hasProp);

console.log('\nBuild-in function.');
console.log(student.hasOwnProperty('age'));