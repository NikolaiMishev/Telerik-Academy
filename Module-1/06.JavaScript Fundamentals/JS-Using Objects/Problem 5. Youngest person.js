//Write a function that finds the youngest person
// in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

var people01 = [{
        firstname: 'Tanq',
        lastname: 'Karaivanova',
        age: 25
    },{
    firstname: 'Nikolai',
    lastname: 'Stefanov',
        age: 22
    },{
    firstname: 'Stefan',
    lastname: 'Popov',
        age: 32
    } ];

function findYoungest(people){
    var minAge = people[0].age,
        index,
        len,
        i;
    for(i = 0, len = people.length; i < len; i+=1){
        if(people[i].age < minAge){
            minAge = people[i].age;
            index = i;
        }
    }
    return people[index].firstname + ' ' + people[index].lastname;
}

console.log('The youngest person is: ' + findYoungest(people01));