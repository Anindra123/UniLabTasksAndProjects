using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Week10HomePrac
{
    class DBAcess
    {
        public static bool SignUPProjectMember(string firstName, string LastName,
            string email, string password)
        {
            string query = $"insert into PMember_TBL (PMember_FirstName,PMember_LastName" +
                $",PMember_Password,PMember_Email) values ('{firstName}','{LastName}','{email}'," +
                $"'{password}');";
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        public static ProjectMember SignInProjectMember(string email, string password)
        {
            string query = $"select * from PMember_TBL where " +
                $"PMember_Email = '{email}' AND " +
                $"PMember_Password = '{password}';";
            ProjectMember member = new ProjectMember();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        member.FirstName = r["PMember_FirstName"].ToString();
                        member.LastName = r["PMember_LastName"].ToString();
                        member.Email = r["PMember_Email"].ToString();
                        member.password = r["PMember_Password"].ToString();
                    }
                }
            }
            return member;
        }

        public static List<ProjectGroup> GetProjectGroups()
        {
            string query = "select * from PGroup_TBL";
            List<ProjectGroup> gList = new List<ProjectGroup>();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.HasRows)
                    {
                        return gList;
                    }
                    while (r.Read())
                    {
                        ProjectGroup group = new ProjectGroup();
                        group.PGroup_ID = Convert.ToInt32(r["PGroup_ID"].ToString());
                        group.PGroup_Name = r["PGroup_Name"].ToString();
                        group.MembersCount = Convert.ToInt32(r["PGroup_MembersCount"].ToString());
                        gList.Add(group);
                    }
                }
            }
            return gList;

        }
        public static ProjectGroup GetGroup(int id)
        {
            string query = $"select * from PGroup_TBL where" +
                $" pgroup_id = '{id}';";
            ProjectGroup group = new ProjectGroup();
            using (SqlConnection conn = new SqlConnection(DBConnection.GetConnString()))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Connection.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        group.PGroup_Name = r["PGroup_Name"].ToString();
                    }
                }
            }
            return group;
        }

    }
}
