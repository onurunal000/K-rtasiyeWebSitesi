using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class Faturalar
	{
		[Key]
		public int Faturaid { get; set; }
		public virtual Faturalar Faturalars { get; set; }
		[Column(TypeName = "char")]
		[StringLength(1)]
		public string FaturaSeriNo { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(6)]
		public string FaturaSiraNo { get; set; }
		public DateTime Tarih { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(60)]
		public string VergiDairesi { get; set; }
		[Column(TypeName = "char")]
		[StringLength(5)]
		public string Saat { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string TeslimEden { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string TeslimAlan { get; set; }
		public ICollection<FaturaKalem> FaturaKalems { get; set; }
		public decimal Toplam { get; set; }
	}
}