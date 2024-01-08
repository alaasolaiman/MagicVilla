using MagicVilla_WebAPI.Models.Dto;

namespace MagicVilla_WebAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> VillaList { get; set; } = new List<VillaDTO>()
            {
                new VillaDTO() {Id= 1, Name="Pool View"},
                new VillaDTO() {Id= 2, Name="Beach View"},

            };
    }
}
