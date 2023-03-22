namespace WpfApp.Models
{
    internal class CaseAddModel // En speciell modell för att (göra representationen), bara för det man vill ta in..
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public UserModel User { get; set; } = null!;

    }
}
