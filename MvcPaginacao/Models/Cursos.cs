using System;

namespace MvcPaginacao.Models
{
    public class Cursos
    {
        public int CursoId { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Curso { get; set; }
        public decimal Valor { get; set; }
        public int AutorId { get; set; }
    }
}