var testModule = (function () {
    var counter = 0;


    return {
        incrementCounter: function () {
            return counter++;
        },
        resetCounter: function () {
            console.log('counter value prior to reset:' + counter);
            counter = 0;
        }
    };
})();
// test
testModule.incrementCounter();
testModule.incrementCounter();
testModule.incrementCounter();
testModule.incrementCounter();
testModule.incrementCounter();
testModule.resetCounter();

var basketModule = (function () {
    var basket = []; //private
    function doSomethingPrivate() {
        //...
    }
    function doSomethingElsePrivate() {
        //...
    }

    function addItem(values) {
        basket.push(values);
    }

    function getProductInfo(index) {
        return basket[index];
    }

    return { //exposed to public
        addItem: addItem,
        getProductInfo,
        getItemCount: function () {
            return basket.length;
        },
        doSomething: doSomethingPrivate(),
        getTotal: function () {
            var q = this.getItemCount(),
                p = 0;
            while (q--) {
                p += basket[q].price;
            }
            return p;
        }
    }
}());

basketModule.addItem({ golqmXui: '23cm', color: 'white' });
basketModule.addItem(3);
basketModule.addItem(3);
console.log(basketModule.getItemCount());
console.log(basketModule.getProductInfo(0));