namespace MAS_Implementacja.Models
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;

    public partial class Szkolenie
    {
        string constr = ConfigurationManager.ConnectionStrings["Regular"].ConnectionString;

        public void UsunSzkolenie(Szkolenie szkolenie)
        {
            string DeleteSchooling = "DELETE FROM Szkolenie Where IdSzkolenie = '" + szkolenie.IdSzkolenie + "'";

            try
            {
                using (SqlConnection conn = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(DeleteSchooling, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void PrzerwijSzkolenie(Szkolenie szkolenie)
        {
            DataSzkolenia = szkolenie.DataSzkolenia;
        }
        public void ZmienInstruktora(Instruktor instruktor)
        {
            this.Instruktor = instruktor;
        }
        public void ZakonczSzkolenie(Szkolenie szkolenie)
        {
            szkolenie.CzasTrwania = 0;
        }

        public int IdSzkolenie { get; set; }
        public int Instruktor_IdInstruktor { get; set; }
        public string Nazwa { get; set; }
        public System.DateTime DataSzkolenia { get; set; }
        public int IloscOsob { get; set; }
        public decimal CzasTrwania { get; set; }
        public decimal Koszt { get; set; }
    
        public virtual Instruktor Instruktor { get; set; }
    }
}
