// 4.  Расширить прототип Array, добавив к нему метод добавления элемента в начало без использование unshift.

Array.prototype.append = (function(num){
    
    for(var i = this.length-1; i>=0; --i){
        this[i+1] = this[i];
    }
    this[0] = num;
});

var arr = [1,2,3];

arr.append(0);
console.log(arr);