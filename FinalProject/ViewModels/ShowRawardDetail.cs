namespace FinalProject.ViewModels
{
    public class ShowRawardDetail
    {
        public int ShowRawardItemId { get; set; }
        public int ShowRawardId { get; set; }
        public string Name { get; set; } = null!;
        public string RawardLevel { get; set; } = null!;
        public bool IsJackpot { get; set; }
        public int Num { get; set; }
        public int LaveNum { get; set; }
        public string Image { get; set; } = null!;
    }
}
