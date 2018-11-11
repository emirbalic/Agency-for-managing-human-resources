using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Servis.Util
{
    public class ExceptionHandler
    {
        public static void HandleException(EntityException e)
        {
            SqlException greska = (SqlException) e.InnerException;

            switch (greska.Number)
            {
               
                case 2627:
                    throw throwNewStandardException(greska);

                dafault:
                    throw new Exception(greska.Message);
            }

        }

        private static ConstraintException throwNewStandardException(SqlException greska)
        {
            int start = greska.Message.IndexOf("'");
            int end = greska.Message.IndexOf("'", start + 1);
            string newMessage = greska.Message;
            if (start > 0 && end > 0)
            {
                string constraintName = greska.Message.Substring(start + 1, end - start - 1);
                switch (constraintName)
                {
                    case "CS_KorisnickoImeKlijenti":
                     newMessage = "username_con";
                        break;
                    case "CS_EmailKlijenti":
                        newMessage = "email_con";
                        break;
                    case "CS_NazivSkolskaSprema":
                        newMessage = "strucna_con";
                        break;
                    case "CS_NazivTipAktivnosti":
                        newMessage = "tipAk_con";
                        break;
                    case "CS_NazivStruka ":
                        newMessage = "struka_con";
                        break;
                    case "CS_NazivMjesta ":
                        newMessage = "nazivMjesta_con";
                        break;
                    case "CS_NazivDrzave ":
                        newMessage = "nazivDrz_con";
                        break;
                    case "CS_NazivUloge":
                        newMessage = "uloga_con";
                        break;
                    case "CS_Email":
                        newMessage = "email_con";
                        break;
                } 
            }
            return new ConstraintException(newMessage);
        }
    }
}
