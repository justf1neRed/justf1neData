const myModule = require("./devit-base");

function array_pluck(arr, path){

    console.log(arr.map(o => o[path]));
}

let result = array_pluck(myModule.TEST_DATA3, 'name');

let result2 = array_pluck(myModule.TEST_DATA3, 'skills.php');