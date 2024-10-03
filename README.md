В MindBoxTestTask/FiguresLibrary/Shapes.cs Добавляются фигуры и наследуют интерфейс IShape и реализуют метод рассчета площяди
Метод IsTriangleRight по теореме Пифагора проверяет является ли трегольник прямоугольным
В каждом тесте по три ынабора входных данных 

Ответ на Второе задание:

  SELECT p.ProductName, c.CategoryName
    FROM Products p
    LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
    LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId;
 
