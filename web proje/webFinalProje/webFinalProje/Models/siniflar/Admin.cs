using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class Admin
	{
		[Key]
		public int Adminid { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string KullaniciAd { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string Sifre { get; set; }
		[Column(TypeName = "char")]
		[StringLength(1)]
		public string Yetki { get; set; }
	}
}