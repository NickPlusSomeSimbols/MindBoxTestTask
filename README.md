• В MindBoxTestTask/FiguresLibrary/Shapes.cs Добавляются фигуры, наследуя интерфейс IShape, и реализуют метод рассчета площади. <br />
• Метод IsTriangleRight по теореме Пифагора проверяет, является ли трегольник прямоугольным. <br />
• В каждом тесте по три набора входных данных. <br /> <br />
Ответ на Второе задание: <br />

  SELECT p.ProductName, c.CategoryName <br />
    &emsp;FROM Products p <br />
    &emsp;LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId <br />
    &emsp;LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId; 
 
