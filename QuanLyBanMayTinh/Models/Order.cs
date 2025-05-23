﻿namespace QuanLyBanMayTinh.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public DateTime OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TotalAmount { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }

}
