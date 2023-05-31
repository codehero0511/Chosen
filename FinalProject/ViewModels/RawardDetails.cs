using System.ComponentModel.DataAnnotations;
using FinalProject.Models;

namespace FinalProject.ViewModels
{
    public class RawardDetails
    {
        //這邊主要是用來協助 RawardItems 在啟用 Create 時，在 Create 失敗時會造成 @TempData 失效
        public int RawardId { get; set; }
        public int RawardItemId { get; set; }
        public string Name { get; set; } = null!;
        public string RawardLevel { get; set; } = null!;
        public bool IsJackpot { get; set; }
        public int Num { get; set; }
        public string Image { get; set; } = null!;

    }

    
}
