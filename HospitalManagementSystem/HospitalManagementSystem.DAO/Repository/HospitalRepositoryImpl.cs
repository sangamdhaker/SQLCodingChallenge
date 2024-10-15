using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HospitalManagementSystem.Entity;
using HospitalManagementSystem.Util;
using HospitalManagementSystem.Exception;
using HospitalManagementSystem.DAO.Service;
using System.Configuration;

namespace HospitalManagementSystem.DAO.Repository
{
    public class HospitalRepositoryImpl : IHospitalService
    {
        private SqlConnection connection; // SQL connection to the database

        // Constructor: Initializes the SQL connection using the connection string from app.config
        public HospitalRepositoryImpl()
        {
            // Retrieve the connection string named "HospitalDB" from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalDB"].ConnectionString;
            // Create a new SQL connection with the retrieved connection string
            connection = new SqlConnection(connectionString);
            // Open the SQL connection
            connection.Open();
        }

        // Method to get an appointment by its ID
        public Appointment GetAppointmentById(int appointmentId)
        {
            // Create a SQL command to select the appointment by its ID
            SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE AppointmentId = @id", connection);
            command.Parameters.AddWithValue("@id", appointmentId); // Add parameter for appointment ID

            // Execute the command and retrieve the data reader
            SqlDataReader reader = command.ExecuteReader();

            // Check if any appointment record is returned
            if (reader.Read())
            {
                // Create and return an Appointment object with the data retrieved
                return new Appointment
                {
                    AppointmentId = (int)reader["AppointmentId"],
                    PatientId = (int)reader["PatientId"],
                    DoctorId = (int)reader["DoctorId"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    Description = reader["Description"].ToString()
                };
            }

            // Throw a custom exception if the appointment with the specified ID is not found
            throw new PatientNumberNotFoundException($"Appointment with ID {appointmentId} not found.");
        }

        // Method to get all appointments for a specific patient
        public List<Appointment> GetAppointmentsForPatient(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>(); // List to hold the appointments for the patient
            // Create a SQL command to select appointments for the patient ID
            SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE PatientId = @id", connection);
            command.Parameters.AddWithValue("@id", patientId); 
            SqlDataReader reader = command.ExecuteReader();

            // Read all records and add them to the appointments list
            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentId = (int)reader["AppointmentId"],
                    PatientId = (int)reader["PatientId"],
                    DoctorId = (int)reader["DoctorId"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    Description = reader["Description"].ToString()
                });
            }

            // Return the list of appointments for the specified patient
            return appointments;
        }

        // Method to get all appointments for a specific doctor
        public List<Appointment> GetAppointmentsForDoctor(int doctorId)
        {
            List<Appointment> appointments = new List<Appointment>(); 
            SqlCommand command = new SqlCommand("SELECT * FROM Appointment WHERE DoctorId = @id", connection);
            command.Parameters.AddWithValue("@id", doctorId); 

           
            SqlDataReader reader = command.ExecuteReader();

            // Read all records and add them to the appointments list
            while (reader.Read())
            {
                appointments.Add(new Appointment
                {
                    AppointmentId = (int)reader["AppointmentId"],
                    PatientId = (int)reader["PatientId"],
                    DoctorId = (int)reader["DoctorId"],
                    AppointmentDate = (DateTime)reader["AppointmentDate"],
                    Description = reader["Description"].ToString()
                });
            }

            // Return the list of appointments for the specified doctor
            return appointments;
        }

    
        public bool ScheduleAppointment(Appointment appointment)
        {
            // Create a SQL command to insert a new appointment
            SqlCommand command = new SqlCommand(
                "INSERT INTO Appointment (PatientId, DoctorId, AppointmentDate, Description) VALUES (@pid, @did, @date, @desc)",
                connection
            );
            // Add parameters for the appointment details
            command.Parameters.AddWithValue("@pid", appointment.PatientId);
            command.Parameters.AddWithValue("@did", appointment.DoctorId);
            command.Parameters.AddWithValue("@date", appointment.AppointmentDate);
            command.Parameters.AddWithValue("@desc", appointment.Description);

            // Execute the command and return whether the operation was successful
            int result = command.ExecuteNonQuery();
            return result > 0;
        }

        // Method to update an existing appointment
        public bool UpdateAppointment(Appointment appointment)
        {
            // Create a SQL command to update the appointment details
            SqlCommand command = new SqlCommand(
                "UPDATE Appointment SET AppointmentDate = @date, Description = @desc WHERE AppointmentId = @id",
                connection
            );
            // Add parameters for the appointment details
            command.Parameters.AddWithValue("@id", appointment.AppointmentId);
            command.Parameters.AddWithValue("@date", appointment.AppointmentDate);
            command.Parameters.AddWithValue("@desc", appointment.Description);

            // Execute the command and return whether the operation was successful
            int result = command.ExecuteNonQuery();
            return result > 0;
        }

        // Method to cancel an appointment
        public bool CancelAppointment(int appointmentId)
        {
            // Create a SQL command to delete the appointment by its ID
            SqlCommand command = new SqlCommand("DELETE FROM Appointment WHERE AppointmentId = @id", connection);
            command.Parameters.AddWithValue("@id", appointmentId); // Add parameter for appointment ID

            
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }
}
