﻿using AutoMapper;
using ButikAPI.Data;
using ButikAPI.DTOs;
using ButikAPI.Interfaces;
using ButikAPI.Models;
using ButikAPI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace ButikAPI.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly IMapper _mapper;

        public ProductRepository(DataContext context, IMapper mapper) : base(context)
        {
            this._mapper = mapper;
        }

        public async Task<List<ProductViewModel>> GetProductWithHighLowPrice(FilterDto filterDto)
        {
            var product = await _context.Products.OrderBy(m => m.Price).ToListAsync();
            if (filterDto.IsHigh)
            {
                product = product.OrderByDescending(m => m.Price).ToList();
            }

            return _mapper.Map<List<ProductViewModel>>(product);
        }

        public async Task<List<ProductViewModel>> GetTopTen(FilterDto filterDto)
        {
            var productIds = await _context.Transactions.Where(m => m.BranchId == filterDto.BranchId && m.TransactionDate.Month == filterDto.Month)
                .GroupBy(m => m.ProductId)
                .Select(m => new
                {
                    ProductId = m.Key,
                    Total = m.Count()
                })
                .OrderByDescending(m => m.Total)
                .Take(10)
                .Select(m => m.ProductId)
                .ToListAsync();

            var products = await _context.Products.Where(m => productIds.Contains(m.Id)).ToListAsync();

            return _mapper.Map<List<ProductViewModel>>(products);
        }
    }
}
