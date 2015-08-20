///Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//Use only array methods and no regular loops (for, while).
var persons1 = [
    new Person('Kim', 'Valencia', 25, false),
    new Person('Charlotte', 'Le Bonne', 29, true),
    new Person('James', 'Tomkins', 15, false),
    new Person('Helen', 'Owen', 17, true),
    new Person('Kevin', 'Nolan', 18, false),
    new Person('Audrey', 'Tautou', 39, true),
    new Person('Jerard', 'Pique', 21, false),
    new Person('Penelope', 'Cruz', 18, true),
    new Person('Jean', 'Dujardin', 42, false),
    new Person('Keira', 'Knightley', 29, false)
];
var persons2 = [
    new Person('Kim', 'Valencia', 25, false),
    new Person('Charlotte', 'Le Bonne', 29, true),
    new Person('James', 'Tomkins', 19, false),
    new Person('Helen', 'Owen', 35, true),
    new Person('Kevin', 'Nolan', 18, false),
    new Person('Audrey', 'Tautou', 39, true),
    new Person('Jerard', 'Pique', 21, false),
    new Person('Penelope', 'Cruz', 18, true),
    new Person('Jean', 'Dujardin', 42, false),
    new Person('Keira', 'Knightley', 29, false)
];
function isBigEnough(item){

    return item.age >= 18;
}


console.log('Array1 -> ' + persons1.every(isBigEnough));
console.log('Array2 -> ' + persons2.every(isBigEnough));
function Person(fname,lname,age,gender){

    this.firstname = fname,
        this.lastname = lname,
        this.age = age,
        this.gender = gender? 'female':'male'
}