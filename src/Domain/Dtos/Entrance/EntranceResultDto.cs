using System;
using System.ComponentModel.DataAnnotations;
using Domain.Dtos.Category;
using Domain.Dtos.Entity;
using Domain.Dtos.Wallet;

namespace Domain.Dtos.Entrance
{
    public class EntranceResultDto : EntityResultDto
    {
        public EntranceResultDto()
        {
            Wallet = new WalletResultDto();
            Category = new CategoryResultDto();
        }

        public string Description { get; set; }

        public string Ticker { get; set; }

        public int Type { get; set; }

        public string Observation { get; set; }

        [DataType(DataType.Currency)]
        public double Value { get; set; }

        [Display(Name = "Wallet")]
        public Guid WalletId { get; set; }
        public WalletResultDto Wallet { get; set; }

        [Display(Name = "Category")]
        public Guid CategoryId { get; set; }
        public CategoryResultDto Category { get; set; }
    }
}
