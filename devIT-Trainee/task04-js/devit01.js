const myModule = require("./devit-base");

// 1. Напишите функцию cloneDeep таким образом, чтобы она была способна клонировать переданный как параметр объект.

function cloneDeep(someObject){

    var clone = JSON.parse(JSON.stringify(someObject));

    return clone;
}

// поскольку в данных для задания этот объект не имеет в себе функций, можно использовать вариант для JSON-объектов

console.log(cloneDeep(myModule.TEST_DATA));