﻿using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class PieRepository: IPieRepository
    {
        private readonly BethanysPieShopDbContext _context;

        public PieRepository(BethanysPieShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _context.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _context.Pies.Include(c => c.Category).Where(
                    p => p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _context.Pies.FirstOrDefault(p => p.PieId == pieId);
        }

    }
}
