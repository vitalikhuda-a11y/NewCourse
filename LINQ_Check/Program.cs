using LINQ_Check.Delivery;
using LINQ_Check.Discounts;
using LINQ_Check.Mappers;
using LINQ_Check.Models;
using LINQ_Check.Services;
using System.ComponentModel;


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

TestDiscounts(products);

static void TestDiscounts(List<ProductDto> products)
{

    var product = products[2];
    List<IDiscountStrategy> discountStrategies = new();

    discountStrategies.Add(new NoDiscount());
    discountStrategies.Add(new PercentageDiscount(15));
    discountStrategies.Add(new FixedAmountDiscount(10));


    foreach (var discount in discountStrategies)
    {
        PriceCalculator.PrintReceipt(product, discount);
    }
}

//списки із замовленнями

List<Order> orderList = new();
orderList.Add(new Order
{
    Product = products[0],
    Discount = new NoDiscount(),
    Shipping = new StandardShipping(),
}
    );


orderList.Add(new Order
{
    Product = products[1],
    Discount = new FixedAmountDiscount(30),
    Shipping = new ExpressShipping(),
}
    );

orderList.Add(new Order
{
    Product = products[2],
    Discount = new PercentageDiscount(10),
    Shipping = new StandardShipping(),
}
    );

orderList.Add(new Order
{
    Product = products[3],
    Discount = new FixedAmountDiscount(10),
    Shipping = new FreeShipping(),
}
    );

var TheBiggestTotal = orderList
    .MaxBy(order => order.GetTotal());

Console.WriteLine("Biggest order:");
Console.WriteLine(TheBiggestTotal.Product.Name);
Console.WriteLine(TheBiggestTotal.GetTotal());


//4б

/*
Якщо додати новий тип доставки PickupShipping, то клас Order міняти не треба,
бо Order працює через інтерфейс IShippingMethod. Треба просто створити новий
клас PickupShipping і описати там назву, ціну та кількість днів доставки.

Якщо PickupShipping доступний тільки для певних міст, то перевірку міста
краще зробити в окремому класі, наприклад у ShippingService.
Тоді Order не буде містити зайву логіку про міста і доставку.

PriceCalculator теж міняти не треба, бо він відповідає тільки за знижки,
а не за доставку.

Якби доставка була зроблена через enum і switch в Order, то при кожній новій
доставці треба було б змінювати Order і додавати новий case у switch.
*/