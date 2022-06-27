using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class FaturaKalem
	{
		[Key]
		public int FaturaKalemid { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string Aciklama { get; set; }
		public int Miktar { get; set; }
		public decimal BirimFiyat { get; set; }
		public decimal Tutar { get; set; }
		public int Faturaid { get; set; }
		public Faturalar Faturalar { get; set; }
	}
}