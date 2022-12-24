using BoriskinWebKr.DAO.Contexts;
using BoriskinWebKr.DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BoriskinWebKr.Pages
{
    public class PictureModel : PageModel
    {
        private PictureDbContext _dbContext;
        public List<Picture> _pictures { get; set; }

        public PictureModel(PictureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            _pictures = _dbContext.Pictures.ToList();
        }
    }
}
