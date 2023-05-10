namespace Web_Fia41_HoeffkenV_Web_QuizGame.Models
{
    public class Fraktion
    {
        public int FID { get; set; }

        public string description { get; set; }

        public string IconDirection { get; set; }

        public virtual ICollection<Question> Questions{ get; set; }

    }
}
