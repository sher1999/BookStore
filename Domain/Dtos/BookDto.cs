using System.ComponentModel.DataAnnotations;
namespace Domain.Dtos;

public class BookDto
{
 public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Title { get; set; }
    public DateTime PublishDate { get; set; }
    public decimal Price { get; set; }
    public int PageCount { get; set; }
    [Required,MaxLength(100)]
    public string Isbn { get; set; }
    [Required,MaxLength(200)]
    public string Summary { get; set; }
    [Required,MaxLength(100)]
    public string Notes { get; set; }
    public int PublisherId { get; set; }
    public int SubjectId { get; set; }
   public string Publisher { get; set; }
    public string AutherFullName{get;set;}
    
}
