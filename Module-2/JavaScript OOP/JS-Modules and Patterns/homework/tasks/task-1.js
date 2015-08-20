/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {

	function startsOrEndsWithWhitespace(str){
		return /^\s+|\s+$/.test(str);
	}
	function haveTwoSpaces(str){

		return /\s{2,}/.test(str);
	}
	function validatePresentations(presentations){
		var i,
			len;
		for(i = 0,len = presentations.length; i < len; i+=1){
			if(startsOrEndsWithWhitespace(presentations[i])){
				return false;
			}
			if(haveTwoSpaces(presentations[i])){
				return false;
			}
			if(presentations[i].length === 0){
				return false;
			}
		}
		return true;
	}
	function validateName(name){
		var regex = /^[A-Z][a-z]*$/;
		if(!regex.test(name)){
			throw new Error('Name is not valid!');
		}
	}
	function validateId(id,max){
		var min = 1;
		if(id != Number(id)){
			throw 'Invalid type for id.';
		}

		id = +id;

		if(id < min || id > max){
			throw 'Invalid range.';
		}
	}

	var Course = {
		init: function(title, presentations) {
			if(startsOrEndsWithWhitespace(title) || haveTwoSpaces(title)){
				throw new Error('Course title not valid!');
			}
			this.title = title;
			this.presentations = presentations;
			this.students = [];

			return this;
		},
		addStudent: function(name) {
			var firstname = name.split(' ')[0],
				lastname = name.split(' ')[1];
			validateName(firstname);
			validateName(lastname);
			if(name.split(' ').length > 2){
				throw new Error('More than 2 names are not aloud!');
			}
			var id = this.students.length+1;
			var student = {
				firstname: firstname,
				lastname: lastname,
				id: id
			};
			this.students.push(student);
			return id;
		},
		getAllStudents: function() {
			return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
			validateId(studentID,this.students.length);
			validateId(homeworkID,this.presentations.length);
		},
		pushExamResults: function(results) {

		},
		getTopStudents: function() {
		}
	};

	Object.defineProperty(Course, 'presentations',{
		get: function(){
			return this._presentations;
		},
		set: function(value){
			if(value.length === 0){
				throw  new Error('Presentations are not correct!');
			}
			if(!validatePresentations(value)){
				throw new Error('Presentations have some more spaces than usual!!!');
			}
			this._presentations = value;
		}
	});
	return Course;
}


module.exports = solve;
