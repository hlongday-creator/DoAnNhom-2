﻿namespace DoAnNhom_2.Models.ViewModels
{
	public class UserIndexViewModel
	{
		public List<CartItemModel> CartItems { get; set; }
		public decimal GrandTotal { get; set; }
		public decimal Total { get; set; }
        public decimal Discound { get; set; }
    }
}
