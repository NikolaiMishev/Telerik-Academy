function solve() {

    function validateName(name){
        var regex = /^[a-z]{3,20}$/gi;

        return regex.test(name);
    }
    function validateAge(age){
        return age <= 150 && age >= 0 && typeof(+age) === 'number' ;
    }


    var Person = (function () {
        function Person(firstName,lastName,age) {
            if(!validateName(firstName)){
                throw new Error('First name is not valid!');
            }
            if(!validateName(lastName)){
                throw new Error('First name is not valid!');
            }
            if(!validateAge(age)){
                throw new Error('Age is NaN or not in the range!');
            }

            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
        }
        Person.prototype = {
            get firstname(){
                return this._firstName;
            },
            set firstname(newFirstName) {
                if(!validateName(newFirstName)){
                    throw new Error('First name is not valid!');
                }
                this._firstName = newFirstName;
                return this;
            },
            get lastname(){
                return this._lastName;
            },
            set lastname(newLastName){
                if(!validateName(newLastName)){
                    throw new Error('First name is not valid!');
                }
                this._lastName = newLastName;
                return this;
            },
            get age(){
                return this._age;
            },
            set age(newAge){
                if(!validateAge(newAge)){
                    throw new Error('Age is NaN or not in the range!');
                }
                this._age = +newAge;
                return this;
            },
            get fullname(){
                return this._firstName + ' ' + this._lastName;
            },
            set fullname(fullname){
                var names = fullname.split(' '),
                    fName = names[0],
                    lName = names[1];
                this.firstname = fName;
                this.lastname = lName;
                return this;
            },
            introduce: function(){
                return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +
                    ' and I am ' + this.age + '-years-old';
            }
        };

        return Person;
    } ());
    return Person;
}