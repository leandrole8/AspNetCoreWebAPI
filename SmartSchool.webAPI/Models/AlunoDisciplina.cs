namespace SmartSchool.webAPI.Models
{
    public class AlunoDisciplina
    {
        
        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public AlunoDisciplina(){}
        public AlunoDisciplina(int alunoID, int disciplinaId)
        {
            this.AlunoID = alunoID;
            this.DisciplinaId = disciplinaId;

        }
    }
}