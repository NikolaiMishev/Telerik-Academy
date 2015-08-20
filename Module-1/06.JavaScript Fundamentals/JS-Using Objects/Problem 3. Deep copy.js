//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

var student = {
        name: 'John',
        age: 22,
        hair : {
        color: 'rainbow',
        kind: 'wtf'
        }
    },
    student2 = { name: '',
        age: 0,
        hair : {
            color: '',
            kind: ''
        }};

function clone(destination, source) {
    for (var prop in source) {
        if (typeof source[prop] === "object" && source[prop] !== null) {
            clone(destination[prop], source[prop]);
        } else {
            destination[prop] = source[prop];
        }
    }
};

clone(student2,student);

console.log(student.name + '\n' + student.age + '\n' + student.hair.color + ' - ' + student.hair.kind);
console.log('-----------------------');
student.name = 'Ivan';
student.hair.kind = 'curly';
console.log(student2.name + '\n' + student2.hair.kind);