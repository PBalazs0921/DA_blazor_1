namespace BlazorApp1.Entities.Dto;

public class ItemUpdateDto
{
    public int Id { get; set; }

    public string Name { get; set; } 

    public int CategoryId { get; set; }

    public int Price { get; set; }
}