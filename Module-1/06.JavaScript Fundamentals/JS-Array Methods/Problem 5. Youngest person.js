//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find.

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

persons = persons.sort(function (a,b) {
        return a.age - b.age;
    });

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngest = persons.find(function(item){
    return item.gender === 'male';
});
console.log(youngest);