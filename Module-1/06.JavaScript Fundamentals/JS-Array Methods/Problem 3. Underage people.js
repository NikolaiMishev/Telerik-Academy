//Write a function that prints all underaged persons of an array of person
//Use Array#filter and Array#forEach
//Use only array methods and no regular loops (for, while).
var persons = [
    new Person('Kim', 'Valencia', 25, false),
    new Person('Charlotte', 'Le Bonne', 29, true),
    new Person('James', 'Tomkins', 15, false),
    new Person('Helen', 'Owen', 17, true),
    new Person('Kevin', 'Nolan', 7, false),
    new Person('Audrey', 'Tautou', 39, true),
    new Person('Jerard', 'Pique', 21, false),
    new Person('Penelope', 'Cruz', 10, true),
    new Person('Jean', 'Dujardin', 42, false),
    new Person('Keira', 'Knightley', 18, false)
];
function Person(fname,lname,age,gender){

    this.firstname = fname,
        this.lastname = lname,
        this.age = age,
        this.gender = gender? 'female':'male'
}

var underAged = persons.filter(function (item){
    return item.age < 18;
}).forEach(function (item){
    console.log(item);
})