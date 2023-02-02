using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Net;
using Domain.Wrapper;


namespace Infrastructure.Service;


public class Get1Service:SeedData
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public Get1Service(DataContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


     public async Task<Response<List<BookDto>>> Get()
    {
        var List = (
            from b in _context.Books
            join ba in _context.AuthorBooks on b.Id equals ba.BookId
            join a in _context.Authors on ba.AuthorId equals a.Id
            join p in _context.Publishers on b.PublisherId equals p.Id
            select new BookDto
            {
                Id = b.Id,
                Isbn = b.Isbn,
                Title = b.Title,
                Publisher = p.Name,
                AutherFullName=string.Concat(a.Firstname," ", a.Lastname)
            }
            );
        
        
    }
}