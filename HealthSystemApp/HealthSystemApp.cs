using System;
using System.Collections.Generic;
using System.Linq;

public class HealthSystemApp
{
    private Repository<Patient> _patientRepo = new Repository<Patient>();
    private Repository<Prescription> _prescriptionRepo = new Repository<Prescription>();
    private Dictionary<int, List<Prescription>> _prescriptionMap = new();

    public void SeedData()
    {
        _patientRepo.Add(new Patient(1, "Kay Bondzie", 21, "Female"));
        _patientRepo.Add(new Patient(2, "David Cole", 35, "Male"));
        _patientRepo.Add(new Patient(3, "Amoah Joy", 28, "Female"));

        _prescriptionRepo.Add(new Prescription(1, 1, "Paracetamol", DateTime.Now.AddDays(-10)));
        _prescriptionRepo.Add(new Prescription(2, 1, "Amoxicillin", DateTime.Now.AddDays(-5)));
        _prescriptionRepo.Add(new Prescription(3, 2, "Ibuprofen", DateTime.Now.AddDays(-3)));
        _prescriptionRepo.Add(new Prescription(4, 3, "Cough Syrup", DateTime.Now.AddDays(-2)));
    }

    public void BuildPrescriptionMap()
    {
        _prescriptionMap = _prescriptionRepo.GetAll()
            .GroupBy(p => p.PatientId)
            .ToDictionary(g => g.Key, g => g.ToList());
    }

    public void PrintAllPatients()
    {
        Console.WriteLine("=== All Patients ===");
        foreach (var p in _patientRepo.GetAll())
        {
            Console.WriteLine(p);
        }
    }

    public void PrintPrescriptionsForPatient(int id)
    {
        if (_prescriptionMap.ContainsKey(id))
        {
            Console.WriteLine($"\nPrescriptions for Patient ID {id}:");
            foreach (var p in _prescriptionMap[id])
            {
                Console.WriteLine(p);
            }
        }
        else
        {
            Console.WriteLine("No prescriptions found for that patient.");
        }
    }
}
