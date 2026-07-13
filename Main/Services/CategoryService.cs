using Main.Data;
using Main.Entities;
using Main.DTOs;
using Microsoft.EntityFrameworkCore;

//controller doğrudan veritabanına bağlanmayacak her şeyi bu servis üzerinden yapacak
//category controller classından gelen isteği alacak ve DbContext ile db işlemlerini yapacak
//bu servis DbContext'i Dependency Injection ile kullanacak 


namespace Main.Services
{
    public class CategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        // entity yerine DTO dön
        public async Task<List<CategoryResponseDto>> GetAllAsync()
        {
            return await _context.Categories
                .Select(c => new CategoryResponseDto { Id = c.Id, Name = c.Name })
                .ToListAsync();
        }

        // entity yerine DTO al-mapping-
        //controller'dan category dto alıp -> Category classına mapping
        public async Task AddAsync(CategoryCreateDto dto)
        {
            var category = new Category { Name = dto.Name };
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
    }
}
