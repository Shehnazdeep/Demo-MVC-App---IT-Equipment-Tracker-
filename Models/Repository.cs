using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1.Models
{
    public static class Repository
    {
        private static int _id = 0;
        private static List<EquipmentRequest> _requests;

        private static List<Equipment> _equipmentList;



             static Repository(){
            _requests = new List<EquipmentRequest>();

            _equipmentList = new List<Equipment>
        {
            new Equipment { EquipmentId = 1, Availability = true ,EquipmentType = "Laptop", EquipmentDescription = "MacBook 15" },
          new Equipment { EquipmentId = 2, Availability = true ,EquipmentType = "Phone", EquipmentDescription = "Iphone 11" },
          new Equipment { EquipmentId = 3, Availability = false ,EquipmentType = "Tablet", EquipmentDescription = "Samsung Tablet" },
          new Equipment { EquipmentId = 4, Availability = true ,EquipmentType = "Phone", EquipmentDescription = "Samsung Flip" },
          new Equipment { EquipmentId = 5, Availability = false ,EquipmentType = "Another", EquipmentDescription = "Iphone Charger" },
          new Equipment { EquipmentId = 6, Availability = true ,EquipmentType = "Laptop", EquipmentDescription = "Macbook Pro" },
            // Add more equipment items as needed
        };
        }

        public static bool AddRequest(EquipmentRequest request){


        _requests.Add(request);

            request.Id = ++_id;

        return true;
        



    }

    public static IEnumerable<EquipmentRequest> GetAll() => _requests;

    public static IEnumerable<Equipment> GetAllEquipments() => _equipmentList;


     public static IEnumerable<Equipment> GetAvailableEquipments() => _equipmentList.Where(x => x.Availability);

    }
}