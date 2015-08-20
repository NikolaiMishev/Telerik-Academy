//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders.

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

persons.forEach(function(item) {
    console.log(item);
});

function Person(fname,lname,age,gender){

       this.firstname = fname,
       this.lastname = lname,
       this.age = age,
       this.gender = gender? 'female':'male'
}