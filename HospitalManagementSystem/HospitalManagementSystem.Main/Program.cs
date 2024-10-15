using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.Entity;
using HospitalManagementSystem.DAO.Repository;
using HospitalManagementSystem.DAO.Service;
using HospitalManagementSystem.Exception;

namespace HospitalManagementSystem.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            IHospitalService hospitalService = new HospitalRepositoryImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Hospital Management System ---");
                Console.WriteLine("1. Schedule Appointment");
                Console.WriteLine("2. Get Appointment by ID");
                Console.WriteLine("3. Get Appointments for Patient");
                Console.WriteLine("4. Get Appointments for Doctor");
                Console.WriteLine("5. Cancel Appointment");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            ScheduleAppointment(hospitalService);
                            break;
                        case 2:
                            GetAppointmentById(hospitalService);
                            break;
                        case 3:
                            GetAppointmentsForPatient(hospitalService);
                            break;
                        case 4:
                            GetAppointmentsForDoctor(hospitalService);
                            break;
                        case 5:
                            CancelAppointment(hospitalService);
                            break;
                        case 6:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static void ScheduleAppointment(IHospitalService service)
        {
            Console.Write("Enter Patient ID: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter Doctor ID: ");
            int doctorId = int.Parse(Console.ReadLine());

            Console.Write("Enter Appointment Date (yyyy-MM-dd HH:mm): ");
            DateTime appointmentDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Appointment appointment = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                AppointmentDate = appointmentDate,
                Description = description
            };

            if (service.ScheduleAppointment(appointment))
            {
                Console.WriteLine("Appointment scheduled successfully.");
            }
            else
            {
                Console.WriteLine("Failed to schedule appointment.");
            }
        }

        static void GetAppointmentById(IHospitalService service)
        {
            Console.Write("Enter Appointment ID: ");
            if (int.TryParse(Console.ReadLine(), out int appointmentId))
            {
                try
                {
                    Appointment appointment = service.GetAppointmentById(appointmentId);
                    Console.WriteLine($"Appointment: {appointment.Description}, Date: {appointment.AppointmentDate}");
                }
                catch (PatientNumberNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid appointment ID.");
            }
        }

        static void GetAppointmentsForPatient(IHospitalService service)
        {
            Console.Write("Enter Patient ID: ");
            if (int.TryParse(Console.ReadLine(), out int patientId))
            {
                var appointments = service.GetAppointmentsForPatient(patientId);

                if (appointments.Count > 0)
                {
                    foreach (var appointment in appointments)
                    {
                        Console.WriteLine($"Appointment ID: {appointment.AppointmentId}, Date: {appointment.AppointmentDate}, Description: {appointment.Description}");
                    }
                }
                else
                {
                    Console.WriteLine("No appointments found for this patient.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid patient ID.");
            }
        }

        static void GetAppointmentsForDoctor(IHospitalService service)
        {
            Console.Write("Enter Doctor ID: ");
            if (int.TryParse(Console.ReadLine(), out int doctorId))
            {
                var appointments = service.GetAppointmentsForDoctor(doctorId);

                if (appointments.Count > 0)
                {
                    foreach (var appointment in appointments)
                    {
                        Console.WriteLine($"Appointment ID: {appointment.AppointmentId}, Date: {appointment.AppointmentDate}, Description: {appointment.Description}");
                    }
                }
                else
                {
                    Console.WriteLine("No appointments found for this doctor.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid doctor ID.");
            }
        }

        static void CancelAppointment(IHospitalService service)
        {
            Console.Write("Enter Appointment ID: ");
            if (int.TryParse(Console.ReadLine(), out int appointmentId))
            {
                if (service.CancelAppointment(appointmentId))
                {
                    Console.WriteLine("Appointment canceled successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to cancel appointment.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid appointment ID.");
            }
        }
    }
}

