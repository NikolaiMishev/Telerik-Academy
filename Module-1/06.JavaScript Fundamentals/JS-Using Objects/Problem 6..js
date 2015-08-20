//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups,
// and values - arrays with people in this groups
//Use function overloading (i.e. just one function).
function buildPerson(firstname, lastname, age) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age
    }
}
function group(arrayP, key) {
    var associativeArray = {};
    for (var i in arrayP) {
        var assoProperty = arrayP[i][key];
        if(!associativeArray[assoProperty]){

            associativeArray[assoProperty] = [];
            associativeArray[assoProperty].push(arrayP[i]);
        }
        else{
            associativeArray[assoProperty].push(arrayP[i]);
        }
    }
    return associativeArray;
}

var doncho = buildPerson('Doncho', 'Minkov', 25);
var evlogi = buildPerson('Evlogi', 'Kenov', 22);
var niki = buildPerson('Niki', 'Stoev', 25);
var doni = buildPerson('Doncho', 'Kostov', 24);
var koki = buildPerson('Niki', 'Kostov', 24);
var krasi = buildPerson('Krasi','Dermendjiev',22);

var arrayP = [doncho, evlogi, niki, doni, koki,krasi];
var groupedByFname = group(arrayP, 'firstname');
var groupedByAge = group(arrayP, 'age');

console.log(groupedByAge);
console.log('--------------------------------------------------------------');
console.log(groupedByFname);