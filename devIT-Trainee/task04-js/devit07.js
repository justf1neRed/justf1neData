//  7. Сделать функцию поиска значений в массиве.

const myModule = require("./devit-base");

function array_find(arr, key,){

    for(let i = 0; i<arr.length; i++){
        if(arr[i]===key){
            console.log(key);
            break;
        } 
    }
}

//let result = array_find(myModule.TEST_DATA, '/^raf.*/i');
// Вариант с использованием регулярного выражения мне, к сожалению, реализовать не удалось

let resutl2 = array_find(myModule.TEST_DATA, "Rafshan");



