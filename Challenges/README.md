### Retos ###

1. Crear una función que genere un arreglo y a la hora de imprimir devuelve el índice de este. 
El siguiente es un ejemplo del llamado en Javascript (puedes hacerlo en el lenguaje de tu preferencia):

```
var a = generate(5);
console.log(a[0]()); // Result is 0
console.log(a[1]()); // Result is 1
```

Para la implementación de este primero reto se utilizó TypeScript v3.3.3. 

```
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
```

Para correr la aplicación deberá tener instalado TypeScript

```
> npm install -g typescript
```

Porteriomente, deberá compilar su código TypeScript, puede abrir el Terminal y escribir tsc index.ts. 
Esto compilará y creará un nuevo archivo JavaScript index.js.

```
> tsc index.ts
```

Finalmente, podrá ejecutar el archivo index.js generado, con node.

```
> node index.js
```

2. **Sherlock and Anagrams**. Se debe solucionar y subir la solución al siguiente problema de HackerRank.
