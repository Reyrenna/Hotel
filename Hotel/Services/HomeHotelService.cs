//using Hotel.Data;
//using Hotel.Models;
//using Hotel.ViewModels;
//using Microsoft.EntityFrameworkCore;
//using System.Diagnostics;
//using System.Security.Claims;
//using Microsoft.AspNetCore.Identity;

//namespace Hotel.Services
//{
//    public class HomeHotelService
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly LoggerService _loggerService;
//        private readonly UserManager<ApplicationUser> _userManager;
//        public ProductService(ApplicationDbContext context, LoggerService loggerService, UserManager<ApplicationUser> userManager)
//        {
//            this._context = context;
//            this._loggerService = loggerService;
//            this._userManager = userManager;
//        }

//        private async Task<bool> SaveAsync()
//        {
//            try
//            {
//                var rowsAffected = await _context.SaveChangesAsync();

//                if (rowsAffected > 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            catch (Exception ex)
//            {
//                _loggerService.LogError(ex.Message);
//                return false;
//            }
//        }
//    }
//}
