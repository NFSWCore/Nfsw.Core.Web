using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Victory.DataLayer;
using Victory.DataLayer.Serialization;

namespace Nfsw.Core.Web.Controllers
{
    [Route("Engine.svc/[controller]")]
    public class PersonasController : Controller
    {
        [HttpGet("{personaId}/carslots")]
        public CarSlotInfoTrans carslots(long personaId, string language)
        {
            CarSlotInfoTrans carSlotInfoTrans = new CarSlotInfoTrans()
            {
                CarsOwnedByPersona = new List<OwnedCarTrans>() { getOwnedCarTransExample() },
                DefaultOwnedCarIndex = 0,
                ObtainableSlots = new List<ProductTrans>(),
                OwnedCarSlotsCount = 1
            };

            ProductTrans p = new ProductTrans();
            p.BundleItems = new List<ProductTrans>();
            p.CategoryId = 0;
            p.Currency = "_NS";
            p.Description = "New car slot !!";
            p.DurationMinute = 0;
            p.Hash = -1143680669;
            p.Icon = "128_cash";
            p.Level = 70;
            p.LongDescription = "New car slot !";
            p.Price = 100.00F;
            p.Priority = 0;
            p.ProductId = "SRV-GARAGESLOT";
            p.SecondaryIcon = "";
            p.UseCount = 0;
            p.VisualStyle = 0;
            p.WebIcon = "";
            p.WebLocation = "";

            carSlotInfoTrans.ObtainableSlots.Add(p);

            return carSlotInfoTrans;
        }

        /// <summary>
        /// GET http://localhost:7331/Engine.svc/personas/inventory/objects
        /// </summary>
        /// <returns></returns>
        [HttpGet("inventory/objects")]
        public InventoryTrans inventoryObjects()
        {
            var userId = long.Parse(HttpContext.Request.Headers["userId"]);

            InventoryTrans inventoryTrans = new InventoryTrans();

            inventoryTrans.InventoryItems = new List<InventoryItemTrans>()
            {
                new InventoryItemTrans()
                {
                    EntitlementTag = "nosshot",
                    Hash = -1681514783,
                    InventoryId = 1842996427L,
                    ProductId = "DO NOT USE ME",
                    RemainingUseCount = 100,
                    ResellPrice = 0.00,
                    Status = "ACTIVE",
                    VirtualItemType = "powerup"
                }
            };

            return inventoryTrans;
        }

        /// <summary>
        /// Example Data
        /// </summary>
        /// <returns></returns>
        private OwnedCarTrans getOwnedCarTransExample()
        {
            var customPaintTrans = new List<CustomPaintTrans>()
            {
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 0
                },
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 3
                },
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 4
                },
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 5
                },
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 6
                },
                new CustomPaintTrans()
                {
                    Group = 47885063,
                    Hue = 496032328,
                    Sat = 0,
                    Var = 0,
                    Slot = 7
                }
            };

            CustomCar customCar = new CustomCar()
            {
                Id = 12345678,
                BaseCar = 12345678,
                IsPreset = true,
                CarClassHash = 872416321,
                Name = "240sx",
                PhysicsProfileHash = -1469109252,
                SkillModSlotCount = 5,
                Paints = customPaintTrans,
                PerformanceParts = new List<PerformancePartTrans>(),
                Rating = 224,
                ResalePrice = 65000,
                RideHeightDrop = 0,
                SkillModParts = new List<SkillModPartTrans>(),
                Vinyls = new List<CustomVinylTrans>(),
                VisualParts = new List<VisualPartTrans>()
            };


            return new OwnedCarTrans()
            {
                CustomCar = customCar,
                Id = 123456L,
                Durability = 100,
                ExpirationDate = DateTime.Now,
                Heat = 0,
                OwnershipType = "PresetCar"
            };
        }
    }
}