// 2. Свертка. Используйте метод reduce в комбинации с concat для свёртки массива массивов в один массив, у которого есть все элементы входных массивов.

var arrays = [[1, 2, 3], [4, 5], [6]];

arrays = arrays.reduce(function(x, y){
    return x.concat(y);
});

console.log(arrays);