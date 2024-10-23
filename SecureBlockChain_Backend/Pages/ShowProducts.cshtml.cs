﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SecureBlockChain_Backend.Data;
using SecureBlockChain_Backend.Models;

namespace SecureBlockChain_Backend.Pages
{
    public class ShowProductsModel : PageModel
    {
        public class MyProduct : ProductInfo
        {
            public string Date { get; set; }
            public string Time { get; set; }
            public MyProduct(ProductInfo pro)
            {
                this.ID = pro.ID;
                this.ProductCreator = pro.ProductCreator;
                this.CreationDate = pro.CreationDate;
                this.ProductID = pro.ProductID;
                this.ProductName = pro.ProductName;
                this.ProductType = pro.ProductType;
                this.Date = JsonConvert.DeserializeObject<DateTime>(pro.CreationDate).ToLongDateString();
                this.Time = JsonConvert.DeserializeObject<DateTime>(pro.CreationDate).ToLongTimeString();
            }
        }
        private readonly BlockChainsDbContext _userContext;
        private readonly BlockChainsDbContext _productInfoDbContext;
        public List<MyProduct> MyProducts;
        public ShowProductsModel(BlockChainsDbContext userDbContext)
        {
            _userContext = userDbContext;
            _productInfoDbContext = userDbContext;
            MyProducts = new List<MyProduct>();
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if(User.Identity.IsAuthenticated)
            {
                string userName = User.FindFirst(ClaimTypes.GivenName).Value;
                var user = await _userContext.UserAccounts.SingleOrDefaultAsync(m => m.UserName == userName);
                if(user!=null)
                {
                    int ID = user.ID;
                    var tempList = await _productInfoDbContext.ProductsInfos.ToListAsync();
                    foreach (var item in tempList)
                    {
                        if(item.ProductCreator==ID)
                        {
                            MyProducts.Add(new MyProduct(item));
                        }
                    }
                    if(MyProducts!=null)
                    {
                        MyProducts.Reverse();
                    }
                    return Page();
                }
                else
                {
                    return RedirectToPage("/Error");
                }
            }
            else
            {
                return RedirectToPage("/Login");
            }
        }
    }
}