﻿namespace eShopSolution.Application.Dtos
{
    public class PageViewModel<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}
