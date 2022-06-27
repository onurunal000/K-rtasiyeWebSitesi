using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class Cariler
	{
		[Key]
		public int Cariid { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30, ErrorMessage = "En fazla 30 karakter girebilirsin.")]
		public string CariAd { get; set; }
		[Column(TypeName = "varchar")]
		[Required(ErrorMessage = "Bu alanı boş geçemezsin.")]
		public string CariSoyad { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(13)]
		public string CariSehir { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(50)]
		public string CariMail { get; set; }
        [Column(TypeName = "Varchar")]
		[StringLength(20)]
		public string CariSifre { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }
		public bool Durum { get; set; }
	}
}