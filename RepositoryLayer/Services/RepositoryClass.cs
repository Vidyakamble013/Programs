namespace RepositoryLayer
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class RepositoryClass
    {
         
     public string ConnectionString { get; }

        public IEnumerable<CommonLayer.Model.ModalClass> GetAllEmployee()
        {
          try
            {
              List<CommonLayer.Model.ModalClass> modalClasses = new List<CommonLayer.Model.ModalClass>();
              using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
              {
                 SqlCommand sqlCommand = new SqlCommand("spGetAllEmployee", sqlConnection);
                 sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                 sqlConnection.Open();
                 SqlDataReader dataReader = sqlCommand.ExecuteReader();

                  while (dataReader.Read())
                  {
                    CommonLayer.Model.ModalClass modal = new CommonLayer.Model.ModalClass();
                    modal.EmployeeId = Convert.ToInt32(dataReader["EmployeeId"]);
                    modal.Firstname = dataReader["Firstname"].ToString();
                    modal.Lastname = dataReader["Lastname"].ToString();
                    modal.City = dataReader["City"].ToString();
                    modal.Contact = dataReader["Contact"].ToString();
                    modal.Gender = dataReader["Gender"].ToString();
                    modalClasses.Add(modal);
                  }
                    sqlConnection.Close();
                }
                return modalClasses;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void AddEmployee(CommonLayer.Model.ModalClass modalClass)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spAddEmployee", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

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

        public void UpdateEmployee(CommonLayer.Model.ModalClass modalClass)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spUpdateEmployee", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

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

        public void DeleteEmployee(int EmployeeId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeId", EmployeeId);
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

        public void GetByEmployeeId(int EmployeeId)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand("spGetEmployeeId", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    sqlConnection.Open();
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



