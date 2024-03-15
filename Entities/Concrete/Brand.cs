namespace Entities.Concrete;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public bool Status { get; set; }
}
