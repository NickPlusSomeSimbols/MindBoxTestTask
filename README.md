• В MindBoxTestTask/FiguresLibrary/Shapes.cs Добавляются фигуры и наследуют интерфейс IShape и реализуют метод рассчета площади. <br />
• Метод IsTriangleRight по теореме Пифагора проверяет, является ли трегольник прямоугольным. <br />
• В каждом тесте по три набора входных данных. <br /> <br />
Ответ на Второе задание: <br />

  SELECT p.ProductName, c.CategoryName
    FROM Products p
    LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
    LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId;
 
