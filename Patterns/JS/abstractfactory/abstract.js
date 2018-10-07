var AbstractVehicleFactory = (function () {
    var types = {};
    return {
        getVehicle: function (type, customizations) {
            var Vehicle = types[type];
            return (Vehicle) ? new Vehicle(customizations) : null;
        },
        registerVehicle: function (type) {
            // only register classes that fulfill the vehicle contract
            types[type] = type;
            return AbstractVehicleFactory;
        }
    };
})();
//Usage
AbstractVehicleFactory.registerVehicle("car");
AbstractVehicleFactory.registerVehicle("truck");

var car = AbstractVehicleFactory.getVehicle("car", { color: "yellow", turbo: true });
var truck = AbstractVehicleFactory.getVehicle("truck", { monster: true, cylinders: 12 });