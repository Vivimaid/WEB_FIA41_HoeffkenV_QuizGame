namespace Web_Fia41_HoeffkenV_Web_QuizGame.Models
{
    public class NNQF
    {
        public int QFID { get; set; }

        public int FID { get; set; }

        public int KID { get; set; }

        public List<Fraktion> Fraktions { get; } = new();

        public List<Question> Questions { get; } = new();
        public Question Question { get; set; }

        public Fraktion Fraktion { get; set; }
    }
}
