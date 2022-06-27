using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webFinalProje.Models.siniflar
{
	public class Departman
	{
		[Key]
		public int Departmanid { get; set; }
		[Column(TypeName = "varchar")]
		[StringLength(30)]
		public string DepartmanAdi { get; set; }
		public ICollection<Personel> Personels { get; set; }
		public bool Durum { get; set; }
	}
}