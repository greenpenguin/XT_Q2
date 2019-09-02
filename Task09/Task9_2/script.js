'use strict';

document.getElementById('btn').addEventListener('click', count);
function count() {
    var str = document.getElementById('txt').value;
    var result, i;
    str = str.split(/([-,+,/,*])/);
    for (i = 0; i <= str.length - 1; i++) {
        if (str[i] === '+') {
            str[i + 1] = parseFloat(str[i - 1]) + parseFloat(str[i + 1]);
            result = str[i + 1];
        }
        if (str[i] === '-') {
            str[i + 1] = parseFloat(str[i - 1]) - parseFloat(str[i + 1]);
            result = str[i + 1];
        }
        if (str[i] === '/') {
            str[i + 1] = parseFloat(str[i - 1]) / parseFloat(str[i + 1]);
            result = str[i + 1];
        }
        if (str[i] === '*') {
            str[i + 1] = parseFloat(str[i - 1]) * parseFloat(str[i + 1]);
            result = str[i + 1];
        }
    }
    document.getElementById("output").innerHTML = result;
}
