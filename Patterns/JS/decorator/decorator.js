// var Person = function (firstName, lastName) {
//     this.firstName = firstName;
//     this.lastName = lastName;
//     this.gender = 'male'
// };

// var clark = new Person('Clark', 'Kent');

// var SuperHero = function (firstName, lastName, power) {

//     Person.call(this, firstName, lastName);
//     this.powers = power;
// }
// SuperHero.prototype = Object.create(Person.prototype);
// var superman = new SuperHero('Clark', 'Kent', ['flight', 'heat-vision']);
// console.log(superman);

// function vehicle(vehicleType) {
//     // properties and defaults
//     this.vehicleType = vehicleType || 'car',
//         this.model = 'default',
//         this.license = '00000-000'
// }

// var testInstance = new vehicle('car');
// console.log(testInstance);

// var truck = new vehicle('truck');
// truck.setModel = function (modelName) {
//     this.model = modelName;
// }
// truck.setColor = function (color) {
//     this.color = color;
// }
// // Test the value setters and value assignment works correctly
// truck.setModel('CAT');
// truck.setColor('blue');
// console.log(truck);

// // Demonstrate 'vehicle' is still unaltered
// var secondInstance = new vehicle('car');
// console.log(secondInstance);
// // as before, vehicle: car, model:default, license: 00000-000



// What we're going to decorate
// function MacBook() {
//     this.cost = function () { return 997; };
//     this.screenSize = function () { return 13.3; };
// }
// // Decorator 1
// function Memory(macbook) {
//     var v = macbook.cost();
//     macbook.cost = function () {
//         return v + 75;
//     }
// }
// // Decorator 2
// function Engraving(macbook) {
//     var v = macbook.cost();
//     macbook.cost = function () {
//         return v + 200;
//     };
// }
// // Decorator 3
// function Insurance(macbook) {
//     var v = macbook.cost();
//     macbook.cost = function () {
//         return v + 250;
//     }
// }

// function makePizza(macbook) {
//     macbook.makePizza = function () {
//         console.log('ei ti pizata bace');
//     }
// }

// var mb = new MacBook();
// Memory(mb);
// Engraving(mb);
// Insurance(mb);
// makePizza(mb);
// mb.makePizza();
// console.log(mb.cost()); //1522
// console.log(mb.screenSize()); //13.3