using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.Web.Models
{
	public class CartDetailsDto
	{
#nullable disable
        public int CartDetailsId { get; set; }
        public int CartHeaderId { get; set; }
        public int ProductId { get; set; }
#nullable enable
        public CartHeaderDto? CartHeader { get; set; }
        public ProductDto? Product { get; set; }
        public int Count { get; set; }
    }
}

