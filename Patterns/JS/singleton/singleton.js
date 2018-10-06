var Singleton = (function () {
    var instantiated;
    function init() {
        // singleton here
        return {
            publicMethod: function () {
                console.log('hello world');
            },
            publicProperty: 'test'
        };
    }
    return {
        getInstance: function () {
            if (!instantiated) {
                instantiated = init();
            }
            return instantiated;
        }
    };
})();
// calling public methods is then as easy as:
Singleton.getInstance().publicMethod();

var singletonTester = (function () {
    function Singleton(options) {
        options = options || {};
        this.name = 'SingletonTester';
        this.pointX = options.pointX || 6;
        this.pointX = options.pointY || 10;
    }

    var instance;

    var _static = {
        name: 'SingletonTester',

        getInstance: function (options) {
            if (instance === undefined) {
                instance = new Singleton(options);
            }
            return instance;
        }
    }

    return _static;
})();

var singletonTest = singletonTester.getInstance({
    pointX: 23
})

console.log(singletonTest.pointX);