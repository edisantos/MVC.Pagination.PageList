using MvcPaginacao.Conexao;
using MvcPaginacao.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MvcPaginacao.Domain
{
    public class CursosDomain : DataConexo
    {
        public List<Cursos> ListaCursos()
        {
            OpenCon();
            try
            {
                string strSql = string.Format(@"SELECT * FROM Cursos");
                List<Cursos> list = new List<Cursos>();
                using (cmd = new SqlCommand(strSql, con))
                {

                    using (Dr = cmd.ExecuteReader())
                    {
                        Cursos mod = null;
                        while (Dr.Read())
                        {
                            mod = new Cursos();
                            mod.CursoId = Convert.ToInt32(Dr["CursoId"]);
                            mod.DataRegistro = Convert.ToDateTime(Dr["DataRegistro"]);
                            mod.Curso = Convert.ToString(Dr["Curso"]);
                            mod.Valor = Convert.ToDecimal(Dr["Valor"]);
                            mod.AutorId = Convert.ToInt32(Dr["AutorId"]);
                            list.Add(mod);

                        }

                       
                    }
                    return list;
                }

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseCon();
            }
        }
    }
}