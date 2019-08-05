function generate(x: number) {
   var array =  new Array(x);
   for(let i = 0; i < array.length; i++){
       array[i] = () => i ;
   }
   return array;
}

var a = generate(5);
console.log(a[0]());
console.log(a[1]());