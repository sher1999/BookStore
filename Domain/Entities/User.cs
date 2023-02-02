namespace Domain.Entities;

public class User:Person
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
  public User()
  {
    
  }
    public User(int id, string email, string password,string firstname, string lastname):base(firstname,lastname) 
    {
        Id = id;
        Email = email;
        Password = password;
    }
    public List<Review> Reviews { get; set; }
}