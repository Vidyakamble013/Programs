using CommonLayer.Model;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepositoryLayer
{
   public class RepositoryClass : IEmployeeInterface
    {
        public readonly string connectionString = "Data Source = (localDB)\\local;Initial Catalog = EmployeeManagement; Integrated Security = true;";

        public IEnumerable<ModalClass> GetAllEmpployee()
        {
            List<ModalClass> modalClasses = new List<ModalClass>();

            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("spGetAllEmployee", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while(dataReader.Read())
                {
                    CommonLayer.Model.ModalClass modalClass = new CommonLayer.Model.ModalClass();
                    modalClass.EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]);
                    modalClass.Firstname = dataReader["Firstname"].ToString();
                    modalClass.Lastname =  dataReader["Lastname"].ToString();
                    modalClass.City = dataReader["City"].ToString();
                    modalClass.Contact = dataReader["Contact"].ToString();
                    modalClass.Gender = dataReader["Gender"].ToString();
                    modalClass.Gender = dataReader["Gender"].ToString();

                    modalClasses.Add(modalClass);
                }
                sqlConnection.Close();
            }

            return modalClasses;
        }

        public void AddEmployee(ModalClass modalClass)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spAddEmployee", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Firstname", modalClass.Firstname);
                    sqlCommand.Parameters.AddWithValue("@Lastname", modalClass.Lastname);
                    sqlCommand.Parameters.AddWithValue("@City", modalClass.City);
                    sqlCommand.Parameters.AddWithValue("@Contact", modalClass.Contact);
                    sqlCommand.Parameters.AddWithValue("@Gender", modalClass.Gender);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateRecord(ModalClass modalClass)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeId", modalClass.EmployeeId);
                    sqlCommand.Parameters.AddWithValue("@Firstname", modalClass.Firstname);
                    sqlCommand.Parameters.AddWithValue("@Lastname", modalClass.Lastname);
                    sqlCommand.Parameters.AddWithValue("@City", modalClass.City);
                    sqlCommand.Parameters.AddWithValue("@Contact", modalClass.Contact);
                    sqlCommand.Parameters.AddWithValue("@Gender", modalClass.Gender);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteEmployee(int empId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeId", empId);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public ModalClass GetByEmployeeId(int ? id)
        {
            try
            {
                ModalClass modalClass = new ModalClass();
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    string sqlQuery = "SELECT * FROM EmployeeMaganement WHERE EmployeeId =" + id;
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                    sqlConnection.Open();SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while(dataReader.Read())
                    {
                        modalClass.EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]);
                        modalClass.Firstname = dataReader["Firstname"].ToString();
                        modalClass.Lastname = dataReader["Lastname"].ToString();
                        modalClass.City = dataReader["City"].ToString();
                        modalClass.Contact = dataReader["Contact"].ToString();
                        modalClass.Gender = dataReader["Gender"].ToString();
                        modalClass.Gender = dataReader["Gender"].ToString();
                    }
                    return modalClass;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
