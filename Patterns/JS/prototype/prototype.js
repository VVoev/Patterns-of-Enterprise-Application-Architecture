var someCar = {
    drive: function () { },
    name: 'Mazda 3'
};
// Use Object.create to generate a new car
var anotherCar = Object.create(someCar);
console.log(anotherCar.name); // Now you'll hopefully

var vehicle = {
    getModel: function () {
        console.log('The model of this vehicle is..' + this.model);
    }
};
var car = Object.create(vehicle, {
    'id': {
        value: 1,
        enumerable: true // writable:false, configurable:false by default
    },
    'model': {
        value: 'Ford',
        enumerable: true
    }
});
car.getModel();


var vehiclePrototype = {
    init: function (carModel) {
        this.model = carModel;
    },
    getModel: function () {
        console.log('The model of this vehicle is..' + this.model);
    }
};
function vehicle(model) {
    function F() { };
    F.prototype = vehiclePrototype;
    var f = new F();
    f.init(model);
    return f;
}
var car = vehicle('Ford Escort');
car.getModel();