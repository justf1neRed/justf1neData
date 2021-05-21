/* 12. Создать функцию которая создает объект на основании двух представленных 
массивов используя один как ключи, а другой как значения. Не подходящие ключи массивов должны быть исключены.*/

const myModule = require("./devit-base");

function array_combine(keys, values){

    var newArray = {}, keycount = keys.length, i;

    for(i=0; i<keycount; i++){

        if(typeof keys[i] !== 'boolean'){
            newArray[keys[i]]= values[i];
        }
    }

    console.log(newArray);

}

array_combine(myModule.TEST_DATA, myModule.TEST_DATA2);