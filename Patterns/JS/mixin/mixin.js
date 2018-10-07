// Car
var Car = function (settings) {
    this.model = settings.model || 'no model provided';
    this.colour = settings.colour || 'no colour provided';
};
// Mixin
var Mixin = function () { };
Mixin.prototype = {
    driveForward: function () {
        console.log('drive forward');
    },
    driveBackward: function () {
        console.log('drive backward')
    }
}


// Augment existing 'class' with a method from another
function augment(receivingClass, givingClass) {
    // only provide certain methods
    if (arguments[2]) {
        for (var i = 2, len = arguments.length; i < len; i++) {
            receivingClass.prototype[arguments[i]] = givingClass.prototype[arguments[i]];
        }
    }
    // provide all methods
    else {
        for (var methodName in givingClass.prototype) {
            /* check to make sure the receiving class doesn't
            have a method of the same name as the one currently
            being processed */
            if (!receivingClass.prototype[methodName]) {
                receivingClass.prototype[methodName] = givingClass.prototype[methodName];
            }
        }
    }
}
// Augment the Car have the methods 'driveForward' and 'driveBackward'*/
augment(Car, Mixin);
// Create a new Car
var vehicle = new Car({ model: 'Ford Escort', colour: 'blue' });
// Test to make sure we now have access to the methods
vehicle.driveForward();
vehicle.driveBackward();