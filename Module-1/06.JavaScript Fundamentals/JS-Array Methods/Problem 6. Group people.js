///Write a function that groups an array of persons by
// first letter of first name and returns the groups as a JavaScript Object
//Use Array#reduce
//Use only array methods and no regular loops (for, while)

var persons = [
    new Person('Kim', 'Valencia', 25, false),
    new Person('Charlotte', 'Le Bonne', 29, true),
    new Person('James', 'Tomkins', 15, false),
    new Person('Helen', 'Owen', 17, true),
    new Person('Kevin', 'Nolan', 32, false),
    new Person('Audrey', 'Tautou', 39, true),
    new Person('Jerard', 'Pique', 21, false),
    new Person('Penelope', 'Cruz', 41, true),
    new Person('Jean', 'Dujardin', 42, false),
    new Person('Keira', 'Knightley', 29, false)
];
function Person(fname,lname,age,gender){

    this.firstname = fname,
        this.lastname = lname,
        this.age = age,
        this.gender = gender? 'female':'male'
}


var result = persons.reduce(function(obj, item) {
    if (obj[item.firstname[0]]) {
        obj[item.firstname[0]].push(item);
    } else {
        obj[item.firstname[0]] = [item];
    }
    return obj;
}, {});

console.log(result);