//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while).
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

var females = persons.filter(function(element){
    return element.gender === 'female';
});
var femaleSum = females.reduce(function(sum, item, i, arr) {
        var count = arr.length;
        return (sum + item.age / count);
    }, 0);

console.log(femaleSum | 0);