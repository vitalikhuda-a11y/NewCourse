using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Check.Mappers
{
  public static class OrderMapper
  {
    public static OrderDto ToDto(RawOrder raw) => new()
    {
      OrderId = raw.OrderId,
      CustomerName = raw.CustomerName ?? "Unknown",
      ProductIds = raw.ProductIds != null
      ? raw.ProductIds.AsReadOnly()
      : Array.Empty<int>(),
      CreatedAt = raw.CreatedAt,
      Status = raw.Status switch
      {
        "pending" => OrderStatus.Pending,
        "shipped" => OrderStatus.Shipped,
        "cancelled" => OrderStatus.Cancelled,
        _ => OrderStatus.Pending

      }

    };
      public static List<OrderDto> ToDtoList(List<RawOrder> raws)
    {
      List<OrderDto> result = new();
      foreach (RawOrder raw in raws) {
        result.Add(ToDto(raw));
    }
      return result;

  }
  }
}
