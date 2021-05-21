//5. Выведите все элементы массива используя рекурсию.

var arr = ['Solnce', 'vishlo', 'iz', 'za', 'tuchi']; 

function recuseLog(someArray){

    if(someArray.length>0){
        console.log(someArray.shift());
        recuseLog(someArray);
    }
}

recuseLog(arr);