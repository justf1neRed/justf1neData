// 10. Сделать функцию которая возвращает уникальные элементы массива.

const myModule = require("./devit-base");

function array_unique(arr){

    var resultArray = [];

    for(let str of arr){
        if(!resultArray.includes(str)){
            resultArray.push(str);
        }
    }
    
    console.log(resultArray);
}

let result = array_unique(myModule.TEST_DATA.concat(myModule.TEST_DATA2));

