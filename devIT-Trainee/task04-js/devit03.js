/*    3.  Допустим, у вас есть функция primitiveMultiply, которая в 50% случаев перемножает 2 числа,
 а в остальных случаях выбрасывает исключение типа MultiplicatorUnitFailure. Напишите функцию, обёртывающую эту,
  и просто вызывающую её до тех пор, пока не будет получен успешный результат*/

  function MultiplicatorUnitFailure() {}
  function primitiveMultiply(a, b) {
    if (Math.random() < 0.5)
      return a * b;
    else
      throw new MultiplicatorUnitFailure();
  }
  function reliableMultiply(a, b) {
    
    var x;
    while(!x){
        try{
            x = primitiveMultiply(a,b);
        } catch(err){
            if(!err instanceof MultiplicatorUnitFailure){
                throw err;
            }
        }
    }
    
    return x;

  }
  
  console.log(reliableMultiply(8, 8)); 