﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BusinessObjects
{
    public class BookingReservationEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public DateTime CreateAt { get; set; }
        public string BookingStatus { get; set; }
        public string PaymentStatus { get; set; }
        public float TotalPrice { get; set; }
        public string Notes { get; set; }

        public ICollection<TransactionEntity> Transactions { get; set; }
        public ICollection<BookingDetailEntity> BookingDetails { get; set; }
    }

}
