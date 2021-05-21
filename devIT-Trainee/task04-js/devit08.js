// 8. Сделать функцию которая обрезает массив до указанного значения.

const myModule = require("./devit-base");

function array_skip_until(arr, key){

    for(let i = 0; i<arr.length; i++){
        if(arr[i] === key){
            var newArr = arr.slice(i);
            console.log(newArr);
            break;
        }
    }
}

let result = array_skip_until(myModule.TEST_DATA, 2);

let result2 = array_skip_until(myModule.TEST_DATA, "Rafshan")

let result3 = array_skip_until(myModule.TEST_DATA, "asd")

