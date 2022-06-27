using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class Personel
	{
		[Key]
		public int Personelid { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		[Display(Name = "Personel Adı")]
		public string PersonelAd { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		[Display(Name = "Personel Soyadı")]
		public string PersonelSoyad { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(250)]
		[Display(Name = "Görsel")]
		public string PersonelGorsel { get; set; }
		public ICollection<SatisHareket> SatisHarekets { get; set; }
		public int Departmanid { get; set; }
		public virtual Departman Departman { get; set; }

	}
}