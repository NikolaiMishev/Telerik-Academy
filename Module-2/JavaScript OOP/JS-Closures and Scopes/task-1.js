/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [];
        var categories = [],
            bookID = 0,
            categoryID = 0;

        function listBooks(property) {
            var booksTemp = books.slice();
            if (property) {
                var prop;
                for (prop in property) {
                    if (property.hasOwnProperty(prop)) {
                        booksTemp = books.filter(function(item) {
                            return item[prop] === property[prop];
                        });
                    }
                }
            }
            return booksTemp.sort(function(a, b) {
                if(a.id > b.id){
                    return 1;
                }
                if(a.id < b.id){
                    return -1;
                }
                return 0;
            });
        }

        function addBook(book) {
            var categoryInd=0,
                newCategory,
                newBook;

            if(!validateTitle(book.title)){
                throw new Error('Title must be unique!');
            }
            else if(!validateISBN(book.isbn)){
                throw new Error('ISBN must be unique!');
            }
            else if(!validateAuthor(book.author)){
                throw new Error('Not a valid author!');
            }
            else{
                newBook = new Book(book);
                books.push(newBook);
            }
            if(!categories.some(function(item,index) {
                    categoryInd = index;
                    return item.name === book.category;
                })){
                newCategory = new Category(book.category);
                newCategory.books.push(book);
                categories.push(newCategory);
            }
            else{
                categories[categoryInd].books.push(newBook);
            }

            return newBook;
        }

        function listCategories() {

            var categoriesNames = [];
            for(var i = 0; i < categories.length; i += 1){
                categoriesNames.push(categories[i].name);
            }

            return categoriesNames;
        }

        function validateTitle(title){
            return books.every(function(item){
                return (item.title !== title);
            });
        }

        function validateAuthor(author){
            return author.trim() !== '';
        }

        function validateISBN(isbn){
            return books.every(function(item){
                    return (item.isbn !== isbn);
                })&& (isbn.length === 13 ||isbn.length === 10);
        }

        function Book(book){

            this.ID = bookID+=1;
            this.title = book.title;
            this.author = book.author;
            this.isbn = book.isbn;
            this.category = book.category;
        }

        function Category(name){
            this.ID = categoryID+=1;
            this.name = name;
            this.books = [];
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    } ());
    return library;
}
