public class Order
{
    public int OrderID { get; set; }
    public string CustomerID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime? ShippedDate { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual Customer Customer { get; set; }
}

