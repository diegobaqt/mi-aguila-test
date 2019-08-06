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

2. **Sherlock and Anagrams**. Se debe solucionar y subir la solución al siguiente problema de HackerRank. [https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem](https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem)

La solución para este reto se implementó en C#.

```
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var n = Convert.ToInt32(Console.ReadLine());

		for (var i = 0; i <= n; i++)
		{
			var str = Console.ReadLine();
			if (string.IsNullOrWhiteSpace(str)) throw new NullReferenceException("Invalid value");

			var result = 0;

			for (var j = 1; j < str.Length; j++)
			{
				var dictionary = new Dictionary<string, int>();
				for (var k = 0; k < str.Length - j + 1; k++)
				{
					var substr = str.Substring(k, j).ToCharArray();
					Array.Sort(substr);
					var substrSorted = string.Join("", substr);

					var keys = dictionary.Keys.ToList();
					if (keys.Contains(substrSorted)) dictionary[substrSorted] += 1;
					else dictionary.Add(substrSorted, 1);

					result += dictionary[substrSorted] - 1;
				}
			}
			Console.WriteLine(result);
		}
	}
}
```

Si no cuenta con un compilador para este archivo, podrá copia y pegar su contenido en [https://dotnetfiddle.net/](https://dotnetfiddle.net/) y podrá probar su implementación de forma *online*

