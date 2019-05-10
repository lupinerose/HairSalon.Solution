using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{

    public class Stylist
    {
        private int _id;
        private string _name;
        // private string _services;
        private int _yearsExperience;
        private string _workDays;

        public Stylist(string name, int yearsExperience, string workDays, int id = 0)
        {
            _name = name;
            _yearsExperience = yearsExperience;
            _workDays = workDays;
            _id = id;
        }

        public string Name { get => _name; set => _name = value; }
        public int YearsExperience { get => _yearsExperience; set => _yearsExperience = value; }
        public string WorkDays { get => _workDays; set => _workDays = value; }
        public int Id { get => _id; set => _id = value; }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM stylists;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static List<Stylist> GetAll()
        {
            List<Stylist> allStylists = new List<Stylist> {};
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM stylists;";
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            while(rdr.Read())
            {
                int stylistId = rdr.GetInt32(0);
                string stylistName = rdr.GetString(1);
                int stylistYearsExp = rdr.GetInt32(2);
                string stylistWorkDays = rdr.GetString(3);
                Stylist newStylist = new Stylist(stylistName, stylistYearsExp, stylistWorkDays, stylistId);
                allStylists.Add(newStylist);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allStylists;
        }

        public override bool Equals(System.Object otherStylist)
        {
            if (!(otherStylist is Stylist))
            {
                return false;
            }
            else
            {
                Stylist newStylist = (Stylist) otherStylist;
                bool idEquality = this.Id == newStylist.Id;
                bool nameEquality = (this.Name == newStylist.Name);
                bool yearsExperienceEquality = this.YearsExperience == newStylist.YearsExperience;
                bool workDaysEquality = this.WorkDays == newStylist.WorkDays;
                return (idEquality && yearsExperienceEquality && nameEquality && workDaysEquality);
             }
        }

        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO stylists (name, years_of_experience, work_days) VALUES (@name, @yearsExperience, @workDays);";
            MySqlParameter name = new MySqlParameter();
            name.ParameterName = "@name";
            name.Value = this._name;
            cmd.Parameters.Add(name);
            MySqlParameter yearsExperience = new MySqlParameter();
            yearsExperience.ParameterName = "@yearsExperience";
            yearsExperience.Value = this._yearsExperience;
            cmd.Parameters.Add(yearsExperience);
            MySqlParameter workDays = new MySqlParameter();
            workDays.ParameterName = "@workDays";
            workDays.Value = this._workDays;
            cmd.Parameters.Add(workDays);
            cmd.ExecuteNonQuery();
            _id = (int) cmd.LastInsertedId;
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }



    }

}
