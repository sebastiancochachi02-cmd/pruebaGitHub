using oppsample.Procurement.Domain.Model.ValueObjects;
using oppsample.Shared.Domain.ValueObjects;

namespace oppsample.Procurement.Domain.Model.Agreggates;
/// <summary>
/// represetn a purhase order items aggregate in the procurment bounded context
/// encapsukates the details of a single item in a purchase order incluing the product id
/// </summary>
public class PurchaseOrderItem
{
    public Productid Productid  { get; }
    public int Quantity { get; }
    public Money UnitPrice { get; }
/// <summary>
/// 
/// </summary>
/// <param name="productid"></param>
/// <param name="quantity"></param>
/// <param name="unitPrice"></param>
/// <exception cref="ArgumentNullException"></exception>
/// <exception cref="ArgumentException"></exception>
    internal PurchaseOrderItem(Productid productid, int quantity, Money unitPrice)
    {
        Productid = productid ?? throw new ArgumentNullException(nameof(productid));
        Quantity = quantity > 0 ? quantity : throw new ArgumentException(nameof(quantity));
        UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
        
    }
/// <summary>
/// Calculates the total price od the item.
/// </summary>
/// <returns></returns>
    public Money CalculateItemTotal()=> UnitPrice.Multiply(Quantity);
    
    
}