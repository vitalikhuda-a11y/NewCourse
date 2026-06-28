using LINQ_Check.Mappers;


var rawProducts = TestData.RawProducts;
var rawOrders = TestData.RawOrders;


var products = ProductMapper.ToDtoList(rawProducts);
var orders = OrderMapper.ToDtoList(rawOrders);

//1 запит

var AvailableProducts = products
.Where(products => products.IsAvailable == true)
.OrderBy(products => products.Price)
.ToList(); // результат став списком


// 2 запит
var ElectronicUnderFiveHundred = products
  .Where(products => products.Category == "Electronics" && products.Price < 500)
  .ToList();


//3 запит

var AveragePrice = products
  .GroupBy(product => product.Category)
  .ToDictionary(group => group.Key, group => group.Average(product => product.Price));

//4 запит

var TheMostExpensive = products
  .GroupBy(product => product.Category)
  .Select(group => group.MaxBy(product => product.Price)) // group -- група продуктів
  .ToList();

// 5 запит

var UnAvailable = products.Count(products => products.IsAvailable == false);

//другий спосіб:

//int UnAvailable = 0;
//foreach (var product in products) {
//  if (product.IsAvailable == false)
//  {
//    UnAvailable++;
//  }
//}


// 1 запит (2)

var ShippedOrders = orders
 .Where(orders => orders.Status == OrderStatus.Shipped)
 .OrderBy(orders => orders.CreatedAt)
.ToList();

// 2 запит (2)

var AmountOrders = orders
  .GroupBy(orders => orders.Status)
  .ToDictionary(group => group.Key, group => group.Count());


//3 запит (2)

var OrderOne = orders
  .Where(orders => orders.ProductIds.Contains(1));


//4 запит (2)

var CancelOrder = rawOrders // працюємо з сирою, бо в Order.DTO немає CustomerId
    .Where(order => order.Status == "cancelled")
    .Select(order => order.CustomerId)
    .Distinct(); // прибираєм дублікати, якщо 1 клієнт зустрінеться декілька разів


// 4 завдання (a)

var OrderShipped = orders
  .Where(order => order.Status == OrderStatus.Shipped)
  .Select(order => new
  {

    CustomerName = order.CustomerName,
    TotalSum = products
    .Where(product => order.ProductIds.Contains(product.Id))
    .Sum (product => product.Price)

  }
  );

// 4 завдання (b)

var NeverCancel = orders
  .Where(order => !orders.Any(otherOrders => otherOrders.CustomerName == order.CustomerName && otherOrders.Status == OrderStatus.Cancelled)) // для цього клієнта немає жодного cancelled-замовлення
  .Select(order => order.CustomerName)
  .Distinct();

// 4 завдання (c)


// Select використовується, коли з одного елемента потрібно отримати один результат.
// Наприкла: з одного order отримати один CustomerName.
// orders.Select(order => order.ProductIds)
//Резултат:
//[1, 3]
//[2, 4, 6]
//[5]
//[1, 2]
//[8]


// SelectMany використовується, коли всередині одного елемента є колекція і її потрібно розгорнути в один загальний список.
// Наприклад: у кожному order є ProductIds,тому orders.SelectMany(order => order.ProductIds)
// розгортає всі ProductIds з усіх замовлень в один список.
// Результат
//1
//3
//2
//4
//6
//5
//1
//2
//8
