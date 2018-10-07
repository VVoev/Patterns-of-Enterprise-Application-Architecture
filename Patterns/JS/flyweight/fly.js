var Book = function (id, title, author, genre, pageCount, publisherID, ISBN, checkoutDate, checkoutMember, dueReturnDate, availability) {
    this.title = title;
    this.author = author;
    this.genre = genre;
    this.pageCount = pageCount;
    this.publisherID = publisherID;
    this.ISBN = ISBN;
    this.checkoutDate = checkoutDate;
    this.checkoutMember = checkoutMember;
    this.dueReturnDate = dueReturnDate;
    this.availability = availability;
};

Book.prototype = {
    getTitle: function () {
        return this.title;
    },
    getAuthor: function () {
        return this.author;
    },
    getISBN: function () {
        return this.ISBN;
    },
    // other getters not shown for brevity
    updateCheckoutStatus: function (bookID, newStatus, checkoutDate, checkoutMember, newReturnDate) {
        this.id = bookID;
        this.availability = newStatus;
        this.checkoutDate = checkoutDate;
        this.checkoutMember = checkoutMember;
        this.dueReturnDate = newReturnDate;
    },
    extendCheckoutPeriod: function (bookID, newReturnDate) {
        this.id = bookID;
        this.dueReturnDate = newReturnDate;
    },
    isPastDue: function (bookID) {
        var currentDate = new Date();
        return currentDate.getTime() > Date.parse(this.dueReturnDate);
    }
};