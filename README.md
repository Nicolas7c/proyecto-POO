# Compra de Entradas - Proyecto POO en C#

Programa de consola en C# que calcula el valor a pagar por la compra de entradas a un espectáculo. Se pueden comprar **máximo 4 entradas** y el descuento depende de la cantidad:

| Entradas | Descuento |
|----------|-----------|
| 1        | 0%        |
| 2        | 10%       |
| 3        | 15%       |
| 4        | 20%       |

El precio de cada entrada es de **$25.000**.

## Conceptos de POO aplicados

- **Clase:** `Espectaculo`, que modela la lógica de compra de entradas.
- **Atributo encapsulado:** `PrecioEntrada`, con `private set` para protegerlo.
- **Constructor:** inicializa el precio y valida que sea mayor que cero.
- **Métodos:** `ObtenerDescuento`, `CalcularSubtotal` y `CalcularTotal`.
- **Ciclo `while`:** valida que el usuario ingrese una cantidad entre 1 y 4.
- **Ciclo `for`:** muestra cada entrada comprada.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (el proyecto usa .NET 10)
- Visual Studio Code (opcional)

## Cómo ejecutarlo

1. Descargar el proyecto desde **Code > Download ZIP** y descomprimirlo.
2. Abrir una terminal en la carpeta del proyecto.
3. Ejecutar:

   dotnet run

4. Ingresar la cantidad de entradas (1 a 4) y el programa mostrará el detalle, el descuento y el total a pagar.

## Ejemplo de salida

    ========================================
           COMPRA DE ENTRADAS
    ========================================
    Precio por entrada: $25.000,00
    ¿Cuántas entradas desea comprar? (1 a 4): 3

    Cantidad de entradas: 3
    Subtotal:             $75.000,00
    Descuento (15 %):     -$11.250,00
    TOTAL A PAGAR:        $63.750,00

## Autor

Nicolas C - Actividad de Programación Orientada a Objetos
