var MathematicalEquasions = (function () {

    var counter = 0;


    function increaseCounter() {
        counter++;
    }

    function decreaseCounter() {
        counter--
    }

    function showResult() {
        return counter;
    }


    return {
        add: increaseCounter,
        dec: decreaseCounter,
        sum: showResult
    }
})();

MathematicalEquasions.add()
MathematicalEquasions.add()
MathematicalEquasions.add()


function printResult() {
    console.log(MathematicalEquasions.sum());
}

printResult();
