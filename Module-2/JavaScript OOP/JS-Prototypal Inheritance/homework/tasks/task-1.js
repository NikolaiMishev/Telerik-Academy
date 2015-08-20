/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * // method removeAttribute(attribute)
 */

function solve() {
	return (function () {
		var domElement = {
			init: function(type) {
				this.type = type;
				this.content;
				this.attributes;
				this.children;
				this.parent;
				this.innerHTML;
				return this;
			},
			appendChild: function(child) {
				if (checkIfString(child) || checkIfDomEl(child)) {
					if (!!this.content) {
						this.content = null;
					}

					if (!this.children) {
						this.children = [];
					}

					child.parent = this;

					this.children.push(child);
				} else {
					throw new Error('Invalid child appended!')
				}

				return this;
			},
			addAttribute: function(name, value) {
				var reducedName = name.replace(/-/g, '');
				if (checkIfString(name) && (!containsForbiddenChars(reducedName))) {
					if (!this._attributes) {
						this._attributes = {};
					}
					this._attributes[name] = value;
				} else {
					throw new Error('Invalid attribute name entered!');
				}

				return this;
			},
			removeAttribute: function(attribute) {
				if (checkIfExistingAttribute(attribute, this)) {
					delete this.attributes[attribute];
				} else {
					throw new Error('You are trying to remove an unexisting attribute!');
				}

				return this;
			},

			get innerHTML(){
				var result;

				result = '\<' + this.type;
				result += getAttributes(this);
				result += '\>';
				result += getChildrenOrContent(this);
				result += '\<\/' + this.type + '\>';

				return result;
			},

			set type(value) {
				if ((typeof value == 'string' || value instanceof String) &&
					value && (!value.match(/\W/))) {
					this._type = value;
				} else {
					throw new Error('Invalid type entered!');
				}
			},
			get type() {
				return this._type;
			},

			set content(value) {
				if (!this.children) {
					if (checkIfString(value)) {
						this._content = value;
					} else {
						throw new Error('Invalid content entered!');
					}
				}
			},
			get content() {
				return this._content;
			},

			set attributes(value) {
				var i,
					len = value.length;

				this.attributes = {};

				for (i = 0; i < len; i++) {
					this.addAttribute(value[i]);
				}
			},
			get attributes() {
				return this._attributes;
			},

			set children(value) {
				var i,
					len = value.length;

				this._children = [];

				for (i = 0; i < len; i++) {
					this.appendChild(value[i]);
				}
			},
			get children() {
				return this._children;
			},

			set parent(value) {
				if (checkIfDomEl(value)) {
					this._parent = value;
				} else {
					throw new Error('You have entered invalid parent');
				}
			},
			get parent() {
				return this._parent;
			}
		};

		function checkIfString(obj) {
			return (typeof obj == 'string' || obj instanceof String) && obj;
		}

		function checkIfDomEl(obj) {
			return domElement.isPrototypeOf(obj);
		}

		function checkIfExistingAttribute(attribute, self) {
			if (checkIfString(attribute)) {
				for (attri in self.attributes) {
					if (attri == attribute) {
						return true;
					}
				}

				return false;
			} else {
				return false;
			}
		}

		function containsForbiddenChars(str) {
			return str.match(/\W/);
		}

		function isEmpty(obj) {
			for(var key in obj) {
				if (obj.hasOwnProperty(key)) {
					return false;
				}
			}

			return true;
		}

		function getAttributes(self) {
			var attributesString = '',
				i,
				key,
				keys = [],
				len;

			if (!isEmpty(self.attributes)) {
				for (key in self.attributes)
				{
					if (self.attributes.hasOwnProperty(key))
					{
						keys.push(key);
					}
				}

				keys.sort();
				len = keys.length;

				for (i = 0; i < len; i++)
				{
					attributesString += ' ' + keys[i] + '\=\"' + self.attributes[keys[i]] + '\"';
				}
			}

			return attributesString;
		}

		function getChildrenOrContent(self) {
			var childrenOrContentToString = '',
				i,
				len;

			if (self.children && self.children.length > 0) {
				len = self.children.length;
				for (i = 0; i < len; i++) {
					if (checkIfString(self.children[i])) {
						childrenOrContentToString += self.children[i];
					} else {
						childrenOrContentToString += self.children[i].innerHTML;
					}
				}
			} else if (self.content) {
				childrenOrContentToString += self.content;
			}

			return childrenOrContentToString;
		}

		return domElement;
	} ());
}

module.exports = solve;