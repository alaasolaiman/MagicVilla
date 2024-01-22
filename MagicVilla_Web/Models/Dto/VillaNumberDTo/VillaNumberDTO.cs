﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto.VillaNumberDTo
{
    public class VillaNumberDTO
    {
        [Required]
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public string SpecialDetails { get; set; }
    }
}
