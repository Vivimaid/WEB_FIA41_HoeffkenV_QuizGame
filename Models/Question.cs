namespace Web_Fia41_HoeffkenV_Web_QuizGame.Models
{
    public class Question
    {
        public int QID { get; set; }

        public string QuestionText { get; set; }

        public string Answer { get; set; }

        public string Answer2 { get; set; }

        public string Answer3 { get; set; }

        public string Answer4 { get; set; }

        public int AmmountAnswerd { get; set; }

        public int AmmountRight { get; set; }

        public bool Access { get; set; }

        public List<NNQF> NNQFS { get; } = new();
    }
}
